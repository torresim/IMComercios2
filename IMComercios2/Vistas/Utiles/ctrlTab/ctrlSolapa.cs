using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Vistas.Utiles
{
    /// <summary>
    /// 
    /// </summary>
    public class ctrlSolapa : FontAwesome.Sharp.IconButton
    {
        Color COLOR_SELECCION = Color.FromArgb(255, 64, 64, 64);
        /// <summary>
        /// Boton con Chincheta para acoplar la ventana al panel
        /// </summary>
        public FontAwesome.Sharp.IconButton chincheta = new FontAwesome.Sharp.IconButton();

        /// <summary>
        /// Boton para cierre de la ventana
        /// </summary>
        public FontAwesome.Sharp.IconButton cerrar = new FontAwesome.Sharp.IconButton();

        /// <summary>
        /// 
        /// </summary>
        public bool activo = true;
        /// <summary>
        /// Propiedad que determina si la solapa se encuentra en estado activa
        /// </summary>
        public bool Activo
        {
            get { return activo; }
            set
            {
                activo = value;
                actualizarControl();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool chincheActivo = false;
        /// <summary>
        /// Propiedad que determina si la chincheta se encuentra en estado activa
        /// </summary>
        public bool ChincheActivo
        {
            get { return chincheActivo; }
            set
            {
                chincheActivo = value;
                actualizarControl();
            }
        }

        /// <summary>
        /// Actualiza el estado del control cuando se cambia una propiedad para visibilizar los cambios
        /// </summary>
        private void actualizarControl()
        {
            if (this.Activo) this.BackColor = COLOR_SELECCION;
            else this.BackColor = Color.FromArgb(255, 30, 30, 30);

            if (this.ChincheActivo) chincheta.BackColor = Color.Orange;
            else chincheta.BackColor = Color.FromArgb(255, 30, 30, 30);
        }

        /// <summary>
        /// Constructor del la Solapa. Se determinan todas las propiedades que dan el estilo a la solapa
        /// </summary>
        public ctrlSolapa(){
            //Propiedades de la Solapa
            this.Width = 140;
            this.Height = 30;
            this.IconSize = 28;
            this.ForeColor = Color.White;
            this.Text = "Solapa";
            this.BackColor = Color.FromArgb(255,30,30,30);
            this.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.Padding = new Padding(10,0,0,0);
            this.MouseEnter += mouseEnter;
            this.MouseLeave += mouseLeave;

            //Propiedades de la Chincheta
            chincheta.MouseEnter += mouseEnterChinche;
            chincheta.MouseLeave += mouseLeaveChinche;
            chincheta.MouseClick += mouseClickChinche;
            chincheta.Width = 22;
            chincheta.Height = 22;
            chincheta.IconSize = 13;
            chincheta.FlatStyle = FlatStyle.Flat;
            chincheta.FlatAppearance.BorderSize = 0;
            chincheta.Top = 5;
            chincheta.Left = this.Width-50;
            chincheta.IconChar = FontAwesome.Sharp.IconChar.Thumbtack;
            chincheta.IconColor = Color.White;
            this.Controls.Add(chincheta);

            //Propiedades del boton de cierre
            cerrar.Width = 22;
            cerrar.Height = 22;
            cerrar.IconSize = 13;
            cerrar.FlatStyle = FlatStyle.Flat;
            cerrar.FlatAppearance.BorderSize = 0;
            cerrar.Top = 5;
            cerrar.Left = this.Width - 25;
            cerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            cerrar.IconColor = Color.White;
            this.Controls.Add(cerrar);
        }

        private void mouseClickChinche(object sender, MouseEventArgs e)
        {
            Activo = !Activo;
        }

        /// <summary>
        /// Evento que ocurre cuando el mouse sale de la solapa. Vuelve al color anterior color de solapa
        /// </summary>
        /// <param name="sender">Quien envia la solicitud</param>
        /// <param name="e">Argumento</param>
        public void mouseLeave(object sender, EventArgs e)
        {
            if (this.Activo)
            {
                this.BackColor = COLOR_SELECCION;
                chincheta.BackColor = COLOR_SELECCION;
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 30, 30, 30);
                chincheta.BackColor = Color.FromArgb(255, 30, 30, 30);
            }
        }

        /// <summary>
        /// Evento que ocurre cuando el mouse ingresa a la solapa. Cambia color de solapa
        /// </summary>
        /// <param name="sender">Quien envia la solicitud</param>
        /// <param name="e">Argumento</param>
        private void mouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 0, 120, 215);
            chincheta.BackColor = Color.FromArgb(255, 0, 120, 215);
            this.Cursor = Cursors.Hand;
        }


        /// <summary>
        /// Evento que ocurre cuando el mouse ingresa a la chicheta. Cambia color de chicheta
        /// </summary>
        /// <param name="sender">Quien envia la solicitud</param>
        /// <param name="e">Argumento</param>
        public void mouseEnterChinche(object sender, EventArgs e)
        {
            chincheta.BackColor = Color.Orange;
            chincheta.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Evento que ocurre cuando el mouse sale de la chicheta. Cambia color de chicheta
        /// </summary>
        /// <param name="sender">Quien envia la solicitud</param>
        /// <param name="e">Argumento</param>
        public void mouseLeaveChinche(object sender, EventArgs e)
        {
            if (this.Activo) chincheta.BackColor = Color.FromArgb(255, 0, 120, 215);
            else chincheta.BackColor = Color.FromArgb(255, 30, 30, 30);
        }
    }
}
