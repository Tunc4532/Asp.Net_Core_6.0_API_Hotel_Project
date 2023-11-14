using FluentValidation;
using HotelProject.WebUI.DTOs.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("soyisim alanı boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("şehir alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("en az 3 karakterlik veri girişi yapmalısınız");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("en az 2 karakterlik veri girişi yapmalısınız");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("en az 3 karakterlik veri girişi yapmalısınız");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("en fazla 20 karakterlik veri girişi yapabilirsiniz");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("en fazla 30 karakterlik veri girişi yapabilirsiniz");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("en fazla 20 karakterlik veri girişi yapabilirsiniz");

        }
    }
}
