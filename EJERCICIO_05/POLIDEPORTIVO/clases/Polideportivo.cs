using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIDEPORTIVO.clases
{
    public class Polideportivo
    {
		private List<Cancha> canchas = new List<Cancha>();
		public List<Cancha> Canchas
		{
			get { return canchas; }
			set { canchas = value; }
		}

		private List<Juez> jueces = new List<Juez>();
		public List <Juez> Jueces
		{
			get { return jueces; }
			set { jueces = value; }
		}

		private List<Alquiler> alquileres = new List<Alquiler>();
		public List<Alquiler> Alquileres
		{
			get { return alquileres; }
			set { alquileres = value; }
		}

		public Polideportivo()
		{
			canchas = new List<Cancha>
			{
				new Cancha(TipoCancha.Tenis),
				new Cancha(TipoCancha.FutbolCinco),
				new Cancha(TipoCancha.FutbolSiete),
				new Cancha(TipoCancha.FutbolOnce),
			};

			jueces = new List<Juez>
			{
				new Juez("Lucas", "Rodriguez", 1),
				new Juez("German", "Beder", 2),
				new Juez("Alfred", "Montesdeoca", 3),
			};
		}

		public float CalcularRecaudacion()
		{
			float recaudacion = 0f;

			alquileres.ForEach(alquiler => recaudacion += alquiler.Total);
            jueces.ForEach(juez => recaudacion -= juez.Remuneracion);

			return recaudacion;
		}

		public Cancha CanchaMasAlquilada()
		{
			List<Cancha> listaCanchas = new List<Cancha>();
			canchas.ForEach(cancha => listaCanchas.Add(cancha));
			return listaCanchas.OrderByDescending(cancha => cancha.VecesAlquilada).First();
		}

		public Cancha CanchaMasRecaudacion()
		{
            List<Cancha> listaCanchas = new List<Cancha>();
            canchas.ForEach(cancha => listaCanchas.Add(cancha));
			return listaCanchas.OrderByDescending(cancha => cancha.Recaudacion).First();
        }

		public Juez JuezMasPartidos()
		{
			List<Juez> listaJueces = new List<Juez>();
			jueces.ForEach(juez => listaJueces.Add(juez));
			return listaJueces.OrderByDescending(juez => juez.PartidosDirigidos).First();
		}

		public Juez JuezMasRemunerado()
		{
            List<Juez> listaJueces = new List<Juez>();
            jueces.ForEach(juez => listaJueces.Add(juez));
            return listaJueces.OrderByDescending(juez => juez.Remuneracion).First();
        }

		// Buscar alquileres por fecha
		private List<Alquiler> BuscarAlquileres(DateTime fecha, List<Alquiler> lista)
		{
			List<Alquiler> listaAlquileres = lista.FindAll(alquiler => alquiler.Fecha.Date == fecha.Date);
			return listaAlquileres;
		}

		// Buscar alquileres por juez
		private List<Alquiler> BuscarAlquileres(Juez juez, List<Alquiler> lista)
		{
			List<Alquiler> listaAlquileres = new List<Alquiler>();

			lista.ForEach(alquiler =>
			{
				if (alquiler is AlquilerConOpcional)
				{
					AlquilerConOpcional conOpcional = (AlquilerConOpcional)alquiler;
					if (conOpcional.PrimerJuez.Legajo == juez.Legajo) listaAlquileres.Add(alquiler);
                } else if (alquiler is AlquilerConOpcionales)
				{
					AlquilerConOpcionales conOpcionales = (AlquilerConOpcionales)alquiler;
                    if (conOpcionales.PrimerJuez.Legajo == juez.Legajo
					|| conOpcionales.PrimerJuezLinea.Legajo == juez.Legajo
					|| conOpcionales.SegundoJuezLinea.Legajo == juez.Legajo) listaAlquileres.Add(alquiler);
                }
			});

            return listaAlquileres;
        }

		// Buscar alquileres por cancha
        private List<Alquiler> BuscarAlquileres(Cancha cancha, List<Alquiler> lista)
		{
            List<Alquiler> listaAlquileres = new List<Alquiler>();

            lista.ForEach(alquiler =>
            {
                if (alquiler.Cancha.Tipo == cancha.Tipo) listaAlquileres.Add(alquiler);
            });

            return listaAlquileres;
        }

		public List<Alquiler> BuscarAlquileres(Cancha cancha, DateTime fecha)
		{
			List<Alquiler> aPorFecha = alquileres.FindAll(alquiler => alquiler.Fecha == fecha && alquiler.Cancha.Tipo == cancha.Tipo);
			return aPorFecha;
		}

		// Disponibilidad de juez
        public bool ComprobarDisponibilidad(Juez juez, DateTime fecha, int horaInicio, int horaFin)
		{
			bool disponible = true;

			List<Alquiler> listaAlquileres = BuscarAlquileres(fecha, alquileres);

			if (listaAlquileres.Count > 0)
			{
                List<Alquiler> listaAlquileresMismoJuez = BuscarAlquileres(juez, listaAlquileres);
				if (listaAlquileresMismoJuez.Count > 0)
				{
					listaAlquileresMismoJuez.ForEach(alquiler =>
					{
						if ((horaInicio < alquiler.HoraInicio && horaFin > alquiler.HoraFin) ||
                            (horaInicio < alquiler.HoraFin && horaFin > alquiler.HoraFin) ||
							(horaInicio > alquiler.HoraInicio && horaFin < alquiler.HoraFin) ||
							(horaInicio < alquiler.HoraInicio && horaFin > alquiler.HoraFin))
                        {
							disponible = false;
						}
					});
				}
            }

			return disponible;
		}
	
		// Disponibilidad de cancha
		public bool ComprobarDisponibilidad(Cancha cancha, DateTime fecha, int horaInicio, int horaFin)
		{
			bool disponible = true;

            List<Alquiler> listaAlquileres = BuscarAlquileres(fecha, alquileres);

            if (listaAlquileres.Count > 0)
            {
                List<Alquiler> listaAlquileresMismaCancha = BuscarAlquileres(cancha, listaAlquileres);
                if (listaAlquileresMismaCancha.Count > 0)
                {
                    listaAlquileresMismaCancha.ForEach(alquiler =>
                    {
                        if ((horaInicio < alquiler.HoraInicio && horaFin > alquiler.HoraFin) ||
                            (horaInicio < alquiler.HoraFin && horaFin > alquiler.HoraFin) ||
                            (horaInicio > alquiler.HoraInicio && horaFin < alquiler.HoraFin) ||
                            (horaInicio < alquiler.HoraInicio && horaFin > alquiler.HoraFin))
                        {
                            disponible = false;
                        }
                    });
                }
            }

            return disponible;
		}

		public Alquiler NuevoAlquiler(Cancha cancha, DateTime fecha, int horaInicio, int horaFin)
		{
			Alquiler nuevoAlquiler = null;

			if (ComprobarDisponibilidad(cancha, fecha, horaInicio, horaFin))
			{
                nuevoAlquiler = new Alquiler(fecha, horaInicio, horaFin, cancha);
                alquileres.Add(nuevoAlquiler);
            }

			return nuevoAlquiler;
		}

		public Alquiler NuevoAlquiler(Cancha cancha, DateTime fecha, int horaInicio, int horaFin, List<Juez> jueces)
		{
			Alquiler nuevoAlquiler = null;
			if (ComprobarDisponibilidad(cancha, fecha, horaInicio, horaFin))
			{
                if (jueces.Count == 1)
                {
					if (ComprobarDisponibilidad(jueces[0], fecha, horaInicio, horaFin))
					{
						nuevoAlquiler = new AlquilerConOpcional(fecha, horaInicio, horaFin, cancha, jueces[0]);
						alquileres.Add(nuevoAlquiler);
					}
                }
                else
                {
					if (ComprobarDisponibilidad(jueces[0], fecha, horaInicio, horaFin)
						&& ComprobarDisponibilidad(jueces[1], fecha, horaInicio, horaFin)
						&& ComprobarDisponibilidad(jueces[2], fecha, horaInicio, horaFin))
					{
                        nuevoAlquiler = new AlquilerConOpcionales(fecha, horaInicio, horaFin, cancha, jueces[0], jueces[1], jueces[2]);
                        alquileres.Add(nuevoAlquiler);
                    }
                }				
            }

            return nuevoAlquiler;
        }

		public void RegistrarJuez(Juez juez)
		{
			juez.Legajo = jueces.Count + 1;
			jueces.Add(juez);
		}


	}
}
