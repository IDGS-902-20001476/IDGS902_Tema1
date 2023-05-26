using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class DiccionarioController : Controller
    {
        public ActionResult GuardarDiccionario()
        {
            return View();
        }
        // POST: Diccionario
        [HttpPost]
        public ActionResult GuardarDiccionario(Diccionario dic)
        {
            var ope1 = new GuardarDiccionarioService();

            ope1.AgregarDiccionario(dic);
            return View(dic);
        }

        [HttpGet]
        public ActionResult BuscarDiccionario()
        {
            var leer = new LeerDiccionarioService();
            ViewBag.ContDicc = leer.LeerArchivo();
            return View();
        }


        [HttpPost]
        public ActionResult BuscarDiccionario(Diccionario dic)
        {
            var leer = new LeerDiccionarioService();
            ViewBag.ContDicc = leer.LeerArchivo();
            var buscar = new BuscarDiccionarioService();
            ViewBag.Traduccion = buscar.BuscarPalabra(dic);

            return View();
        }

    }
}
