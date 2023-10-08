using System.ComponentModel.DataAnnotations;

namespace RazorPagesRecap.InputModels
{
    public class FormIM
    {
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Starší 15 let?")]
        public bool IsOver15 { get; set; }
        [Display(Name = "Bydliště")]
        public Municipality Municipality { get; set; }
        [Display(Name = "Pohlaví")]
        public Gender Gender { get; set; }
        [Display(Name = "Oslovení")]
        public string Pronouns { get; set; }
        [Display(Name = "Informace")]
        [Required]
        [MinLength(30)]
        public string Information { get; set; }
    }
}
