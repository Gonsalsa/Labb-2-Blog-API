using System.ComponentModel.DataAnnotations;

namespace Labb_2_Blog_API.Data.Enteties
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
