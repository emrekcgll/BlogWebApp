using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Lütfen blog bağlığı giriniz.").MinimumLength(5).WithMessage("Blog başlığınız minimum 5 karakter olmalıdır.").MaximumLength(150).WithMessage("Blog başlığı en fazla 150 karakter olabilir.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Lütfen blog içeriğini giriniz.").MinimumLength(131).WithMessage("Blog içeriğini 130 karakterden fazla girmelisiniz.");
            RuleFor(x => x.BlogImg).NotEmpty().WithMessage("Blog görselini ekleyiniz.");        
        }
    }
}
