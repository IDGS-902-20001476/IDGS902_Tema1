using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Models
{
    public class DistanciaPorDosPuntos
    {
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public float Res { get; set; }

        public float Operacion(int X1, int X2, int Y1, int Y2)
        {

            Res = (float)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            return Res;
        }

    }
}