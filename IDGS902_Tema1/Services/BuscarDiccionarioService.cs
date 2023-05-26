using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class BuscarDiccionarioService
    {
        public string BuscarPalabra(Diccionario dc)
        {
            var palabraBuscar = dc.PalabraBuscar.ToLower();
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/Diccionario.txt");
            var Diccionario = File.ReadAllLines(datos);
            var respuesta = "";

            foreach (var linea in Diccionario)
            {
                var palabras = linea.Split(',');
                var spanish = palabras[0].Trim();
                var english = palabras[1].Trim();

                if (dc.Idioma == "inglés" && spanish == palabraBuscar)
                {
                    respuesta = english;
                    break;
                }
                else if (dc.Idioma == "español" && english == palabraBuscar)
                {
                    respuesta = spanish;
                    break;
                }
            }

            if (respuesta == "")
            {
                respuesta = @"<h1>
                No se encontraron resultados
            </h1>";
            }
            else
            {
                respuesta = @"
                <h1>La traducción de la palabra  es: " + respuesta + @"</h1>
            </h1>";
            }

            return respuesta;
        }

    }
}