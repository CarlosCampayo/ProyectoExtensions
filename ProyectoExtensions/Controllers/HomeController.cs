using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoExtensions.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using ProyectoExtensions.Extensions;


namespace ProyectoExtensions.Controllers
{
    public class HomeController : Controller
    {  
        public IActionResult Index()
        {
            Persona persona=null;
            if (TempData["persona"] != null)
            {
                persona = TempData.GetObjectXML<Persona>("persona");
            }
            return View(persona);
        }
        public IActionResult Persona()
        {
            Persona persona = new Persona();
            persona.Nombre = "Carlos";
            persona.Apellidos = "Campayo";
            persona.Fecha = DateTime.Today;
            persona.Telefono = 789;
            TempData.SetObjectXML<Persona>("persona",persona);
            return RedirectToAction("Index");
        }
    }
}
