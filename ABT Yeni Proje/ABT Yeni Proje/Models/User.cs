using System.ComponentModel.DataAnnotations;
using ABT_Yeni_Proje.Models;

namespace ABT_Yeni_Proje.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        public string Name { get; set; }


        public string Email { get; set; }

        public string Password { get; set; }
        public ICollection<Activity>? Activities { get; set; }

    }
}
