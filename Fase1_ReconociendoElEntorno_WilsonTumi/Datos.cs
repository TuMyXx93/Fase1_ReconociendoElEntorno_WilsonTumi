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
    public partial class Datos : Form
    {
        /**
         * Declarando e instanciando un objeto.
         * 
         * Declaramos el objeto 'cliente1' de la clase
         * 'ClientesHotel' y lo instanciamos (creamos) con 'new'.
         */
        ClientesHotel cliente1 = new ClientesHotel();

        /**
         * Método o Constructor inicialización de la clase 'Datos'.
         */
        public Datos()
        {
            InitializeComponent();
        }

        /**
         * Método del botón 'Inicio' con el evento Click
         */
        private void bntInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Método con argumentos
         * 
         * Evento del botón 'Confirmar Valor' de la clase 'Datos'.
         * De forma automática crea el método private por lo que,
         * solo las derivadas pueden llamar a esto.
         */
        private void btnConfirmarValor_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "" || txtEstratoSocial.Text == "" || txtCantidadDias.Text == "")
            {
                errorProvider1.SetError(txtNombreCliente, "Debe ingresar nombre de cliente");
                errorProvider1.SetError(txtEstratoSocial, "Debe ingresar estrato social");
                errorProvider1.SetError(txtCantidadDias, "Debe ingresar cantidad de días a hospedar");
                return;
            }
            int estratoSocial1;
            int cantidadDias1;

            if (!int.TryParse(txtEstratoSocial.Text, out estratoSocial1) || !int.TryParse(txtCantidadDias.Text, out cantidadDias1))
            {
                errorProvider1.SetError(txtEstratoSocial, "Debe ingresar un número de estrato");
                errorProvider1.SetError(txtCantidadDias, "Debe ingresar un número de días");
                return;
            }

            cliente1.NombreCliente = txtNombreCliente.Text;
            cliente1.EstratoSocial = Convert.ToInt32(txtEstratoSocial.Text);
            cliente1.CantidadDias = Convert.ToInt32(txtCantidadDias.Text);

            /**
             * Declarando e instanciando un objeto.
             * 
             * Declaramos el objeto 'ventanaDatos' de la clase
             * 'Informacion' y lo instanciamos (creamos) con 'new'.
             */
            using (Informacion ventanaDatos = new Informacion(cliente1.NombreCliente, cliente1.EstratoSocial, cliente1.CantidadDias))
                ventanaDatos.ShowDialog();

        }
    }//Fin de la clase
}
