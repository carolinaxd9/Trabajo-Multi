using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proyecto_multi.Models;
using Microsoft.AspNetCore.Http;

namespace proyecto_multi.Controllers
{
    public class CampañaController: Controller
    {
        
        private readonly SostenibilidadContext _context;
        public CampañaController(SostenibilidadContext context)
        {
            this._context = context;

        }
        //listar todas las campañas
        public IActionResult ListaCampana(){
            var Campanas=_context.Campaña.ToList();
           return View(Campanas);
        } 

        //Agregar campañas
        public IActionResult AgregarCampanas(){
            return View();
        } 

        [HttpPost]
        public IActionResult AgregarCampanas(Campaña b){
           if (ModelState.IsValid)
            {
                _context.Add(b);
                _context.SaveChanges();

                return RedirectToAction("AgregarCampañaConfirmacion");
            }

            return View(b);
        } 

        public IActionResult AgregarCampañaConfirmacion()
        {
            return View();
        }

        //registrarse en las campañas
        public IActionResult RegistroCampana(int id){
            var campaña=_context.Campaña.FirstOrDefault(c=>c.CampañaId==id);
            return View(campaña);
        } 


        public IActionResult RegistroCampañaConfirmacion()
        {
            return View();
        }

        //Usuario
        public IActionResult RegistroUsuario(){
            return View();
        }

        [HttpPost]
        public IActionResult RegistroUsuario(usuario u){
            if (ModelState.IsValid)
            {
                _context.Add(u);
                _context.SaveChanges();

                return RedirectToAction("RegistroUsuarioConfirmacion");
            }

            return View(u);
        }
        public IActionResult RegistroUsuarioConfirmacion()
        {
            return View();
        }

        //Iniciar sesion
        public IActionResult InicioSesion(){
            return View();
        }

        [HttpPost]
        public IActionResult InicioSesion(IniciarSesion i){
            if (ModelState.IsValid)
            {
                var con=_context.usuario.FirstOrDefault(c=>c.Email==i.Correo);
                
                if(i.Correo==con.Email && i.Password == con.Contraseña)
                {
                    //codigo
                    HttpContext.Session.SetInt32("uid",con.UsuarioId);//
                    return RedirectToAction("Inicio","Home");
                }
                ModelState.AddModelError("credencialInvalida", "los datos son incorrectos");    
            }
            
            return View(i);
        }
        [HttpPost]
        public IActionResult RegistroCampana(int cid,int monto){
            var cu=new camp_usuario();
            cu.CampañaId=cid;
            cu.UsuarioId=HttpContext.Session.GetInt32("uid").Value;//
            cu.montoDonacion=monto;
            _context.Add(cu);
            _context.SaveChanges();

            return RedirectToAction("RegistroCampañaConfirmacion");
        } 
    }
}