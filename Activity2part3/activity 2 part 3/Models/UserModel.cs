using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace loginapp.Models
{
    public class UserModel
    {
        [Required]
        [DisplayName("User Name")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]



        public String Username { get; set; }


        [Required]
        [DisplayName("Password")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]

        public String Password { get; set; }




    }
}
