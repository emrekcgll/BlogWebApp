using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad soyad boş bırakılamaz.").Length(6, 30).WithMessage("Geçerli bir ad soyad giriniz.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Email boş bırakılamaz.").EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
        }
    }
}
