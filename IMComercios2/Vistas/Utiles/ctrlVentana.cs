using IMComercios2.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Vistas.Utiles
{
    public partial class ctrlVentana : UserControl
    {
        public Form ventana;
        public int estado;
        public int tipo;
        public string texto;

        // Indica el estado de la ventana
        public int Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                actualizarControl();
            }
        }

        public string Texto
        {
            get { return texto; }
            set
            {
                texto = value;
                actualizarControl();
            }
        }

        public int Tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;
                actualizarControl();
            }
        }

        public Form Ventana
        {
            get { return ventana; }
            set
            {
                ventana = value;
                actualizarControl();
            }
        }

        private void actualizarControl()
        {
            if (estado == 2)
            {
                this.btnVisible.IconColor = Color.FromArgb(255, 60, 60, 60);
                ventana.Hide();
            }
            else
            {
                this.btnVisible.IconColor = Color.White;
                ventana.Show();
            }

            if (tipo == 2)
            {
                this.btnAcoplable.IconColor = Color.FromArgb(255, 60, 60, 60);
            }
            else
            {
                this.btnAcoplable.IconColor = Color.White;
            }

            this.lblVantana.Text = texto;
        }

        public ctrlVentana(string nombre,int tipo,Form ventana)
        {
            InitializeComponent();
            this.ventana = ventana;
            Texto = nombre;
            Tipo = tipo;
            ventana.FormClosing += Ventana_FormClosing;
        }

        private void Ventana_FormClosing(object sender, FormClosingEventArgs e)
        {
           //Main.panVentanas.Controls.Remove(this);
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255,30,30,30);
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 0, 120, 215);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            ventana.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (estado == 2)
            {
                Estado = 1;
            }
            else
            {
                Estado = 2;
            }
        }

        private void btnAcoplable_Click(object sender, EventArgs e)
        {
            if (tipo == 2)
            {
                Tipo = 1;
            }
            else
            {
                Tipo = 2;
            }
        }
    }
}
