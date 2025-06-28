using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PortalCOSIE.Application.Interfaces;
using PortalCOSIE.Domain.Entities;

namespace PortalCOSIE.Web.Controllers
{
    public class PermisoController : Controller
    {
        private readonly IPermisoService _permisoService;
        public PermisoController(IPermisoService permisoService)
        {
            _permisoService = permisoService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var permisos = _permisoService.ListarTodos();
            return View(permisos);
        }

        [HttpGet]
        public ActionResult Crear() => View();

        [HttpPost]
        public ActionResult Crear(Permiso permiso)
        {
            if (ModelState.IsValid)
            {
                _permisoService.Crear(permiso);
                return RedirectToAction("Index");
            }
            return View(permiso);
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permiso permiso = _permisoService.ObtenerPorId((int)id);
            if (permiso == null)
            {
                return HttpNotFound();
            }
            return View(permiso);
        }
        
        // POST: Permiso/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "Id,Nombre,Descripcion,Creado,CreadoPor,Actualizado,ActualizadoPor")] Permiso permiso)
        {
            if (ModelState.IsValid)
            {
                _permisoService.Actualizar(permiso);
                return RedirectToAction("Index");
            }
            return View(permiso);
        }

        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permiso permiso = _permisoService.ObtenerPorId((int)id);
            if (permiso == null)
            {
                return HttpNotFound();
            }
            return View(permiso);
        }

        // POST: Permiso/Delete/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _permisoService.Eliminar(id);
            return RedirectToAction("Index");
        }
        public ActionResult Detalles(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permiso permiso = _permisoService.ObtenerPorId((int)id);
            if (permiso == null)
            {
                return HttpNotFound();
            }
            return View(permiso);
        }
    }
}
