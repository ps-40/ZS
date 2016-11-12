using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ZalandoApiClient.Api;
using ZalandoApiClient.Model;
using ZalandoSukienki.Models;

namespace ZalandoSukienki.Controllers
{
    public class ZalandoController : Controller
    {

        private RootModel rootModel = RootModel.Instance;
        
        public ActionResult Index()
        {
            return View(rootModel);
        }

        public ActionResult Dresses(string categoryKey)
        {
            rootModel.SelectCategory(categoryKey);
            return View("Index", rootModel);
        }
    }
}