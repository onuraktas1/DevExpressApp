using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class MenuValidator : AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(x => x.MenuAdi)
                .NotEmpty()
                .NotNull()
                .WithMessage("Menu adı boş geçilemez.")
                .MaximumLength(75)
                .WithMessage("Menu adı 75 karakterden büyük olamaz");
        }
    }
}
