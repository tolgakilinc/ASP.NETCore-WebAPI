using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BolumValidator : AbstractValidator<Bolum>
    {
        public BolumValidator()
        {
            //bölüm için kurallar buraya yazılır.
            RuleFor(p => p.BolumAdi).NotEmpty();
            RuleFor(p => p.BolumAdi).MinimumLength(2);
    
        }

        
    }
}
