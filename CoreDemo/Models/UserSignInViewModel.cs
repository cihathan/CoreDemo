using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı adınızı giriniz")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
        public string password { get; set; }
    }
}
