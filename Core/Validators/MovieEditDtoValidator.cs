using FluentValidation;
using Core.DTOs;

namespace Core.Validators;
public class MovieEditDtoValidator : AbstractValidator<MovieEditDto>
{
    public MovieEditDtoValidator()
    {
        Include(new MovieCreateDtoValidator());

        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("Id must be greater than 0.");
    }
}
