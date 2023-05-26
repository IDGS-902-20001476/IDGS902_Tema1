using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Triangulos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Triangulos(Triangulos triangulo)
        {
            var trianguloServices = new EsTriangulo();

            if (trianguloServices.Triangulo(triangulo))
            {
                trianguloServices.CalcularTipoDeTriangulo(triangulo);
                trianguloServices.AreaTriangulo(triangulo);
            }
            else
            {
                triangulo.TipoTriangulo = "Las coordenadas ingresadas no forman un triángulo";
                triangulo.Area = 0;
            }

            return View(triangulo);
        }
    }
}