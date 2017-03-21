using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home/index
        public ActionResult Index()
        {

            /* Option:1 */
            //ViewBag.Countries = new List<string>()
            //{
            //    "USA",
            //    "India",
            //    "UK",
            //    "Canada"
            //};

            /* Option:2 */
            ViewData["Countries"] = new List<string>()
            {
                "USA",
                "India",
                "UK",
                "Canada"
            };

            return View();
        }
    }
}