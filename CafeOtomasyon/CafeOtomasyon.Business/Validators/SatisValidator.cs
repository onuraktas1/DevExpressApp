using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class SatisValidator : AbstractValidator<Satis>
    {
        public SatisValidator()
        {
            RuleFor(x => x.Aciklama)
                .MaximumLength(300)
                .WithMessage("Açıklama 300 karakterden fazla olamaz");

            RuleFor(x => x.SatisKodu)
                .MaximumLength(50)
                .WithMessage("Satis kodu 50 karakterden fazla olamaz");
        }
    }
}
