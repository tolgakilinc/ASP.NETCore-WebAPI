using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class SehirValidator : AbstractValidator<Sehir>
    {
        public SehirValidator()
        {
            //bölüm için kurallar buraya yazılır.
            RuleFor(p => p.SehirId).NotEmpty();

        }


    }
}
