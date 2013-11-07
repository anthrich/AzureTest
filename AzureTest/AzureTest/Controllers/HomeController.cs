using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["FreeDB20"].ConnectionString);
            var cmd = new SqlCommand("select all from dbo.Department", sql);

            ViewBag.Message = "Modify! this template to jump-start your ASP.NET MVC application! THIS IS CHANGED NOW";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
