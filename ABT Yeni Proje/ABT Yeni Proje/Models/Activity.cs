using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ABT_Yeni_Proje.Models;

namespace ABT_Yeni_Proje.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        //public User User { get; set; }
    }
}
