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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String passwordPorDefecto = "123";
            if(txtPassword.Text == passwordPorDefecto)
            {
                using (Datos ventanaCalcular = new Datos())
                    ventanaCalcular.ShowDialog();
            }
            else
            {
                MessageBox.Show("¡La contraseña es incorrecta!");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
