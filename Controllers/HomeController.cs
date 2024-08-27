using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebContext.Data;

namespace WebContext.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (var context = new AppDataContaxt())
            {
                // ใช้ SQL Query โดยตรง
                string query = "SELECT * FROM PolicyMicroTwoHundred ";
                var data = context.Database.SqlQuery<MyEntity>(query).ToList();

                return View();
            }


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}