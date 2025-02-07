using System.ComponentModel.DataAnnotations;

namespace tourdalCommerce.Models{
    public class UserModel{
        // registration
        [Key]
        public int UserId {get; set;}
        public required string UserName{get; set ;}
        [EmailAddress]
        public required string UserMail{get;set;}
        public required string Password{get; set;}
        public required long Phone{get; set;}
    }

    public class UserLogin{
public required string UserName{get; set ;}
  public required string Password{get; set;}
    }
}