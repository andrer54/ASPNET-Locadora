using Locadora.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace Locadora.Controllers
{
    public class UsuarioController : Controller
    {

        public ActionResult Cadastrar()
        {
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult Cadastrar(Usuario model)
        {
            if (ModelState.IsValid)
            {
                Session[$"user.{ model.Email}"] = model;

                return RedirectToAction("Index", "Catalogo");
            }
            return View(new Usuario());
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            if (HttpContext.Request.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
                HttpContext.Response.End();
            }

            if (Request.IsAjaxRequest())
                return PartialView();
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            //var usuario = Session[$"user.{ model.Email}"] as Usuario;




            if (model.Email == "usuario@usuario.com" && model.Senha == "12345")
            {
                FormsAuthentication.SetAuthCookie(model.Email, true);


                return RedirectToAction("Index", "Catalogo");
            }


            return PartialView();
        }



    }
}