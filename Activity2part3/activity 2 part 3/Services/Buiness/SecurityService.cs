using loginapp.Models;
using loginapp.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loginapp.Services.Buiness
{
    public class SecurityService
    {

        SecurityDAO daoService = new SecurityDAO();


        public bool Authenticate(UserModel user)
        {
            return daoService.FindByUser(user);

        }

    }
}
