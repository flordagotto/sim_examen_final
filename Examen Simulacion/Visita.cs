using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Simulacion
{
    public class Visita
    {
        public Random Random { get; set; }
        public double ProbabilidadAtencion { get; set; }
        public double RandomAtencion { get; private set; }
        public bool EsAtendido { get; private set; }
        public double ProbabilidadGeneroMujer { get; set; }
        public double RandomGenero { get; private set; }
        public bool EsMujer { get; private set; }
        public double RandomTiempoAtencion { get; private set; }
        public double FinAtencion { get; private set; }
        public double RandomVenta { get; private set; }
        public bool HuboVenta { get; private set; }
        public double RandomCantidadVenta { get; private set; }
        public int CantidadVenta { get; private set; }
        public double Ganancia { get; private set; }
        public double Gasto { get; set; }
        public double Utilidad { get; set; }
        public double TiempoAtencion { get; private set; }
        public int CantidadPuertasTocadas { get; private set; }
        public double ProbabilidadVentaMujer { get; set; }
        public double ProbabilidadVentaHombre { get; set; }
        public double TiempoNoAtencion { get; set; }
        public double TiempoNoVentaMin { get; set; }
        public double TiempoNoVentaMax { get; set; }
        public double TiempoVentaMin { get; set; }
        public double TiempoVentaMax { get; set; }
        public double TiempoExtraPorSuscripcion { get; set; }
        public Dictionary<double, int> SuscripcionesMujer { get; set; }
        public Dictionary<double, int> SuscripcionesHombre { get; set; }

        public Visita()
        {
            Random = new Random();
            SuscripcionesHombre = new Dictionary<double, int>();
            SuscripcionesMujer = new Dictionary<double, int>();
        }

        public void Visitar(double reloj)
        {
            RandomAtencion = Math.Round(Random.NextDouble(), 2);
            if (RandomAtencion > ProbabilidadAtencion)
            {
                EsAtendido = false;
                HuboVenta = false;
                FinAtencion = reloj + TiempoNoAtencion;
            }
            else
            {
                EsAtendido = true;
                RandomGenero = Math.Round(Random.NextDouble(), 2);
                Atender(reloj);
            }
        }

        private void Atender(double reloj)
        {
            // 0,8 prob de que sea mujer. si el random es > 0,8, es hombre
            if (RandomGenero > ProbabilidadGeneroMujer)
            {
                EsMujer = false;
                RandomVenta = Math.Round(Random.NextDouble(), 2);

                if (RandomVenta > ProbabilidadVentaHombre)
                {
                    HuboVenta = false;
                    NoVender(reloj);
                }
                else
                {
                    HuboVenta = true;
                    Vender(reloj);
                }
            }
            else
            {
                EsMujer = true;
                RandomVenta = Math.Round(Random.NextDouble(), 2);

                if (RandomVenta > ProbabilidadVentaMujer)
                {
                    HuboVenta = false;
                    NoVender(reloj);
                }
                else
                {
                    HuboVenta = true;
                    Vender(reloj);
                }
            }
        }

        private void NoVender(double reloj)
        {
            RandomTiempoAtencion = Math.Round(Random.NextDouble(), 2);
            TiempoAtencion = CalculoDistribucion.ObtenerVariableAleatoriaUniforme(TiempoNoVentaMin, TiempoNoVentaMax, RandomTiempoAtencion);
            FinAtencion = TiempoAtencion + reloj;
        }

        private void Vender(double reloj)
        {
            RandomCantidadVenta = Math.Round(Random.NextDouble(), 2);
            CantidadVenta = ObtenerCantidadSuscripciones(RandomCantidadVenta);

            RandomTiempoAtencion = Math.Round(Random.NextDouble(), 2);
            TiempoAtencion = CalculoDistribucion.ObtenerVariableAleatoriaUniforme(TiempoVentaMin, TiempoVentaMax, RandomTiempoAtencion);
            double extraPorSuscripcion = CantidadVenta * TiempoExtraPorSuscripcion;
            TiempoAtencion += extraPorSuscripcion;
            FinAtencion = TiempoAtencion + reloj;
            Ganancia = CantidadVenta * Utilidad;
        }


        private int ObtenerCantidadSuscripciones(double random)
        {
            var diccionarioAUsar = EsMujer ? SuscripcionesMujer : SuscripcionesHombre;

            foreach (var frecuencia in diccionarioAUsar)
            {
                if (random < frecuencia.Key)
                {
                    return frecuencia.Value;
                }
            }
            return 4;
        }
    }
}
