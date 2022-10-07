using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class VeliTakipValidator : AbstractValidator<VeliTakip>
    {
        public VeliTakipValidator()
        {

            RuleFor(o => o.VeliTakipId).NotEmpty();

        }


    }
}
