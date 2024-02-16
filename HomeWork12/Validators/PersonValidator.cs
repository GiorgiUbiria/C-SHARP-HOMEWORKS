using HomeWork12.Models;

namespace HomeWork12.Validators;

using FluentValidation;
using System;

public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(x => x.CreateDate)
            .LessThanOrEqualTo(DateTime.Now)
            .WithMessage("CreateDate cannot be in the future.");

        RuleFor(x => x.Firstname)
            .NotEmpty().WithMessage("Firstname is required.")
            .Length(3, 50).WithMessage("Firstname must be between 3 and 50 characters.");

        RuleFor(x => x.Lastname)
            .NotEmpty().WithMessage("Lastname is required.")
            .Length(3, 50).WithMessage("Lastname must be between 3 and 50 characters.");

        RuleFor(x => x.JobPosition)
            .NotEmpty().WithMessage("JobPosition is required.")
            .Length(3, 50).WithMessage("JobPosition must be between 3 and 50 characters.");

        RuleFor(x => x.Salary)
            .GreaterThan(0).WithMessage("Salary must be greater than 0.")
            .LessThan(10000).WithMessage("Salary must be less than 10000.");

        RuleFor(x => x.WorkExperience)
            .NotEmpty().WithMessage("WorkExperience is required.");

        RuleFor(x => x.PersonAddress)
            .SetValidator(new AddressValidator());
    }
}