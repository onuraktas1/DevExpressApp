using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class MasaHareketiValidator : AbstractValidator<MasaHareketi>
    {
        public MasaHareketiValidator()
        {
            RuleFor(x => x.SatisKodu)
                .NotNull()
                .NotEmpty()
                .WithMessage("Satis kodu alanı boş geçilemez.")
                .MaximumLength(15)
                .WithMessage("Satiskodu 15 karakterden büyük olamaz");

            RuleFor(x => x.Miktar)
                .NotNull()
                .NotEmpty()
                .WithMessage("Miktar alanı boş geçilemez.")
                .GreaterThanOrEqualTo(1)
                .WithMessage("Miktar alanı 1 veya daha büyük değer olmalı.");

            RuleFor(x => x.BirimFiyati)
                .NotNull()
                .NotEmpty()
                .WithMessage("Birim Fiyatı alanı boş geçilemez.")
                .GreaterThanOrEqualTo(1)
                .WithMessage("Birim fiyatı alanı 1 veya daha büyük değer olmalı.");

            RuleFor(x => x.Aciklama)
                .MaximumLength(300)
                .WithMessage("Aciklama maksimum 300 karakter olabilir");

        }
    }
}
