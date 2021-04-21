using System.ComponentModel.DataAnnotations;

namespace WSADFinalProject.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(255)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(255)]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Your message is too long or you haven't entered one.")]
        [StringLength(1000)]
        public string Message { get; set; }
    }
}
