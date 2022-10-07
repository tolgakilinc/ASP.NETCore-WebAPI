using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AlanValidator : AbstractValidator<Alan>
    {
        public AlanValidator()
        {

            RuleFor(o => o.AlanId).NotEmpty();

        }


    }
}
