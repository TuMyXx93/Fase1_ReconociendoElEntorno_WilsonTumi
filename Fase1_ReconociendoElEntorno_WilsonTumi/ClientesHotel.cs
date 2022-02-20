using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1_ReconociendoElEntorno_WilsonTumi
{
    public class ClientesHotel
    {
        private string nombreCliente;
        private int estratoSocial;
        private int cantidadDias;

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
    }
}
