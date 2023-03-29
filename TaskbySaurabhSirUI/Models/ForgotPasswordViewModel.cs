using System.ComponentModel.DataAnnotations;

namespace TaskbySaurabhSirUI.Models
{
	public class ForgotPasswordViewModel
	{
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }
	}
}
