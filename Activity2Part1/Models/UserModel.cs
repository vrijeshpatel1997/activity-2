using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Activity2Part1.Models
{
    public class UserModel
    {
    

     public   string Name { get; set; }
     public    string emailAddress { get; set; }
      public   string PhoneNumber { get; set; }

        public UserModel()
        {

        }
        public UserModel(string Name, string Email, string phone)
        {
            this.Name = Name;
            this.emailAddress = Email;
            this.PhoneNumber = phone;
        }
    }
}