using System.ComponentModel.DataAnnotations;

namespace VS.DLQ.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}