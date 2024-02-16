using HomeWork12.Models;

namespace HomeWork12.Validators;

using FluentValidation;
using System;

public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator()
    {
        RuleFor(x => x.Country)
            .NotEmpty().WithMessage("Country is required.");

        RuleFor(x => x.City)
            .NotEmpty().WithMessage("City is required.");

        RuleFor(x => x.HomeNumber)
            .NotEmpty().WithMessage("HomeNumber is required.");
    }
}