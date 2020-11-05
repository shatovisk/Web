using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Введите вопрос")]
        [Display(Name = "Вопрос")]
        public override string Title { get; set; }

        [Display(Name = "Ответ")]
        public override string Text { get; set; }

    }
}
