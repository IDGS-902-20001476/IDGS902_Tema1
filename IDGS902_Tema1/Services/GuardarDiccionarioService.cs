using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class GuardarDiccionarioService
    {
        public void AgregarDiccionario(Diccionario dc)
        {
            var palabraE = dc.Espanol;
            var palabraI = dc.Ingles;

            var datos = palabraE.ToLower() + "," + palabraI.ToLower() + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Diccionario.txt");
            File.AppendAllText(archivo, datos);
        }

    }
}