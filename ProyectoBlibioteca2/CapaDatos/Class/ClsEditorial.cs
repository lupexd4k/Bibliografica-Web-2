using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
    public class ClsEditorial
    {
        public string NombreEditorial;

        public ClsEditorial()
        {
            this.NombreEditorial = "";
        }

        public ClsEditorial(string aEditorial)
        {
            this.NombreEditorial = aEditorial;
        }
    }
}
