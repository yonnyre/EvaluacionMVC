using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EvaluacionMVC.Models;
namespace EvaluacionMVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        evaluacionMVCEntities1 db =new  evaluacionMVCEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Validar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validar(string user, string password)
        {
            usuario us = db.usuario.FirstOrDefault(d => d.acceso == user & d.clave == password);
            if (us != null)
            {
                return RedirectToAction("Index", "productoes");
            }
            else
            {
                return RedirectToAction("NoHallado", "Usuario");
            }
        }
        public ActionResult NoHallado()
        {
            ViewBag.Error = "No se encontro el usuario con esos datos";
            return View();
        }
    }
}