using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class DersKategoriValidator : AbstractValidator<DersKategori>
    {
        public DersKategoriValidator()
        {

            //  RuleFor(o => o.DersKategoriId).NotEmpty();

        }


    }
}
