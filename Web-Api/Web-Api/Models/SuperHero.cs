using System.ComponentModel.DataAnnotations;

namespace Web_Api.Models
{
    public class SuperHero
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string PLACE { get; set; }
    }
}
