using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class LiseValidator : AbstractValidator<Lise>
    {
        public LiseValidator()
        {

            RuleFor(o => o.LiseId).NotEmpty();

        }


    }
}
