
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View(new Alumno{Nombre="Alejandro",
                                UniqueId= Guid.NewGuid().ToString()
                            });
        }

        public IActionResult MultiAlumno()
        {
            var listaAlumnos = new List<Alumno>(){
                            new Alumno{Nombre="Evelyn", UniqueId= Guid.NewGuid().ToString()} ,
                            new Alumno{Nombre="Lourdes", UniqueId= Guid.NewGuid().ToString()},
                            new Alumno{Nombre="Kaylee", UniqueId= Guid.NewGuid().ToString()},
                            new Alumno{Nombre="Christopher", UniqueId= Guid.NewGuid().ToString()},
                            new Alumno{Nombre="Scrofy", UniqueId= Guid.NewGuid().ToString()}};

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno",listaAlumnos);
        }
    }
}