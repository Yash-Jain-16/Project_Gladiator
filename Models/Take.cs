using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Women_Empowerment.Models
{
    public class Take
    {
       public int Step_Id { get; set; }
       public int Course_Id { get; set; }
       public int Approval_Status { get; set; }
       public DateTime Date_of_Register { get; set; }
       public int Activity { get; set; }
    }
}
