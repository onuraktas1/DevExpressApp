using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class MasaValidator : AbstractValidator<Masa>
    {
        public MasaValidator()
        {
            RuleFor(x => x.MasaAdi)
                .NotEmpty()
                .NotEmpty()
                .WithMessage("Masa adı alanı boş geçilemez.")
                .MaximumLength(15)
                .WithMessage("Masa adı 15 karakterden büyük olamaz");
        }
    }
}
