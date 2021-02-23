using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        // GET: Button
        static List<ButtonModel> buttonmodel = new List<ButtonModel>();

        public ActionResult Index()
        {

            ButtonModel button1 = new ButtonModel(false);
            ButtonModel button2 = new ButtonModel(true);
            buttonmodel.Add(button1);
            buttonmodel.Add(button2);

            return View("Button", buttonmodel);
        }

        public ActionResult OnButtonClick(string mine)
        {
            if (mine == "1")
            {
                buttonmodel[0].state = !buttonmodel[0].state;
            }

            if (mine == "2")
            {
                buttonmodel[1].state = !buttonmodel[1].state;
            }

            return View("Button", buttonmodel);
        }
    }
}