using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı alanı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi alanı boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("İsim alanı en az 2 karakterden oluşmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Ad Soyad alanı 50 karakterden büyük olamaz.");           
        }
    }
}
