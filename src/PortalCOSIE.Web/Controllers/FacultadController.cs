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
using PortalCOSIE.Infrastructure.Data;

namespace PortalCOSIE.Web.Controllers
{
    public class FacultadController : Controller
    {
        private readonly IFacultadService _facultadService;
        public FacultadController(IFacultadService facultadService)
        {
            _facultadService = facultadService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var facultades = _facultadService.ListarTodos();
            return View(facultades);
        }

        [HttpGet]
        public ActionResult Crear() => View();

        [HttpPost]
        public ActionResult Crear(Facultad facultad)
        {
            if (ModelState.IsValid)
            {
                _facultadService.Crear(facultad);
                return RedirectToAction("Index");
            }
            return View(facultad);
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facultad facultad = _facultadService.ObtenerPorId((int)id);
            if (facultad == null)
            {
                return HttpNotFound();
            }
            return View(facultad);
        }
        
        // POST: Facultad/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "Id,Nombre,Descripcion,Creado,CreadoPor,Actualizado,ActualizadoPor")] Facultad facultad)
        {
            if (ModelState.IsValid)
            {
                _facultadService.Actualizar(facultad);
                return RedirectToAction("Index");
            }
            return View(facultad);
        }

        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facultad facultad = _facultadService.ObtenerPorId((int)id);
            if (facultad == null)
            {
                return HttpNotFound();
            }
            return View(facultad);
        }

        // POST: Facultad/Delete/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _facultadService.Eliminar(id);
            return RedirectToAction("Index");
        }
        public ActionResult Detalles(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facultad facultad = _facultadService.ObtenerPorId((int)id);
            if (facultad == null)
            {
                return HttpNotFound();
            }
            return View(facultad);
        }
    }
}
