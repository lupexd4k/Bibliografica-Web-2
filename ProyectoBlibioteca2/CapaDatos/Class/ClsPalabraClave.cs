using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
    public class ClsPalabraClave
    {
        public string Description;

        public ClsPalabraClave()
        {
            this.Description = "";
        }

        public ClsPalabraClave(string aDescription)
        {
            this.Description = aDescription;
        }
    }
}
