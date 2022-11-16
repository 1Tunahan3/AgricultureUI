using System.ComponentModel.DataAnnotations;

namespace AgricultureUI.Models
{
    public class ServiceAddViewModel
    {

        [Display(Name ="Title")]
        [Required(ErrorMessage ="it cannot be null")]
        public string Title { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "it cannot be null")]
        public string Image { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "it cannot be null")]
        public string Description { get; set; }
    }
}
