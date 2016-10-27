using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ZalandoSukienki.ZalandoClient;

namespace ZalandoSukienki.Controllers
{
    public class ZalandoController : Controller
    {
        // GET: TheBest
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dresses(string categoryName)
        {
            ZalandoApiClient zalandoApiClient = new ZalandoApiClient();
            string test = Task.Run(() => zalandoApiClient.GetApiHome()).Result;
            ViewBag.CategoryName = categoryName;
            return View();
        }
    }
}