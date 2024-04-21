using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACION.Clases
{
    public class Surtidor
    {
        private readonly Nafta nafta;
        public Nafta Nafta
        {
            get { return nafta; }
        }

        private float carga;
        public float Carga
        {
            get { return carga; }
        }

        private int recargas;
        public int Recargas
        {
            get { return recargas; }
        }

        private float recaudacion;
        public float Recaudacion
        {
            get { return recaudacion; }
        }

        public Surtidor(Nafta nafta)
        {
            this.nafta = nafta;
            carga = 100;
            recargas = 0;
        }

        public void Recargar()
        {
            carga = 100f;
            recargas++;
        }

        public int Descargar(float cantidad)
        {
            int resultado;
            if (carga > 0 && carga >= cantidad)
            {
                carga -= cantidad;
                resultado = 0;
            }
            else resultado = -1;
            return resultado;
        }

        public void SetRecaudacion(float total)
        {
            if (total > 0) recaudacion += total;
        }

        public override string ToString()
        {
            return $"{Nafta.Tipo} - ${Nafta.Precio}";
        }

    }
}
