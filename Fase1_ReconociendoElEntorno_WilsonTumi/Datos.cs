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
    public partial class Datos : Form
    {
        ClientesHotel cliente1 = new ClientesHotel();

        public Datos()
        {
            InitializeComponent();
        }

        private void bntInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

            using (Informacion ventanaDatos = new Informacion(cliente1.NombreCliente, cliente1.EstratoSocial, cliente1.CantidadDias))
                ventanaDatos.ShowDialog();

        }
    }
}
