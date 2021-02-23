using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            List<UserModel> usermodel = new List<UserModel>();


            UserModel user1 = new UserModel("vrijesh ","vrijesh@gmail.com","222-222-2222");

            usermodel.Add(user1);
            return View("Test",usermodel);
        }
    }
}