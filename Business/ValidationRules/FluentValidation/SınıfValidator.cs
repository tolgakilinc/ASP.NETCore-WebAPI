using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class SınıfValidator : AbstractValidator<Sınıf>
    {
        public SınıfValidator()
        {
            //bölüm için kurallar buraya yazılır.
         //   RuleFor(p => p.SınıfAdi).NotEmpty();
         //   RuleFor(p => p.SınıfAdi).MinimumLength(2);

        }


    }
}
