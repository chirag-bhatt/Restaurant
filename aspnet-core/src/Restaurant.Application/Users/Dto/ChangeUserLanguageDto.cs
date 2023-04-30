using System.ComponentModel.DataAnnotations;

namespace Restaurant.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}