
using System;

using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class AsignaturaController : Controller
    {
        /* public IActionResult Index()
        {
            return View(_context.Asignaturas.FirstOrDefault());
        }*/

        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asignatura = from asig in _context.Asignaturas where asig.Id == asignaturaId select asig;
                return View(asignatura.SingleOrDefault());
            }
            else
            {
                return View("MultiAsignatura", _context.Asignaturas);
            }

        }

        public IActionResult MultiAsignatura()
        {
            /* var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas", Id= Guid.NewGuid().ToString()} ,
                            new Asignatura{Nombre="Educación Física", Id= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Castellano", Id= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Ciencias Naturales", Id= Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Programacion", Id= Guid.NewGuid().ToString()}};*/

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            //return View("MultiAsignatura",listaAsignaturas);
            return View("MultiAsignatura", _context.Asignaturas);
        }

        private EscuelaContext _context;

        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}