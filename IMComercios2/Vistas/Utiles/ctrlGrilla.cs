using IMComercios2.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Vistas.Utiles
{
    public class ctrlGrilla : DataGridView
    {
        List<btnGrilla> botones = new List<btnGrilla>();

        public ctrlGrilla() 
        {

        }

        private void CtrlGrilla_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach(btnGrilla b in botones)
            {
                if (e.ColumnIndex >= 0 && this.Columns[e.ColumnIndex].Name == b.getNombre() && e.RowIndex >= 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\" + b.getIcono());
                    e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 8, e.CellBounds.Top + 8);
                    this.Rows[e.RowIndex].Height = icoAtomico.Height + 16;
                    this.Columns[e.ColumnIndex].Width = icoAtomico.Width + 16;
                    e.Handled = true;
                }
            }
        }

        public void agregarBtn(string nombre, string icono, Func<string> metodo, string clave)
        {
            btnGrilla boton = new btnGrilla(nombre, icono, metodo, clave);
            botones.Add(boton);

            DataGridViewButtonColumn bot = new DataGridViewButtonColumn();
            bot.Name = nombre;
            bot.HeaderText = "";
            bot.FlatStyle = FlatStyle.Flat;
            bot.CellTemplate.Style.ForeColor = Color.Transparent;
            this.Columns.Add(bot);
            this.Visible = true;
        }

        class btnGrilla
        {
            private string nombre { get; set; }
            private string icono { get; set; }
            private Func<string> metodo { get; set; }
            private string clave { get; set; }

            public btnGrilla(string nombre,string icono, Func<string> metodo, string clave)
            {
                this.nombre = nombre;
                this.icono = icono;
                this.metodo = metodo;
                this.clave = clave;
            }

            public string getNombre() => nombre;
            public string getIcono() => icono;
            public Func<string> getMetodo() => metodo;
            public string getClave() => clave;
        }

        public void aplicarEstilo()
        {
            this.VirtualMode = true;
            this.DoubleBuffered = true;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 0, 90, 150);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.EnableHeadersVisualStyles = false;
            this.GridColor = Color.FromArgb(255, 60, 60, 60);
            this.RowTemplate.Height = 41;
            this.RowHeadersWidth = 30;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnHeadersHeight = 30;
            this.BackgroundColor = Color.FromArgb(255, 30, 30, 30);
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 0, 96, 150);
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ScrollBars = ScrollBars.Vertical;

            //this.Rows[0].Selected = true;

            DataGridViewCellStyle estilo = new DataGridViewCellStyle();

            estilo.BackColor = Color.FromArgb(255, 64, 64, 64);
            estilo.SelectionBackColor = Color.Orange;
            estilo.SelectionForeColor = Color.White;
            this.RowHeadersDefaultCellStyle = estilo;

            estilo.BackColor = Color.FromArgb(255, 50, 50, 50);
            estilo.ForeColor = Color.White;
            estilo.SelectionForeColor = Color.Black;
            this.AlternatingRowsDefaultCellStyle = estilo;

            this.DefaultCellStyle.BackColor = Color.FromArgb(255, 60, 60, 60);
            this.DefaultCellStyle.ForeColor = Color.White;
            this.DefaultCellStyle.SelectionBackColor = Color.Orange;
            this.DefaultCellStyle.SelectionForeColor = Color.Black;

            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));

            this.CellPainting += CtrlGrilla_CellPainting;
            this.CellClick += CtrlGrilla_CellClick;
        }

        private void CtrlGrilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                foreach (btnGrilla b in botones)
                {
                    if (this.Columns[e.ColumnIndex].Name == b.getNombre())
                    {
                       // b.getMetodo(Int32.Parse(this.CurrentRow.Cells[b.getClave()].Value.ToString()));
                    }
                }
                
            }
        }
    }
}
