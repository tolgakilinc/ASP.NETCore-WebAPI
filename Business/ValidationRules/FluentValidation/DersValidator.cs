using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class DersValidator : AbstractValidator<Ders>
    {
        public DersValidator()
        {

            RuleFor(o => o.DersId).NotEmpty();

        }


    }
}
