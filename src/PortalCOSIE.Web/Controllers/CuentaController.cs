using PortalCOSIE.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PortalCOSIE.Web.Controllers
{
    public class CuentaController : Controller
    {
        [HttpGet]
        public ActionResult Registrar()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Registrar()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult Ingresar()
        {
            return View(new IngresarViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ingresar(IngresarViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Aquí haces la validación contra base de datos o servicio de autenticación
            //var usuario = db.Accesos.FirstOrDefault(a =>
            //    a.UserName == model.UserName && a.Contrasena == model.Contrasena);

            //if (usuario == null)
            //{
            //    model.MensajeError = "Usuario o contraseña incorrectos.";
            //    return View(model);
            //}

            // Aquí puedes usar FormsAuthentication, Claims, o lo que manejes
            FormsAuthentication.SetAuthCookie(model.UserName, false);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}