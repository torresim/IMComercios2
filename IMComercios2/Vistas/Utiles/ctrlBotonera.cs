using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace IMComercios.Vistas.Utiles
{
    class ctrlBotonera : FontAwesome.Sharp.IconButton
    {
        private Color itemcolorAntes = Color.Red;
        private Panel p = new Panel();
        public Panel panDesplegable = new Panel();
        private Color itemcolorDespues = new Color();

        public Color ItemcolorAntes
        {
            get { return itemcolorAntes; }
            set
            {
                itemcolorAntes = value;
                actualizarControl();
            }
        }

        public Color ItemcolorDespues
        {
            get { return itemcolorDespues; }
            set
            {
                itemcolorDespues = value;
                actualizarControl();
            }
        }

        public Panel PanDesplegable
        {
            get { return panDesplegable; }
            set
            {
                panDesplegable = value;
                actualizarControl();
            }
        }

        private void actualizarControl()
        {
            p.BackColor = itemcolorAntes;
            this.IconColor = itemcolorAntes;
            if (!this.Enabled)
            {
                p.BackColor = Color.Gray;
                this.IconColor = Color.Gray;
            }
        }

        public ctrlBotonera()
        {
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackColor = Color.White;
            this.Height = 50;
            this.ForeColor = Color.DarkSlateGray;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.IconColor = Color.FromArgb(255, 0, 96, 150);
            this.IconSize = 30;
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MouseEnter += new EventHandler(this.mouseEnter);
            this.MouseLeave += new EventHandler(this.mouseLeave);
            this.MouseClick += new MouseEventHandler(this.mouseClick);
            p.BackColor = itemcolorAntes;
            this.Controls.Add(p);
            p.Left = 220;
            p.Top = 1;
            p.Height = 48;
            p.Width = 40;
        }

        private void mouseClick(object sender, EventArgs e)
        {
            if(panDesplegable != null)
                panDesplegable.Visible = !panDesplegable.Visible;
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            activo();
            
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            inactivo();
        }

        public void activo()
        {
            p.BackColor = itemcolorDespues;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconColor = itemcolorDespues;
        }

        public void inactivo()
        {
            this.ItemcolorAntes = itemcolorAntes;
            this.IconColor = itemcolorAntes;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ctrlBotonera
            // 
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResumeLayout(false);

        }
    }
}
