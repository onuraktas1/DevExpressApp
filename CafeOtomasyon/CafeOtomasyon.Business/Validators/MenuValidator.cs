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
                .MinimumLength(2)
                .WithMessage("Menu adı 2-75 karakter aralığında olmalı");

            RuleFor(x => x.Aciklama)
                .MaximumLength(300)
                .WithMessage("Aciklama maksimum 300 karakter olabilir");
        }
    }
}
