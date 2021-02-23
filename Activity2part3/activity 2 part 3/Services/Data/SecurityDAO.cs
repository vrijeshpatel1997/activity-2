using loginapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace loginapp.Services.Data
{
    public class SecurityDAO

    {





        internal bool FindByUser(UserModel user)
        {

            bool sucess = false;
            if (user.Username == "User" && user.Password == "mypass")
            {
                return true;


            }
            else
            {
                return false;

            }
        }

        }
    
}
    

