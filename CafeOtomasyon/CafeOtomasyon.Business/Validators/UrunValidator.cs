using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class UrunValidator : AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(x => x.UrunKodu)
                .NotNull()
                .NotEmpty()
                .WithMessage("Urun kodu girilmesi zorunludur.")
                .MaximumLength(15)
                .WithMessage("Urun kodu 15 karakterden fazla olamaz");

            RuleFor(x => x.UrunAdi)
                .NotEmpty()
                .NotNull()
                .WithMessage("Urun adı girilmesi zorunludur.")
                .MaximumLength(50)
                .WithMessage("Urun adı maksimum 50 karakter olabilir.");

            RuleFor(x => x.Aciklama)
                .MaximumLength(300)
                .WithMessage("Açıklama maksimum 300 karakter olabilir.");

            RuleFor(x => x.BirimFiyati1)
                .NotEmpty()
                .NotNull()
                .WithMessage("Birim fiyatı girilmesi zorunludur.")
                .GreaterThanOrEqualTo(1)
                .WithMessage("Birim fiyatı 1 veya daha fazla olmalıdır.");

            RuleFor(x => x.BirimFiyati2)
                .NotEmpty()
                .NotNull()
                .WithMessage("Birim fiyatı2 girilmesi zorunludur.")
                .GreaterThanOrEqualTo(1)
                .WithMessage("Birim fiyatı2 1 veya daha fazla olmalıdır.");

        }
    }
}
