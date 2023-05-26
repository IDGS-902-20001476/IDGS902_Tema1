using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class EsTriangulo
    {
        public bool Triangulo(Triangulos triangulo)
        {
            float punto12 = CalcularDistancia(triangulo.X1, triangulo.Y1, triangulo.X2, triangulo.Y2);
            float punto13 = CalcularDistancia(triangulo.X1, triangulo.Y1, triangulo.X3, triangulo.Y3);
            float punto23 = CalcularDistancia(triangulo.X2, triangulo.Y2, triangulo.X3, triangulo.Y3);

            if (punto12 < punto13 + punto23 && punto13 < punto12 + punto23 && punto23
                < punto12 + punto13)
                return true;
            return false;
        }

    
        public void CalcularTipoDeTriangulo(Triangulos triangulo)
        {
            // Calcula las distancias entre los puntos del triángulo
            float punto12 = CalcularDistancia(triangulo.X1, triangulo.Y1, triangulo.X2, triangulo.Y2);
            float punto13 = CalcularDistancia(triangulo.X1, triangulo.Y1, triangulo.X3, triangulo.Y3);
            float punto23 = CalcularDistancia(triangulo.X2, triangulo.Y2, triangulo.X3, triangulo.Y3);


           
            if (punto12 != punto13 &&  punto12 != punto23 && punto23 != punto13 )
            {
                triangulo.TipoTriangulo = "Es un triangulo Escaleno";
            }
            else if (Convert.ToInt16(punto12) == Convert.ToInt16(punto23) && Convert.ToInt16(punto23) == Convert.ToInt16(punto13))
            {
                triangulo.TipoTriangulo = "Es un triangulo Equilatero";
            }
            else if (punto12 == punto13 && punto12 != punto23 || punto23 == punto12 && punto23 != punto13
                || punto13 == punto23 && punto13 != punto12)
                {
                    triangulo.TipoTriangulo = "Es un triangulo Isósceles";
                }
            
            
        }

        public double AreaTriangulo(Triangulos triangulo)
        {
            float distanciaAB = CalcularDistancia(triangulo.X1, triangulo.Y1, triangulo.X2, triangulo.Y2);
            float distanciaBC = CalcularDistancia(triangulo.X2, triangulo.Y2, triangulo.X3, triangulo.Y3);
            float distanciaAC = CalcularDistancia(triangulo.X1, triangulo.Y1, triangulo.X3, triangulo.Y3);
            float semiperimetro = (distanciaAB + distanciaBC + distanciaAC) / 2;

            triangulo.Area = (float)Math.Sqrt(semiperimetro * (semiperimetro - distanciaAB) * (semiperimetro - distanciaBC) * (semiperimetro - distanciaAC));

            return triangulo.Area;
        }

        private float CalcularDistancia(float x1, float y1, float x2, float y2)
        {
            return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}