using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Women_Empowerment.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
