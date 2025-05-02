using FluentValidation;
using Cinema.DTOs;
public class MovieEditDtoValidator : AbstractValidator<MovieEditDto>
{
    public MovieEditDtoValidator()
    {
        Include(new MovieCreateDtoValidator());

        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("Id must be greater than 0.");
    }
}
