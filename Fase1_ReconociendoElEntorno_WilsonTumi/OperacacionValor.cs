using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1_ReconociendoElEntorno_WilsonTumi
{
    public class OperacacionValor
    {
        public double calcularTotalPago(int estratoSocial, int cantidadDias)
        {
            const int valorDia = 90000;
            int totalAPagar = cantidadDias * valorDia;

            if (estratoSocial == 1 || estratoSocial == 2)
            {
                return totalAPagar * 0.15;
            }
            else
            {
                return totalAPagar;
            }
        }
    }
}
