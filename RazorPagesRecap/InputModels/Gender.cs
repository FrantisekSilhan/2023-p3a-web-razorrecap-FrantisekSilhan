using System.ComponentModel.DataAnnotations;

namespace RazorPagesRecap.InputModels
{
    public enum Gender
    {
        [Display(Name = "Muž")]
        Male = 0,
        [Display(Name = "Žena")]
        Female = 1,
        [Display(Name = "Ostatní")]
        Email = 2
    }
}
