using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc.Routing.Constraints;

namespace IDGS902_Tema1.Models
{
    public class Triangulos
    {
        public float X1 { get; set; }
        public float Y1 { get; set; }
        public float X2 { get; set; }
        public float Y2 { get; set; }
        public float X3 { get; set; }
        public float Y3 { get; set; }
        public string TipoTriangulo { get; set; }
        public float Area { get; set; }
    }

    //public float DistanciaPuntoUnoDos(int X1, int X2, int Y1, int Y2)
    //{
    //    Res12 = (float)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    //    return Res12;
    //}

    //public float DistanciaPuntoDosTres(int X3, int X2, int Y3, int Y2)
    //{
    //    Res23 = (float)Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
    //    return Res23;
    //}

    //public float DistanciaPuntoTresUno(int X1, int X3, int Y1, int Y3)
    //{
    //    Res31 = (float)Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));
    //    return Res31;
    //}


}


