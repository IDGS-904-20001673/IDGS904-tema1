using IDGS904_temaa1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Models
{
    public class Traductor
    {

        public string Espanol {get; set;}
        public string Ingles {get; set;}

        public string tipo { get; set; }
        public string llave { get; set; }


        public string Palabra()
        {
            var tra = new LeerPalabras();
            var palabras = tra.LeerArchivo();
            var respuesta= "";
            if (tipo == "i")
            {
                foreach (string palabra in palabras) {
                    var items = palabra.Split(',');
                    if (llave.ToLower() == items[0])
                    {
                        respuesta = items[1];
                        break;
                    }
                    else
                    {
                        respuesta = "No se pudo traducir esta palabra";
                    }
                }
            }
            else {
                foreach (string palabra in palabras)
                {
                    var items = palabra.Split(',');
                    if (llave.ToLower() == items[1])
                    {
                        respuesta = items[0];
                        break;
                    }
                    else
                    {
                        respuesta = "No se pudo traducir esta palabra";
                    }
                }
            }

          return respuesta;
        }


    }
}