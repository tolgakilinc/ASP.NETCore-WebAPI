using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class DiplomaValidator : AbstractValidator<Diploma>
    {
        public DiplomaValidator()
        {

            RuleFor(o => o.DiplomaNumarasi).NotEmpty();

        }


    }
}   
