/**
 * Aquí nos muestra todo lo que esta importando
 * o necesita para que funcione nuestra app
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase1_ReconociendoElEntorno_WilsonTumi
{
    /**
     * Clase principal a partir de la cual se va a
     * instanciar el formulario en el cual estamos
     * creando nuestra app
     * 
     * También esta heredando de la clase ‘Form’,
     * que es la clase base a partir de la cual se
     * crean las ventanas en C#
     */
    public partial class Informacion : Form
    {
        //ClientesHotel cliente2 = new ClientesHotel();
        OperacacionValor operacion2 = new OperacacionValor();

        public Informacion(String nombreCliente, int estratoSocial, int cantidaDias)
        {
            InitializeComponent();

            this.lblNombreCliente.Text = nombreCliente;
            this.lblEstratoSocial.Text = Convert.ToString(estratoSocial);
            this.lblCantidadDias.Text = Convert.ToString(cantidaDias);
            this.lblValorPago.Text = operacion2.calcularTotalPago(estratoSocial, cantidaDias).ToString();

            if(estratoSocial == 1 || estratoSocial == 2)
            {
                this.lblDescuento.Text = "Aplica descuento del 15%";
            }
            else
            {
                this.lblDescuento.Text = "No aplica descuento";
            }
        }

        private void bntVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//Fin de la clase
}
