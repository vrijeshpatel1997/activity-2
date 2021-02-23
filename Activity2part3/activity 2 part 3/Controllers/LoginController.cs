using loginapp.Models;
using loginapp.Services.Buiness;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loginapp.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View("Login") ;
        }


        public ActionResult Login(UserModel UserModel)
        {
            //  return "Results : Username = " + UserModel.Username + "password = " + UserModel.Password;

            SecurityService ss = new SecurityService();

            Boolean sucess = ss.Authenticate(UserModel);
            if (sucess)
            {
                return View("LoginSucess", UserModel);
            }
            else
            {
                return View("LoginFail", UserModel);
            }
        }
    }
}
