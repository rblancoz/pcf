using System.ComponentModel.DataAnnotations;

namespace PersonalCashFlow.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}