using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class SatisKoduValidator : AbstractValidator<SatisKodu>
    {
        public SatisKoduValidator()
        {
            RuleFor(x => x.SatisTanimi)
                .MaximumLength(20)
                .WithMessage("Sati tanımı 20 karakterden büyük olamaz");
        }
    }
}
