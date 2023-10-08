using System.ComponentModel.DataAnnotations;

namespace RazorPagesRecap.InputModels
{
    public enum Municipalities
    {
        [Display(Name = "Železný Brod")]
        ZeleznyBrod = 0,
        [Display(Name = "Splzov")] 
        Splzov = 1,
        [Display(Name = "Pěnčín")]
        Pencin = 2
    }
}
