using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Simulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvSimulaciones.Rows.Clear();
            lblProbabilidad.Text = "Probabilidad de vender suscripciones:  ";
            lblCantidadSusc.Text = "Cantidad de suscripciones a vender en 10000 visitas:  ";
            Simular();
        }

        private Visita CrearVisita()
        {
            var probAtencion = 0.7;
            var probAtencionMujer = 0.8;
            var probVentaMujer = 0.15;
            var probVentaHombre = 0.3;

            var prob1VentaMujer = 0.6;
            var prob2VentaMujer = 0.25;
            var prob3VentaMujer = 0.1;
            var prob4VentaMujer = 0.05;

            var prob1VentaMujerAcum = prob1VentaMujer;
            var prob2VentaMujerAcum = prob1VentaMujerAcum + prob2VentaMujer;
            var prob3VentaMujerAcum = prob2VentaMujerAcum + prob3VentaMujer;
            var prob4VentaMujerAcum = prob3VentaMujerAcum + prob4VentaMujer;

            var prob1VentaHombre = 0.2;
            var prob2VentaHombre = 0.3;
            var prob3VentaHombre = 0.35;
            var prob4VentaHombre = 0.15;

            var prob1VentaHombreAcum = prob1VentaHombre;
            var prob2VentaHombreAcum = prob1VentaHombreAcum + prob2VentaHombre;
            var prob3VentaHombreAcum = prob2VentaHombreAcum + prob3VentaHombre;
            var prob4VentaHombreAcum = prob3VentaHombreAcum + prob4VentaHombre;

            var dictionarySuscripcionesMujer = new Dictionary<double, int>();
            dictionarySuscripcionesMujer.Add(prob1VentaMujerAcum, 1);
            dictionarySuscripcionesMujer.Add(prob2VentaMujerAcum, 2);
            dictionarySuscripcionesMujer.Add(prob3VentaMujerAcum, 3);
            dictionarySuscripcionesMujer.Add(prob4VentaMujerAcum, 4);

            var dictionarySuscripcionesHombre = new Dictionary<double, int>();
            dictionarySuscripcionesHombre.Add(prob1VentaHombreAcum, 1);
            dictionarySuscripcionesHombre.Add(prob2VentaHombreAcum, 2);
            dictionarySuscripcionesHombre.Add(prob3VentaHombreAcum, 3);
            dictionarySuscripcionesHombre.Add(prob4VentaHombreAcum, 4);

            var utilidadVendedor = 5;
            var costoVendedor = 0.5;

            //todo en minutos
            var tiempoAtencionNoAtienden = 2;
            var tiempoAtencionNoVendeMin = 15;
            var tiempoAtencionNoVendeMax = 25;
            var tiempoAtencionVendeMin = 15;
            var tiempoAtencionVendeMax = 20;
            var extraTiempoPorSuscripcion = 4;

            var visita = new Visita(); // ver que mandar de reloj aca

            visita.SuscripcionesMujer = dictionarySuscripcionesMujer;
            visita.SuscripcionesHombre = dictionarySuscripcionesHombre;
            visita.Utilidad = utilidadVendedor;
            visita.Gasto = costoVendedor;
            visita.ProbabilidadAtencion = probAtencion;
            visita.ProbabilidadVentaMujer = probVentaMujer;
            visita.ProbabilidadVentaHombre = probVentaHombre;
            visita.ProbabilidadGeneroMujer = probAtencionMujer;
            visita.TiempoNoAtencion = tiempoAtencionNoAtienden;
            visita.TiempoNoVentaMin = tiempoAtencionNoVendeMin;
            visita.TiempoNoVentaMax = tiempoAtencionNoVendeMax;
            visita.TiempoVentaMin = tiempoAtencionVendeMin;
            visita.TiempoVentaMax = tiempoAtencionVendeMax;
            visita.TiempoExtraPorSuscripcion = extraTiempoPorSuscripcion;

            return visita;
        }

        public void Simular()
        {
            var visita = CrearVisita();
            double finSimulacion = 480 * 60; // 480 hs (20 dias) * 60 minutos para trabajar en minutos
            int fila = 1, cantidadVentas = 0, cantidadSuscripciones = 0;
            double acumulacionGanancias = 0, acumulacionGastos = 0, reloj = 0;

            while(reloj < finSimulacion)
            {
                visita.Visitar(reloj);
                acumulacionGastos += visita.Gasto;

                if (visita.HuboVenta)
                {
                    acumulacionGanancias += visita.Ganancia;
                    cantidadVentas++;
                    cantidadSuscripciones += visita.CantidadVenta;
                }

                LlenarFilaGrilla(visita, fila, reloj, acumulacionGanancias, acumulacionGastos, cantidadVentas, cantidadSuscripciones);
                reloj = visita.FinAtencion;
                fila++;
            }

            var probabilidadVenta = Math.Round((double)cantidadVentas / fila, 2);
            var suscripcionesAEsperar = Math.Round(((double)cantidadSuscripciones / fila) * 10000, 0);
            lblProbabilidad.Text += probabilidadVenta;
            lblCantidadSusc.Text += suscripcionesAEsperar;

            // como sacaba estos valores? JUSTIFICAR
        }

        private void LlenarFilaGrilla(Visita visita, int fila, double reloj, double acumulacionGanancias, double acumulacionGastos, int cantidadVentas, int cantidadSuscripciones)
        {
            if (visita.EsAtendido)
            {
                var ganancia = visita.HuboVenta ? visita.Ganancia : 0;
                dgvSimulaciones.Rows.Add(fila, reloj, visita.RandomAtencion, "SI" , visita.RandomGenero, visita.EsMujer ? "MUJER" : "HOMBRE", visita.RandomTiempoAtencion, visita.TiempoAtencion, visita.FinAtencion, visita.RandomVenta, visita.HuboVenta ? "SI" : "NO", visita.RandomCantidadVenta, visita.CantidadVenta, ganancia, acumulacionGanancias, visita.Gasto, acumulacionGastos, fila, cantidadVentas, cantidadSuscripciones);
            }
            else
            {
                dgvSimulaciones.Rows.Add(fila, reloj, visita.RandomAtencion, "NO", visita.RandomGenero, "-", visita.RandomTiempoAtencion, "2", visita.FinAtencion, visita.RandomVenta, "NO", visita.RandomCantidadVenta, visita.CantidadVenta, "0", acumulacionGanancias, visita.Gasto, acumulacionGastos, fila, cantidadVentas, cantidadSuscripciones);
            }
        }
    }
}
