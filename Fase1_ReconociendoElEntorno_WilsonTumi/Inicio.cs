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
    public partial class Inicio : Form
    {
        /**
         * Método o Constructor inicialización de la clase 'Inicio'
         */
        public Inicio()
        {
            InitializeComponent();
        }

        /**
         * Método del botón 'Salir' con el evento Click
         */
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**
         * Método con argumentos
         * 
         * Evento del botón 'Ingresar' de la clase 'Inicio'.
         * De forma automática crea el método private por lo que,
         * solo las derivadas pueden llamar a esto.
         */

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /**
             * Atributos del método 'btnIngresar'.
             */
            String passwordPorDefecto = "123";
            if(txtPassword.Text == passwordPorDefecto)
            {
                /**
                 * Declarando e instanciando un objeto.
                 * 
                 * Declaramos el objeto 'ventanaCalcular' de la clase
                 * 'Datos' y lo instanciamos (creamos) con 'new'.
                 */
                using (Datos ventanaCalcular = new Datos())
                    ventanaCalcular.ShowDialog();//Muestra la ventana de 'Datos'
            }
            else
            {
                MessageBox.Show("¡La contraseña es incorrecta!");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }//Fin de la clase
}
