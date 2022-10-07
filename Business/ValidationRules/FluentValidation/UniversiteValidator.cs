using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UniversiteValidator : AbstractValidator<Universite>
    {
        public UniversiteValidator()
        {

            RuleFor(o => o.UniversiteId).NotEmpty();

        }


    }
}
