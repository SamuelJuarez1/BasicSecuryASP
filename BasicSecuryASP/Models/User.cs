using System.ComponentModel.DataAnnotations;

namespace BasicSecuryASP.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
