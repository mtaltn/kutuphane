using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class KitapValidator:AbstractValidator<Kitap>
    {
        public KitapValidator()
        {
            RuleFor(x => x.kitapbasligi).NotEmpty().WithMessage("Kitap adı boş bırakılamaz");
            RuleFor(x => x.ISBN).NotEmpty().WithMessage("ISBN boş bırakılamaz");
            RuleFor(x => x.fiyat).NotEmpty().WithMessage("Fiyat boş bırakılamaz");
            RuleFor(x => x.yayinyili).NotEmpty().WithMessage("Yayın yılı boş bırakılamaz");
            

            RuleFor(x => x.kitapbasligi).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girin");
            RuleFor(x => x.kitapbasligi).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girin");
            
        }
    }
}
