using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public string Country { get; set; }
  
        public string First_Name { get; set; }
     
        public string Last_Name { get; set; }
  
        public string Address { get; set; }
    
        public string Apartment { get; set; }
     

        public string city { get; set; }
      
        public string state { get; set; }
 
        public string Pin_Code { get; set; }


        public string Phone_Number { get; set; }
     
        public int User_Id { get; set; }
    }
}
