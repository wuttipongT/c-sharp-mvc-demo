using System.ComponentModel.DataAnnotations;
namespace WMS_Web_SCG_CDMA.Models
{  
    public class LoginViewModel
    {  
        [Required]  
        [Display(Name = "Username")]  
        public string Username
        {  
            get;  
            set;  
        }  
        [Required]  
        [DataType(DataType.Password)]  
        [Display(Name = "Password")]  
        public string Password
        {  
            get;  
            set;  
        }  
    }  
}  
