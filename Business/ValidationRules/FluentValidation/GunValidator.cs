using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class GunValidator : AbstractValidator<Gun>
    {
        public GunValidator()
        {
            //gun için kurallar buraya yazılır.
         

        }


    }
}
