using Montres.DAO;
using Montres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Montres.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
        public JsonResult Permisos(string user, string contra)
        {

            LoginDAO dao = new LoginDAO();

            int hola= dao.consultamenu(new Usuario(user, contra));
           

            return Json(hola, JsonRequestBehavior.AllowGet);
        }
    }
}