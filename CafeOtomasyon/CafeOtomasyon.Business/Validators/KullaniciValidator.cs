using CafeOtomasyon.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Validators
{
    public class KullaniciValidator : AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(x => x.AdSoyad)
                .NotNull()
                .NotEmpty()
                .WithMessage("Ad soyad alanı boş geçilemez.")
                .MinimumLength(3)
                .MaximumLength(100)
                .WithMessage("Ad soyad alanı 3-100 karakter arası olmalıdır");

            RuleFor(x => x.KullaniciAdi)
                .NotEmpty()
                .NotEmpty()
                .WithMessage("Kullanı adı boş geçilemez.")
                .MinimumLength(3)
                .MaximumLength(50)
                .WithMessage("Kullanıcı adı 3-50 karakter arası olmalıdır.");

            RuleFor(x => x.Parola)
                .NotEmpty()
                .NotNull()
                .WithMessage("Parola boş geçilemez")
                .MinimumLength(6)
                .MaximumLength(20)
                .WithMessage("Parola 6-20 karakter arası olmalıdır.");

            RuleFor(x => x.Telefon)
                .NotEmpty()
                .NotNull()
                .WithMessage("Telefon alanı boş geçilemez")
                .MinimumLength(11)
                .MaximumLength(11)
                .WithMessage("Telefon numarası 11 karakter olmalıdır.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Email alanı boş geçilemez")
                .MaximumLength(150)
                .WithMessage("Email 150 karakterden büyük olamaz.")
                .EmailAddress()
                .WithMessage("Lütfen geçerli email adresi giriniz.");


        }
    }
}
