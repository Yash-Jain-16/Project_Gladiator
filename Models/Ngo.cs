using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Women_Empowerment.Models
{
    public class Ngo
    {
      public int Ngo_Id {get;set;}
      public int User_Id {get;set;}
      public string Point_of_Contact {get;set;}
      public string Ngo_Email {get;set;}
      public string Contact {get;set;}
      public string Telephone {get;set;}
      public string Address {get;set;}
      public string State {get;set;}
      public string City {get;set;}
      public string Pincode {get;set;}
      public string Identity_Proof {get;set;}
      public string Identity_Proof_Image {get;set;}
      public DateTime Date_of_Register {get;set;}
      public string Reg_Paper {get;set;}
      public int Is_Aprooved {get;set;}
      public int Is_Active {get;set;}
      public string Ngo_Name {get;set;}
    }
}
