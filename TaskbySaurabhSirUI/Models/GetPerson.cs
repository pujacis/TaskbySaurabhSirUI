using System.ComponentModel.DataAnnotations;

namespace TaskbySaurabhSirUI.Models
{
    public class GetPerson
    {
        public int PersonId { get; set; }
        [Required(ErrorMessage = "User FirstName is required")]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Display(Name = "Email Address")]
        [EmailAddress]
        [Required(ErrorMessage = "User LastName is required")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "User Country is required")]
        [Display(Name = "Country Name")]
        public int CountryId { get; set; }
        [Required(ErrorMessage = "User State is required")]
        [Display(Name = "State Name")]
        public int StateId { get; set; }
        [Required(ErrorMessage = "User City is required")]
        [Display(Name = "City Name")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "User Country is required")]
        [Display(Name = "Country Name")]
        public string? CountryName { get; set; }
        [Required(ErrorMessage = "User State is required")]
        [Display(Name = "State Name")]
        public string? SatateName { get; set; }
        [Required(ErrorMessage = "User City is required")]
        [Display(Name = "City Name")]
        public string? CityName { get; set; }
        [Required(ErrorMessage = "User Address is required")]
        [Display(Name = "Address")]
        public string? Address { get; set; }
        public string? FileName { get; set; }
        [Display(Name = "Image")]
        // public string UploadFile { get; set; }
        [Required(ErrorMessage = "User Image is required")]
        public string? base64data { get; set; }
    }
}
