using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Services
{
    public class TraductorGuardarServices
    {
        public void GuardaArchivo(Traductor m)
        {
            var espanol = "";
            var ingles="";
            if (m.Espanol is null)
            {

            }
            else {
                espanol = m.Espanol.ToLower();
                ingles = m.Ingles.ToLower();
                var datos = espanol+","+ingles+Environment.NewLine;
                var archivo = HttpContext.Current.Server.MapPath("~/App_Data/traductores.txt");
                //File.WriteAllText(archivo, datos);
                File.AppendAllText(archivo, datos);
            }   

        }

    }
}