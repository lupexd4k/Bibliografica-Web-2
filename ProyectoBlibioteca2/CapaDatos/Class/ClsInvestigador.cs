using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
    public class ClsInvestigador
    {
        public String Nombre;
        public String Correo;

        public ClsInvestigador()
        {
            this.Nombre = "";
            this.Correo = "";
        }

        public ClsInvestigador(string aNombre, string aCorreo)
        {
            this.Nombre = aNombre;
            this.Correo = aCorreo;
        }
    }
}
