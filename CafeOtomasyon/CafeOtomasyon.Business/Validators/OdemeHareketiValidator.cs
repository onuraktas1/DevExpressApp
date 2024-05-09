using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    internal class OdemeHareketiValidator : AbstractValidator<OdemeHareketi>
    {
        public OdemeHareketiValidator()
        {
            RuleFor(x => x.OdemeTuru)
                .NotEmpty()
                .NotNull()
                .WithMessage("Ödeme türü boş geçilemez")
                .MaximumLength(50)
                .WithMessage("Ödeme türü 50 karakterden fazla olamaz");

            RuleFor(x => x.Aciklama)
                .MaximumLength(300)
                .WithMessage("Aciklama maksimum 300 karakter olabilir");

            RuleFor(x => x.SatisKodu)
                .MaximumLength(15)
                .WithMessage("Satış kodu 15 karakterden fazla olamaz.");

        }
    }
}
