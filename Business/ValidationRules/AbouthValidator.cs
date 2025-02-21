﻿using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AbouthValidator : AbstractValidator<Abouth>
    {
        public AbouthValidator() 
        { 
             RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçmeyiniz.!");   
             
        }
    }
}
