using System.ComponentModel.DataAnnotations;

namespace TestXia.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}