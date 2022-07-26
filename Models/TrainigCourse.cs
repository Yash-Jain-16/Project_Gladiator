using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Women_Empowerment.Models
{
    public class TrainigCourse
    {
      public int Course_Id {get;set;}
      public string Sector {get;set;}
      public string Coursename {get;set;}
      public int Intake {get;set;}
      public DateTime Start_Date {get;set;}
      public DateTime End_Date {get;set;}
      public int Is_Active {get;set;}
    }
}
