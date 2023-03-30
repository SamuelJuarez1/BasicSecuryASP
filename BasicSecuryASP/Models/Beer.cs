using System.ComponentModel.DataAnnotations;

namespace BasicSecuryASP.Models
{
    public class Beer
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Brand { get; set; } 
        public float Alcohol { get; set; }    

    }
}
