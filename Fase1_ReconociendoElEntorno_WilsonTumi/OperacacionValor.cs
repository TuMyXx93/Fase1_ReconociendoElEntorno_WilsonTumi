/**
 * Aquí nos muestra todo lo que esta importando
 * o necesita para que funcione nuestra app
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1_ReconociendoElEntorno_WilsonTumi
{
    /**
     * Clase principal
     */
    public class OperacacionValor
    {
        /**
         * Método público de la clase 'OperacionValor'
         * 
         * Método con argumentos
         */
        public double calcularTotalPago(int estratoSocial, int cantidadDias)
        {
            /**
             * Atributos del método 'calcularTotalPago'.
             */
            const int valorDia = 90000;
            int totalAPagar = cantidadDias * valorDia;

            /**
             * Condicional 'if' para saber si cumple
             * o no cumple la condición del estrato
             * social digitado en el campo de texto
             * 'txtEstratoSocial' de la clase 'Datos'.
             */
            if (estratoSocial == 1 || estratoSocial == 2)
            {
                return totalAPagar * 0.15;
            }
            else
            {
                return totalAPagar;
            }
        }
    }//Fin de la clase
}
