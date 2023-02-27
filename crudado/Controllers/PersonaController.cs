using crudado.Datos;
using crudado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudado.Controllers
{
    public class PersonaController : Controller
    {
        PersonaAdmin admin = new PersonaAdmin();
        // GET: Persona
        public ActionResult Index()
        {
            IEnumerable<PersonaModel> lista = admin.Consultar();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(PersonaModel M)
        {
            admin.Guardar(M);
            //IEnumerable<PersonaModel> lista = admin.Consultar();
            //return View("Index",lista);
            return RedirectToAction("Index");
        }


        //public ActionResult Nuevo(PersonaModel m) { 
        //    admin.Guardar (m);
        //    return View("Guardar", m);
        //}
    }
}