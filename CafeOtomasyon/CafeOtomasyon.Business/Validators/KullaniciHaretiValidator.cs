﻿using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class KullaniciHaretiValidator : AbstractValidator<KullaniciHareketi>
    {
        public KullaniciHaretiValidator()
        {

            RuleFor(x => x.Aciklama)
                .MaximumLength(300)
                .WithMessage("Aciklama maksimum 300 karakter olabilir");

        }
    }
}
