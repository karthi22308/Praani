using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Praani.Models
{
    public class user
    {
        [Key]
        public int userid { get; set; }

        public string mobilenumber { get; set; }

        public string password { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string email { get; set; }
    }
}
