using System.ComponentModel.DataAnnotations;

namespace cursoazuredevops.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}