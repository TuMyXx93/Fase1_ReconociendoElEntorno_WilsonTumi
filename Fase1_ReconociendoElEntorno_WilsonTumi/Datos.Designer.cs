
namespace Fase1_ReconociendoElEntorno_WilsonTumi
{
    partial class Datos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.pnlDatosPrestamo = new System.Windows.Forms.Panel();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtEstratoSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarValor = new System.Windows.Forms.Button();
            this.bntInicio = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDatosPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaludo.Location = new System.Drawing.Point(12, 9);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(397, 31);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.Text = "Bienvenido al hotel TumiTumi\r\n";
            // 
            // pnlDatosPrestamo
            // 
            this.pnlDatosPrestamo.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlDatosPrestamo.Controls.Add(this.txtNombreCliente);
            this.pnlDatosPrestamo.Controls.Add(this.txtEstratoSocial);
            this.pnlDatosPrestamo.Controls.Add(this.label3);
            this.pnlDatosPrestamo.Controls.Add(this.label2);
            this.pnlDatosPrestamo.Controls.Add(this.txtCantidadDias);
            this.pnlDatosPrestamo.Controls.Add(this.label5);
            this.pnlDatosPrestamo.Location = new System.Drawing.Point(18, 155);
            this.pnlDatosPrestamo.Name = "pnlDatosPrestamo";
            this.pnlDatosPrestamo.Size = new System.Drawing.Size(480, 211);
            this.pnlDatosPrestamo.TabIndex = 8;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(303, 24);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(155, 20);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // txtEstratoSocial
            // 
            this.txtEstratoSocial.Location = new System.Drawing.Point(303, 90);
            this.txtEstratoSocial.Name = "txtEstratoSocial";
            this.txtEstratoSocial.Size = new System.Drawing.Size(74, 20);
            this.txtEstratoSocial.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(36, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite estrato social del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(4, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite cantidad de días a hospedar:";
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(303, 160);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(74, 20);
            this.txtCantidadDias.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(84, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Digite nombre del cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingresar datos personales:";
            // 
            // btnConfirmarValor
            // 
            this.btnConfirmarValor.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnConfirmarValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarValor.Location = new System.Drawing.Point(504, 217);
            this.btnConfirmarValor.Name = "btnConfirmarValor";
            this.btnConfirmarValor.Size = new System.Drawing.Size(119, 71);
            this.btnConfirmarValor.TabIndex = 10;
            this.btnConfirmarValor.Text = "Calcular valor";
            this.btnConfirmarValor.UseVisualStyleBackColor = false;
            this.btnConfirmarValor.Click += new System.EventHandler(this.btnConfirmarValor_Click);
            // 
            // bntInicio
            // 
            this.bntInicio.BackColor = System.Drawing.Color.OrangeRed;
            this.bntInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntInicio.Location = new System.Drawing.Point(660, 396);
            this.bntInicio.Name = "bntInicio";
            this.bntInicio.Size = new System.Drawing.Size(112, 53);
            this.bntInicio.TabIndex = 9;
            this.bntInicio.Text = "IR A INICIO";
            this.bntInicio.UseVisualStyleBackColor = false;
            this.bntInicio.Click += new System.EventHandler(this.bntInicio_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnConfirmarValor);
            this.Controls.Add(this.bntInicio);
            this.Controls.Add(this.pnlDatosPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del cliente";
            this.pnlDatosPrestamo.ResumeLayout(false);
            this.pnlDatosPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Panel pnlDatosPrestamo;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtEstratoSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarValor;
        private System.Windows.Forms.Button bntInicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}