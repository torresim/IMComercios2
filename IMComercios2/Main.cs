using IMComercios.Modelos.Entidades;
using IMComercios.Vistas.TablasMaestras;
using IMComercios.Vistas.Utiles;
using IMComercios2.Modelos.Entidades;
using IMComercios2.Vistas.TablasMaestras;
using IMComercios2.Vistas.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace IMComercios2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ctrlBotonera2_Click(object sender, EventArgs e)
        {
            verificaPanel();
        }

        private void verificaPanel()
        {
            if (isPanelOculto())
            {
                iconPictureBox2_Click(null, null);
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (!isPanelOculto())
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
                t.add(this.panLateral, "Left", (-1) * (this.panLateral.Width - 50));
                t.run();
                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(200));
                t2.add(panVentanas, "Left", 40);
                t2.run();
                Transition t3 = new Transition(new TransitionType_EaseInEaseOut(200));
                t3.add(panPrincipal, "Left", 52);
                t3.run();
                panPrincipal.Width = panPrincipal.Width + (this.panLateral.Width - 50);
                this.picLogo.Visible = false;
                this.lblMenu.Visible = false;
                ocultarSubmenu();
                moverIconos();
            }
            else
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
                t.add(this.panLateral, "Left", 0);
                t.run();
                Transition t2 = new Transition(new TransitionType_EaseInEaseOut(200));
                t2.add(panVentanas, "Left", 223);
                t2.run();
                Transition t3 = new Transition(new TransitionType_EaseInEaseOut(200));
                t3.add(panPrincipal, "Left", 226);
                t3.run();
                panPrincipal.Width = panPrincipal.Width - (this.panLateral.Width - 50);
                reacomodarIconos();
                this.picLogo.Visible = true;
                this.lblMenu.Visible = true;
            }
        }

        private void moverIconos()
        {
            foreach (ctrlBotonera b in panLateral.Controls.OfType<ctrlBotonera>())
            {
                //if (b.panDesplegable != null)
                //{
                b.TextImageRelation = TextImageRelation.TextBeforeImage;
                b.ImageAlign = ContentAlignment.MiddleRight;
                b.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
                //}
            }
        }

        private void reacomodarIconos()
        {
            foreach (ctrlBotonera b in panLateral.Controls.OfType<ctrlBotonera>())
            {
                //if (b.panDesplegable != null)
                //{
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                //}
            }
        }

        public void ocultarSubmenu()
        {
            foreach (ctrlBotonera b in panLateral.Controls.OfType<ctrlBotonera>())
            {
                if (b.panDesplegable != null)
                {
                    b.panDesplegable.Visible = false;
                }
            }
        }

        private void ctrlBotonera3_Click(object sender, EventArgs e)
        {

            abrirVentana(new ctrlVentana("Proveedores", 2, new tblProveedores()));

        }

        private void abrirVentana(ctrlVentana ventana)
        {
            ventana.Dock = DockStyle.Left;
            panVentanas.Controls.Add(ventana);

            if (ventana.Tipo == 1)
            {
                ventana.ventana.Show();
            }
            else
            {
                AbrirFormInPanel(ventana.ventana,this.panPrincipal);
            }
        }

        private void ctrlBotonera1_Click(object sender, EventArgs e)
        {
            verificaPanel();
        }

        private void ctrlBotonera11_Click(object sender, EventArgs e)
        {
            verificaPanel();
        }

        private void ctrlBotonera16_Click(object sender, EventArgs e)
        {
            verificaPanel();
        }

        private void ctrlBotonera17_Click(object sender, EventArgs e)
        {
            verificaPanel();
        }

        public bool isPanelOculto()
        {
            if (this.panLateral.Left == ((-1) * (this.panLateral.Width - 50)))
            {
                return true;
            }

            return false;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            iconPictureBox2_Click(null, null);
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        public void AbrirFormInPanel(Form formHijo, Panel panContenedor)
        {
            panContenedor.Controls.Clear();
            if (panContenedor.Controls.Count > 0)
                panContenedor.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panContenedor.Controls.Add(formHijo);
            panContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ctrlBotonera6_Click(object sender, EventArgs e)
        {
            abrirVentana(new ctrlVentana("Clientes", 2, new tblClientes()));
        }
    }
}
