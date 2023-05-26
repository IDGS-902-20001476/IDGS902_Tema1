using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class LeerDiccionarioService
    {
        public Array LeerArchivo()
        {
            Array contDic = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/Diccionario.txt");
            if (File.Exists(datos))
            {
                contDic = File.ReadAllLines(datos);
            }
            return contDic;
        }
    }
}