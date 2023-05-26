using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class NuevaVistaController : Controller
    {
        public ActionResult NuevaVista()
        {
            return View();
        }

        public ActionResult OperasBas(string n1, string n2,string op)
        {

        //if (op="suma")
        //{
        //    int res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
        //    ViewBag.Res = Convert.ToString(res);
        //    return View();
        //}else if (op1==2)
        //{
        //    int res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
        //    ViewBag.Res = Convert.ToString(res);
        //    return View();

        //}
        //else if (op1==3) 
        //{
        //    int res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
        //    ViewBag.Res = Convert.ToString(res);
        //    return View();
        //}else if (op1==4)
        //{
        //   int res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
        //    ViewBag.Res = Convert.ToString(res);
        //    return View();
        //}
        return View();

    }

        public ActionResult OperasBas2(Calculos op)
        {
            var model = new Calculos();
            model.Res = op.Num1 + op.Num2;
            ViewBag.Res = model.Res;
            return View(model);


        }

        public ActionResult DistanciaPorDosPuntos (DistanciaPorDosPuntos op)
        {
            var model = new DistanciaPorDosPuntos();
            model.Res = model.Operacion(op.X2, op.X1, op.Y1, op.Y2);
            ViewBag.Res = model.Res;
            return View(model);
        }

        public ActionResult MuestraPulques()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();

            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();

            return View(model);
        }


    }
}