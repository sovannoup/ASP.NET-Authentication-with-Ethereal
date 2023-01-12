using System.ComponentModel.DataAnnotations;

namespace Exchange.Controllers.Request
{
    public class ForgetPasswordRequest
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        public string Email { get; set; }
    }
}
