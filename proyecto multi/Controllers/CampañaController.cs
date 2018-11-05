using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proyecto_multi.Models;

namespace proyecto_multi.Controllers
{
    public class CampañaController: Controller
    {
        
        private readonly SostenibilidadContext _context;
        public CampañaController(SostenibilidadContext context)
        {
            this._context = context;

        }

        public IActionResult ListaCampana(){
           return View();
        } 

        public IActionResult AgregarCampanas(){
           return View();
        } 

        public IActionResult RegistroCampana(){
           return View();
        } 
    }
}