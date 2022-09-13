using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş bırakamazsınız.").MinimumLength(3).WithMessage("Kategori adı 3 karakterden kısa olamaz.").MaximumLength(12).WithMessage("Kategori adı 12 karakterden fazla olamaz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş bırakamazsınız.");
        }
    }
}
