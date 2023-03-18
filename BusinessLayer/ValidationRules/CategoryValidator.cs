using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
	public class CategoryValidator:AbstractValidator<Category>
	{
		public CategoryValidator()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz.");
			RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz.");
			RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori adı en fazla 50 karakterden oluşmalıdır.");
			RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Kategori adı en az 2 karakterden oluşmalıdır.");			
			RuleFor(x => x.CategoryDescription).MinimumLength(10).WithMessage("Kategori açıklaması en az 10 karakterden oluşmalıdır.");
		}		
	}
}
