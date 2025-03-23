using Microsoft.EntityFrameworkCore;
using Cinema.Data;
using Cinema.Services;
using Cinema;

var builder = WebApplication.CreateBuilder(args);
string connStr = builder.Configuration.GetConnectionString("SomeeDb");

if (string.IsNullOrEmpty(connStr))
{
    throw new InvalidOperationException("The connection string 'SomeeDb' is not defined.");
}

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MovieDbContext>(opts =>
    opts.UseSqlServer(connStr));

builder.Services.AddScoped<FavoritesService>();
builder.Services.AddHttpContextAccessor();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(7);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the database.");
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();