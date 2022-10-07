using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class DenemeValidator : AbstractValidator<Deneme>
    {
        public DenemeValidator()
        {

          //  RuleFor(o => o.DenemeId).NotEmpty();

        }


    }
}
