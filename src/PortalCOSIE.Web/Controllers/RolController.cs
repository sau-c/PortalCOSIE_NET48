using PortalCOSIE.Application;
using PortalCOSIE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalCOSIE.Web.Controllers
{
    public class RolController : Controller
    {
        private readonly RolService _rolService;

        public RolController(RolService rolService)
        {
            _rolService = rolService;
        }

        public ActionResult Index()
        {
            var roles = _rolService.GetAllRoles();
            return View(roles);
        }

        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(Rol rol)
        {
            if (ModelState.IsValid)
            {
                _rolService.CreateRol(rol);
                return RedirectToAction("Index");
            }
            return View(rol);
        }
    }
}