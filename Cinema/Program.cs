using Data;
using Core.Helpers;
using Core.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using FluentValidation;
using Core.Validators;
using FluentValidation.AspNetCore;
using Core.Extensions;
using Core.Interfaces;
using Cinema.Services;
using Data.Entities;

var builder = WebApplication.CreateBuilder(args);


string? connStr = builder.Configuration.GetConnectionString("SomeDb");
if (string.IsNullOrEmpty(connStr))
{
    throw new InvalidOperationException("The connection string 'SomeDb' is not defined.");
}

// Реєстрація контролерів та UI
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MovieDbContext>(options =>
    options.UseSqlServer(connStr, b => b.MigrationsAssembly("DataAccess")));

// Налаштування Identity
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
    .AddDefaultTokenProviders()
    .AddDefaultUI()
    .AddEntityFrameworkStores<MovieDbContext>();

// Налаштування email-сервісу (MailJet)
// Зверніть увагу: розділ у конфігурації має назву "MailJetSettings"
builder.Services.Configure<MailJetSettings>(builder.Configuration.GetSection("MailJetSettings"));
builder.Services.AddScoped<IEmailSender, EmailService>();

// Реєстрація AutoMapper та FluentValidation
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddValidatorsFromAssemblyContaining<MovieCreateDtoValidator>();
builder.Services.AddFluentValidationClientsideAdapters();

// Реєстрація сервісів
builder.Services.AddScoped<FavoritesServiceOptimized>();
builder.Services.AddScoped<FavoritesServiceDb>();
builder.Services.AddScoped<FavoritesServiceLocal>();
builder.Services.AddScoped<ISeatService, SeatService>();

// Реєстрація IFavoriteService з вибором залежно від автентифікації
builder.Services.AddScoped<IFavoriteService>(provider =>
{
    var httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
    var user = httpContextAccessor.HttpContext?.User;
    return (user?.Identity?.IsAuthenticated ?? false)
        ? provider.GetRequiredService<FavoritesServiceDb>()
        : provider.GetRequiredService<FavoritesServiceOptimized>();
});

// Доступ до HTTP контексту та сесій
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(7);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Ініціалізація бази даних
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        SeedData.Initialize(services);
        await services.SeedRoles();
        await services.SeedAdmin();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the database.");
    }
}

// Налаштування середовища
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();