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
    public class ClientesHotel
    {
        /*
         *Atributos de la clase 'ClientesHotel'. 
         */
        private string nombreCliente;
        private int estratoSocial;
        private int cantidadDias;

        /**
         * Método
         * 
         * Dentro del método generamos Getters y Setters.
         * Los cuales nos sirven para obtener datos variable,
         * asignar o cambiar variable.
         */
        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }
            set
            {
                nombreCliente = value;
            }
        }

        public int EstratoSocial
        {
            get
            {
                return estratoSocial;
            }
            set
            {
                estratoSocial = value;
            }
        }

        public int CantidadDias
        {
            get
            {
                return cantidadDias;
            }
            set
            {
                cantidadDias = value;
            }
        }
    }//Fin de la clase
}
