using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Models
{
    public class Triangulo
    {

        public double x1 { get; set; }
        public double x2 { get; set; }
        public double y1 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }

        public string CalcularT()
        {
            string result;
            bool tria;
            string tipo="";

            double unoydos = Math.Sqrt(Math.Pow((x2 - x1), 2)+Math.Pow((y2 - y1), 2));
            double dosytres = Math.Sqrt(Math.Pow((x3 - x2), 2)+Math.Pow((y3 - y2), 2));
            double tresyuno = Math.Sqrt(Math.Pow((x3 - x1), 2)+Math.Pow((y3 - y1), 2));

            double area = 0.5 * Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)));

            if (area > 0) {
                result = "Es un triangulo";
                tria=true;
                ;
            }
            else {
                result = "No es un triangulo";
                tria=false;
            }


            if (tria)
            {
                if (unoydos == dosytres && unoydos == tresyuno && tresyuno == dosytres )
                {
                    tipo= "Equilátero";
                }
                else if (unoydos == tresyuno || unoydos == dosytres || tresyuno == dosytres)
                {
                    tipo= "Isósceles";
                }
                else
                {
                    tipo= "Escaleno";
                }
            }
            else {
                area=0;
            }

           



            return result+" y es de tipo "+tipo+" y tiene como area " +area;
        }



    }
}