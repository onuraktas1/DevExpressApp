using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class MusteriValidator : AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(x => x.AdiSoyadi)
                .NotNull()
                .NotEmpty()
                .WithMessage("Ad soyad boş geçilemez");

            RuleFor(x => x.Telefon)
                .NotNull()
                .NotEmpty()
                .WithMessage("Telefon numarası boş geçilemez")
                .MinimumLength(11)
                .MaximumLength(11)
                .WithMessage("Telefon numarası 11 karakter olması zorunludur");

            RuleFor(x => x.Aciklama)
                .MaximumLength(500)
                .WithMessage("Açıklama 500 karakterden fazla olamaz");
        }
    }
}
