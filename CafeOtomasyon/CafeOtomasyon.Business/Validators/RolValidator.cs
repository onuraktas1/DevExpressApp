using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class RolValidator : AbstractValidator<Rol>
    {
        public RolValidator()
        {
            RuleFor(x => x.ControlName)
                .MaximumLength(50)
                .WithMessage("Control name 50 karakterden fazla olamaz");

            RuleFor(x => x.ControlCaption)
                .MaximumLength(50)
                .WithMessage("Control caption 50 karakterden büyük olamaz");

            RuleFor(x => x.FormName)
                .MaximumLength(50)
                .WithMessage("Form name 50 karakterden büyük olamaz");
        }
    }
}
