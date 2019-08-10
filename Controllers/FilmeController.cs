using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locadora.Controllers
{
    
    public class FilmeController : Controller
    {
        [Authorize]// GET: Filme
        public ActionResult Exibir(string id)
        {
            ViewBag.Titulo = id;
            switch (id)
            {
                case "Mulher Maravilha":
                    ViewBag.Url = "https://www.youtube.com/embed/I6Gj8Fvukk4";
                    break;
                case "Doutor Estranho":
                    ViewBag.Url = "https://www.youtube.com/embed/hKby-I7AXCg";
                    break;
                case "Guardiões da Galaxia":
                    ViewBag.Url = "https://www.youtube.com/embed/8VN_l57QWyQ";
                    break;
            }
            return View();
        }
        public ActionResult Detalhes(string id)
        {
            ViewBag.Titulo = id;
            switch (id)
            {
                case "Mulher Maravilha":
                    ViewBag.Url = "https://www.youtube.com/embed/I6Gj8Fvukk4";
                    
                    break;
                case "Doutor Estranho":
                    ViewBag.Url = "https://www.youtube.com/embed/hKby-I7AXCg";
                    break;
                case "Guardiões da Galaxia":
                    ViewBag.Url = "https://www.youtube.com/embed/8VN_l57QWyQ";
                    break;
            }
            return View();
        }
    }
}