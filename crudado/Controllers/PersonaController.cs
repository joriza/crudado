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

        public ActionResult Guardar()
        {
            return View();
        }

        public ActionResult Nuevo(PersonaModel modelo) { 
            admin.Guardar (modelo);
            return View("Guardar", modelo);
        }
    }
}