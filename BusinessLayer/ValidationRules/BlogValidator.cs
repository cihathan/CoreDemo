using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı alanı boş geçilemez.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği alanı boş geçilemez.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görseli alanı boş geçilemez.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Başlık alanı 150 karakterden büyük olamaz.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Başlık alanı 5 karakterden küçük olamaz.");
        }
    }
}
