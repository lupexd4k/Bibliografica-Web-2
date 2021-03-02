using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Class
{
    public class ClsCongreso
    {
        public string Nombre;
        public int Edicion;
        public string Ciudad;
        public DateTime FecInicio;
        public DateTime FecFinal;
        public string TipoCongreso;
        public string Frecuecia;
        public string Pais;
        public int PrimerAnio;

        ClsCongreso()
        {
            this.Nombre = "";
            this.Edicion = 0;
            this.Ciudad = "";
            this.TipoCongreso = "";
            this.Frecuecia = "";
            this.Pais = "";
            this.PrimerAnio = 0;
        }

        ClsCongreso(string aNombre, int aEdicion, string aCiudad, DateTime aFecInicio, DateTime aFecFinal
            , string aTipoCongreso, string aFrecuencia, string aPais, int aPrimerAnio)
        {
            this.Nombre = aNombre;
            this.Edicion = aEdicion;
            this.Ciudad = aCiudad;
            this.FecInicio = aFecInicio;
            this.FecFinal = aFecFinal;
            this.TipoCongreso = aTipoCongreso;
            this.Frecuecia = aFrecuencia;
            this.Pais = aPais;
            this.PrimerAnio = aPrimerAnio;
        }
    }
}
