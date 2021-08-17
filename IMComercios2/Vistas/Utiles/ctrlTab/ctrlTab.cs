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
    [Designer(typeof(ctrlTabDisenio))]
    public partial class ctrlTab : UserControl
    {
        public enum Solapas
        {
            Solapa_1,
            Solapa_2,
            Solapa_3,
            Solapa_4,
            Solapa_5,
            Solapa_6
        }

        public bool usarCerrar = false;
        public bool UsarCerrar
        {
            get { return usarCerrar; }
            set
            {
                usarCerrar = value;
                actualizaControl();
            }
        }

        public bool usarAcoplar = false;
        public bool UsarAcoplar
        {
            get { return usarAcoplar; }
            set
            {
                usarAcoplar = value;
                actualizaControl();
            }
        }

        public Solapas activo = Solapas.Solapa_1;
        public Solapas Activo
        {
            get { return activo;}
            set 
            { 
                activo = value;
                actualizaControl();
            }
        }

        public string[] usarSolapa = 
        { 
            "-", 
            "-", 
            "-", 
            "-", 
            "-", 
            "-" 
        };

        public string[] UsarSolapa
        {
            get { return usarSolapa; }
            set
            {
                usarSolapa = value;
                actualizaControl();
            }
        }

        public void actualizaControl()
        {
            reiniciarSolapas();

            if (UsarCerrar)
            {
                this.ctrlSolapa1.cerrar.Visible = true;
                this.ctrlSolapa2.cerrar.Visible = true;
                this.ctrlSolapa3.cerrar.Visible = true;
                this.ctrlSolapa4.cerrar.Visible = true;
                this.ctrlSolapa5.cerrar.Visible = true;
                this.ctrlSolapa6.cerrar.Visible = true;
            }
            else
            {
                this.ctrlSolapa1.cerrar.Visible = false;
                this.ctrlSolapa2.cerrar.Visible = false;
                this.ctrlSolapa3.cerrar.Visible = false;
                this.ctrlSolapa4.cerrar.Visible = false;
                this.ctrlSolapa5.cerrar.Visible = false;
                this.ctrlSolapa6.cerrar.Visible = false;
            }

            if (UsarAcoplar)
            {
                this.ctrlSolapa1.chincheta.Visible = true;
                this.ctrlSolapa2.chincheta.Visible = true;
                this.ctrlSolapa3.chincheta.Visible = true;
                this.ctrlSolapa4.chincheta.Visible = true;
                this.ctrlSolapa5.chincheta.Visible = true;
                this.ctrlSolapa6.chincheta.Visible = true;
            }
            else
            {
                this.ctrlSolapa1.chincheta.Visible = false;
                this.ctrlSolapa2.chincheta.Visible = false;
                this.ctrlSolapa3.chincheta.Visible = false;
                this.ctrlSolapa4.chincheta.Visible = false;
                this.ctrlSolapa5.chincheta.Visible = false;
                this.ctrlSolapa6.chincheta.Visible = false;
            }


            this.ctrlSolapa1.Visible = false;
            this.ctrlSolapa2.Visible = false;
            this.ctrlSolapa3.Visible = false;
            this.ctrlSolapa4.Visible = false;
            this.ctrlSolapa5.Visible = false;
            this.ctrlSolapa6.Visible = false;

            if (UsarSolapa[0] != "-") 
            {
                this.ctrlSolapa1.Visible = true;
                this.ctrlSolapa1.Text = UsarSolapa[0];
            }
            if (UsarSolapa[1] != "-") 
            {
                this.ctrlSolapa2.Visible = true;
                this.ctrlSolapa2.Text = UsarSolapa[1];
            }
            if (UsarSolapa[2] != "-") 
            {
                this.ctrlSolapa3.Visible = true;
                this.ctrlSolapa3.Text = UsarSolapa[2];
            }
            if (UsarSolapa[3] != "-") 
            {
                this.ctrlSolapa4.Visible = true;
                this.ctrlSolapa4.Text = UsarSolapa[3];
            }
            if (UsarSolapa[4] != "-") 
            {
                this.ctrlSolapa5.Visible = true;
                this.ctrlSolapa5.Text = UsarSolapa[4];
            }
            if (UsarSolapa[5] != "-")
            {
                this.ctrlSolapa6.Visible = true;
                this.ctrlSolapa6.Text = UsarSolapa[5];
            }

            verificarAcoplar();
        }

        #region Acoplar Paneles
        private void verificarAcoplar()
        {
            //if (Activo.Sum() > 1)
            //{
            //    int cantidadDibujada = 0;
            //    if (Activo.Sum() == 2)
            //    {
            //        if (Activo[0] == 1)
            //        {
            //            if (cantidadDibujada == 0) {
            //                this.ctrlSolapa1.Dock = DockStyle.None;
            //                this.ctrlSolapa1.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //            else
            //            {
            //                this.ctrlSolapa1.Dock = DockStyle.None;
            //                this.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                this.ctrlSolapa1.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //        }
            //        if (Activo[1] == 1)
            //        {
            //            if (cantidadDibujada == 0)
            //            {
            //                this.ctrlSolapa2.Dock = DockStyle.None;
            //                this.ctrlSolapa2.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //            else
            //            {
            //                this.ctrlSolapa2.Dock = DockStyle.None;
            //                this.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                this.ctrlSolapa2.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //        }
            //        if (Activo[2] == 1)
            //        {
            //            if (cantidadDibujada == 0)
            //            {
            //                this.ctrlSolapa3.Dock = DockStyle.None;
            //                this.ctrlSolapa3.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //            else
            //            {
            //                this.ctrlSolapa3.Dock = DockStyle.None;
            //                this.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                this.ctrlSolapa3.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //        }
            //        if (Activo[3] == 1)
            //        {
            //            if (cantidadDibujada == 0)
            //            {
            //                this.ctrlSolapa4.Dock = DockStyle.None;
            //                this.ctrlSolapa4.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //            else
            //            {
            //                this.ctrlSolapa4.Dock = DockStyle.None;
            //                this.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                this.ctrlSolapa4.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //        }
            //        if (Activo[4] == 1)
            //        {
            //            if (cantidadDibujada == 0)
            //            {
            //                this.ctrlSolapa5.Dock = DockStyle.None;
            //                this.ctrlSolapa5.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //            else
            //            {
            //                this.ctrlSolapa6.Dock = DockStyle.None;
            //                this.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                this.ctrlSolapa6.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //        }
            //        if (Activo[5] == 1)
            //        {
            //            if (cantidadDibujada == 0)
            //            {
            //                this.ctrlSolapa6.Dock = DockStyle.None;
            //                this.ctrlSolapa6.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //            else
            //            {
            //                this.ctrlSolapa6.Dock = DockStyle.None;
            //                this.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                this.ctrlSolapa6.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2;
            //                cantidadDibujada = 1;
            //            }
            //        }
            //    }
            //}
        }
        #endregion

        public ctrlTab()
        {
            InitializeComponent();
            iniciarControles();
            actualizaControl();
        }

        private void iniciarControles()
        {
            this.ctrlSolapa1.cerrar.MouseClick += cerrarSolapa1;
            this.ctrlSolapa2.cerrar.MouseClick += cerrarSolapa2;
            this.ctrlSolapa3.cerrar.MouseClick += cerrarSolapa3;
            this.ctrlSolapa4.cerrar.MouseClick += cerrarSolapa4;
            this.ctrlSolapa5.cerrar.MouseClick += cerrarSolapa5;
            this.ctrlSolapa6.cerrar.MouseClick += cerrarSolapa6;
        }

        private void reiniciarSolapas()
        {
            if (Activo == Solapas.Solapa_1) ctrlSolapa1_Click(null, null);
            if (Activo == Solapas.Solapa_2) ctrlSolapa2_Click(null, null);
            if (Activo == Solapas.Solapa_3) ctrlSolapa3_Click(null, null);
            if (Activo == Solapas.Solapa_4) ctrlSolapa4_Click(null, null);
            if (Activo == Solapas.Solapa_5) ctrlSolapa5_Click(null, null);
            if (Activo == Solapas.Solapa_6) ctrlSolapa6_Click(null, null);
        }

        private void cerrarSolapa1(object sender, MouseEventArgs e)
        {
            UsarSolapa[0] = "-";
            actualizaControl();
            if (Activo == Solapas.Solapa_2 && UsarSolapa[1] != "-") { Activo = Solapas.Solapa_2; return; }
            if (Activo == Solapas.Solapa_3 && UsarSolapa[2] != "-") { Activo = Solapas.Solapa_3; return; }
            if (Activo == Solapas.Solapa_4 && UsarSolapa[3] != "-") { Activo = Solapas.Solapa_4; return; }
            if (Activo == Solapas.Solapa_5 && UsarSolapa[4] != "-") { Activo = Solapas.Solapa_5; return; }
            if (Activo == Solapas.Solapa_6 && UsarSolapa[5] != "-") { Activo = Solapas.Solapa_6; return; }
        }                                     

        private void cerrarSolapa2(object sender, MouseEventArgs e)
        {
            UsarSolapa[1] = "-";
            actualizaControl();
            if (Activo == Solapas.Solapa_1 && UsarSolapa[0] != "-") { Activo = Solapas.Solapa_1; return; }
            if (Activo == Solapas.Solapa_3 && UsarSolapa[2] != "-") { Activo = Solapas.Solapa_3; return; }
            if (Activo == Solapas.Solapa_4 && UsarSolapa[3] != "-") { Activo = Solapas.Solapa_4; return; }
            if (Activo == Solapas.Solapa_5 && UsarSolapa[4] != "-") { Activo = Solapas.Solapa_5; return; }
            if (Activo == Solapas.Solapa_6 && UsarSolapa[5] != "-") { Activo = Solapas.Solapa_6; return; }
        }
        private void cerrarSolapa3(object sender, MouseEventArgs e)
        {
            UsarSolapa[2] = "-";
            actualizaControl();
            if (Activo == Solapas.Solapa_2 && UsarSolapa[1] != "-") { Activo = Solapas.Solapa_2; return; }
            if (Activo == Solapas.Solapa_1 && UsarSolapa[0] != "-") { Activo = Solapas.Solapa_1; return; }
            if (Activo == Solapas.Solapa_4 && UsarSolapa[3] != "-") { Activo = Solapas.Solapa_4; return; }
            if (Activo == Solapas.Solapa_5 && UsarSolapa[4] != "-") { Activo = Solapas.Solapa_5; return; }
            if (Activo == Solapas.Solapa_6 && UsarSolapa[5] != "-") { Activo = Solapas.Solapa_6; return; }
        }
        private void cerrarSolapa4(object sender, MouseEventArgs e)
        {
            UsarSolapa[3] = "-";
            actualizaControl();
            if (Activo == Solapas.Solapa_2 && UsarSolapa[1] != "-") { Activo = Solapas.Solapa_2; return; }
            if (Activo == Solapas.Solapa_3 && UsarSolapa[2] != "-") { Activo = Solapas.Solapa_3; return; }
            if (Activo == Solapas.Solapa_1 && UsarSolapa[0] != "-") { Activo = Solapas.Solapa_1; return; }
            if (Activo == Solapas.Solapa_5 && UsarSolapa[4] != "-") { Activo = Solapas.Solapa_5; return; }
            if (Activo == Solapas.Solapa_6 && UsarSolapa[5] != "-") { Activo = Solapas.Solapa_6; return; }
        }
        private void cerrarSolapa5(object sender, MouseEventArgs e)
        {
            UsarSolapa[4] = "-";
            actualizaControl();
            if (Activo == Solapas.Solapa_2 && UsarSolapa[1] != "-") { Activo = Solapas.Solapa_2; return; }
            if (Activo == Solapas.Solapa_3 && UsarSolapa[2] != "-") { Activo = Solapas.Solapa_3; return; }
            if (Activo == Solapas.Solapa_4 && UsarSolapa[3] != "-") { Activo = Solapas.Solapa_4; return; }
            if (Activo == Solapas.Solapa_1 && UsarSolapa[0] != "-") { Activo = Solapas.Solapa_1; return; }
            if (Activo == Solapas.Solapa_6 && UsarSolapa[5] != "-") { Activo = Solapas.Solapa_6; return; }
        }
        private void cerrarSolapa6(object sender, MouseEventArgs e)
        {
            UsarSolapa[5] = "-";
            actualizaControl();
            if (Activo == Solapas.Solapa_2 && UsarSolapa[1] != "-") { Activo = Solapas.Solapa_2; return; }
            if (Activo == Solapas.Solapa_3 && UsarSolapa[2] != "-") { Activo = Solapas.Solapa_3; return; }
            if (Activo == Solapas.Solapa_4 && UsarSolapa[3] != "-") { Activo = Solapas.Solapa_4; return; }
            if (Activo == Solapas.Solapa_5 && UsarSolapa[4] != "-") { Activo = Solapas.Solapa_5; return; }
            if (Activo == Solapas.Solapa_1 && UsarSolapa[0] != "-") { Activo = Solapas.Solapa_1; return; }
        }


        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel AreaTrabajo1 { get { return this.panAreaTrabajo1; } }

        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel AreaTrabajo2 { get { return this.panAreaTrabajo2; } }

        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel AreaTrabajo3 { get { return this.panAreaTrabajo3; } }

        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel AreaTrabajo4{ get { return this.panAreaTrabajo4; } }

        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel AreaTrabajo5 { get { return this.panAreaTrabajo5; } }

        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel AreaTrabajo6 { get { return this.panAreaTrabajo6; } }

        private void desactivarTodos()
        {
            this.ctrlSolapa1.Activo = false;
            this.ctrlSolapa2.Activo = false;
            this.ctrlSolapa3.Activo = false;
            this.ctrlSolapa4.Activo = false;
            this.ctrlSolapa5.Activo = false;
            this.ctrlSolapa6.Activo = false;

            this.ctrlSolapa1.mouseLeave(null, null);
            this.ctrlSolapa2.mouseLeave(null, null);
            this.ctrlSolapa3.mouseLeave(null, null);
            this.ctrlSolapa4.mouseLeave(null, null);
            this.ctrlSolapa5.mouseLeave(null, null);
            this.ctrlSolapa6.mouseLeave(null, null);
        }

        private void desactivarChinchetas()
        {
            this.ctrlSolapa1.chincheActivo = false;
            this.ctrlSolapa2.chincheActivo = false;
            this.ctrlSolapa3.chincheActivo = false;
            this.ctrlSolapa4.chincheActivo = false;
            this.ctrlSolapa5.chincheActivo = false;
            this.ctrlSolapa6.chincheActivo = false;

            this.ctrlSolapa1.mouseLeaveChinche(null, null);
            this.ctrlSolapa2.mouseLeaveChinche(null, null);
            this.ctrlSolapa3.mouseLeaveChinche(null, null);
            this.ctrlSolapa4.mouseLeaveChinche(null, null);
            this.ctrlSolapa5.mouseLeaveChinche(null, null);
            this.ctrlSolapa6.mouseLeaveChinche(null, null);
        }
        private void ctrlSolapa1_Click(object sender, EventArgs e)
        {
            desactivarTodos();
            this.ctrlSolapa1.Activo = true;
            this.ctrlSolapa1.chincheta.BackColor = Color.FromArgb(255, 0, 120, 215);
            this.panAreaTrabajo1.BringToFront();
            desactivarChinchetas();
        }

        private void ctrlSolapa2_Click(object sender, EventArgs e)
        {
            desactivarTodos();
            this.ctrlSolapa2.Activo = true;
            this.panAreaTrabajo2.BringToFront();
            desactivarChinchetas();
        }

        private void ctrlSolapa3_Click(object sender, EventArgs e)
        {
            desactivarTodos();
            this.ctrlSolapa3.Activo = true;
            this.panAreaTrabajo3.BringToFront();
            desactivarChinchetas();
        }

        private void ctrlSolapa4_Click(object sender, EventArgs e)
        {
            desactivarTodos();
            this.ctrlSolapa4.Activo = true;
            this.panAreaTrabajo4.BringToFront();
            desactivarChinchetas();
        }

        private void ctrlSolapa5_Click(object sender, EventArgs e)
        {
            desactivarTodos();
            this.ctrlSolapa5.Activo = true;
            this.panAreaTrabajo5.BringToFront();
            desactivarChinchetas();
        }

        private void ctrlSolapa6_Click(object sender, EventArgs e)
        {
            desactivarTodos();
            this.ctrlSolapa6.Activo = true;
            this.panAreaTrabajo6.BringToFront();
            desactivarChinchetas();
        }
    }
}
