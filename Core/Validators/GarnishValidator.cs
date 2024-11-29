using Data.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class GarnishValidator : AbstractValidator<CreateGarnishDto>
    {
        public GarnishValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
             .MinimumLength(2)
                   .Matches("[A-Z].*").WithMessage("{PropertyName} must starts with uppercase letter.");
        }
    }
}
