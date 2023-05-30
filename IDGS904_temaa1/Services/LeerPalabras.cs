using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_temaa1.Services
{
    public class LeerPalabras
    {
        public Array LeerArchivo()
        {
            Array datos = null;
            var palabras = HttpContext.Current.Server.MapPath("~/App_Data/traductores.txt");
            if (File.Exists(palabras))
            {
                datos=File.ReadAllLines(palabras);
            }

            return datos;
        }
    }
}