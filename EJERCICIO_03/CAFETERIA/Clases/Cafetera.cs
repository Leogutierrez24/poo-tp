using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
    public class Cafetera
    {
        private int id;
        public int Id
        {
            get { return id; }
        }

        private float capacidad = 1f;
        public float Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        private Cafe cafe;
        public Cafe Cafe
        {
            get { return cafe; }
            set { cafe = value; }
        }

        private float recaudacion = 0;
        public float Recaudacion
        {
            get { return recaudacion; }
        }

        private float cantidadServida = 0;
        public float CantidadServida
        {
            get { return cantidadServida; }
        }

        private int recargas;
        public int Recargas
        {
            get { return recargas; }
        }

        public Cafetera(Cafe cafe, int id)
        {
            this.cafe = cafe;
            this.id = id;
        }

        public int Servir(Vaso vaso)
        {
            int resultado;
            if (capacidad >= vaso.Medida)
            {
                vaso.AgregarCafe(cafe);
                capacidad -= vaso.Medida;
                cantidadServida += vaso.Medida;
                recaudacion += vaso.Medida * vaso.Cafe.Precio;
                vaso.Cafe.Servido();
                vaso.Cafe.Recaudacion += vaso.Medida * vaso.Cafe.Precio;
                resultado = 0;
            }
            else resultado = -1;
            return resultado;
        }

        public int Recargar()
        {
            int resultado = 0;
            if (capacidad < 1f)
            {
                capacidad = 1f;
                recargas++;
            } else resultado = -1;
            return resultado;
        }

        public override string ToString()
        {
            return $"Cafetera {id} con {cafe.Tipo}";
        }
    }
}
