using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Simulacion
{
    public static class CalculoDistribucion
    {
        public static double ObtenerVariableAleatoriaUniforme(double min, double max, double random)
        {
            var variable = min + random * (max - min);
            return variable;
        }

    }
}
