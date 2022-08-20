using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class UserAccounts
    {
        [Key]
       
        
        public string UserId { get; set; }
      
        public string First_Name { get; set; }

        public string Last_Name { get; set; }


     
        
        public string EmailAddress { get; set; }
       
        public string password { get; set; }
     
        public string ConfirmPassword { get; set; }
       
        public string Role { get; set; }
    }
}
