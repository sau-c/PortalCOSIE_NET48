using PortalCOSIE.Application;
using PortalCOSIE.Application.Interfaces;
using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PortalCOSIE.Web.Controllers
{
    public class RolController : Controller
    {
        private readonly IRolService _rolService;

        public RolController(IRolService rolService)
        {
            _rolService = rolService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var roles = _rolService.ListarTodos();
            return View(roles);
        }

        [HttpGet]
        public ActionResult Crear() => View();

        [HttpPost]
        public ActionResult Crear(Rol rol)
        {
            if (ModelState.IsValid)
            {
                _rolService.Crear(rol);
                return RedirectToAction("Index");
            }
            return View(rol);
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rol rol = _rolService.ObtenerPorId((int)id);
            if (rol == null)
            {
                return HttpNotFound();
            }
            return View(rol);
        }

        [HttpPost]
        public ActionResult Editar(Rol rol)
        {
            if (ModelState.IsValid)
            {
                _rolService.Actualizar(rol);
                return RedirectToAction("Index");
            }
            return View(rol);
        }
    }
}