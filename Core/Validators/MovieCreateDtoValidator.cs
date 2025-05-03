using FluentValidation;
using Core.DTOs;

namespace Core.Validators;

public class MovieCreateDtoValidator : AbstractValidator<MovieCreateDto>
{
    public MovieCreateDtoValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required.")
            .Length(1, 100).WithMessage("Title must be between 1 and 100 characters.");

        RuleFor(x => x.Year)
            .InclusiveBetween(1888, DateTime.Now.Year).WithMessage("Year must be between 1888 and the current year.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required.");

        RuleFor(x => x.Genre)
            .NotEmpty().WithMessage("Genre is required.");

        RuleFor(x => x.Duration)
            .GreaterThan(0).WithMessage("Duration must be greater than 0.");

        RuleFor(x => x.CoverImage)
            .NotEmpty().WithMessage("Cover image is required.");

        RuleFor(x => x.Country)
            .NotEmpty().WithMessage("Country is required.");

        RuleFor(x => x.TrailerUrl)
            .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _)).WithMessage("Invalid URL format.");
    }
}
