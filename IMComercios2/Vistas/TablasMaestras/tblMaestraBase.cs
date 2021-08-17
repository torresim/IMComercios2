using IMComercios.Controladores;
using IMComercios.Modelos.Entidades;
using IMComercios2;
using IMComercios2.Vistas.Utiles;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace IMComercios.Vistas.TablasMaestras
{
    public partial class tblMaestraBase : Form
    {
        public entABM abm = new entABM();

        public delegate void SafeCallDelegate(object sender, DoWorkEventArgs e);


        public tblMaestraBase()
        {
            InitializeComponent();
        }

        public virtual void preprararGrilla()
        {
            BackgroundWorker bkw = new BackgroundWorker();
            bkw.DoWork += cargarGrilla;
            bkw.RunWorkerCompleted += finalizarGrilla;
            bkw.RunWorkerAsync();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.RemoveAt(0);
        }

        public virtual void preprarABM()
        {
            this.dgGrilla.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            this.dgGrilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 0, 90, 150);
            //this.dgGrilla.AutoGenerateColumns = true;
            this.dgGrilla.EnableHeadersVisualStyles = false;
            this.dgGrilla.GridColor = Color.FromArgb(255, 60, 60, 60);
            this.dgGrilla.RowTemplate.Height = 41;
            this.preprararGrilla();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            aplicarFiltro();
        }

        public void aplicarFiltro()
        {
            this.abm.Filtro = this.txtBuscar.Text;
            MaestraBase_Load(null, null);
        }

        private void MaestraBase_Load(object sender, EventArgs e)
        {
            panProcesandoAbm.Visible = true;
            dgGrilla.Visible = false;
            dgGrilla.DataSource = null;
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            preprarABM();
            this.timer1.Enabled = false;
        }

        public virtual void cargarGrilla(object sender, DoWorkEventArgs e)
        {
            if (dgGrilla.InvokeRequired)
            {
                var d = new SafeCallDelegate(cargarGrilla);
                dgGrilla.Invoke(d, new object[] { sender, e });
            }
            else
            {
                setGrilla();
                this.lblTabla.Text = abm.Tabla;
                this.lblRegistros.Text = dgGrilla.Rows.Count.ToString();
            }
        }

        private void finalizarGrilla(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (DataGridViewColumn col in dgGrilla.Columns)
            {
                if (!this.abm.Columnas.Contains(col.HeaderText))
                {
                    col.Visible = false;
                }
                //col.HeaderText = col.HeaderText.Substring(0, 1).ToUpper() +
                //                 col.HeaderText.Substring(1).ToLower();
            }

            this.panProcesandoAbm.Visible = false;

            DataGridViewButtonColumn bot = new DataGridViewButtonColumn();
            bot.Name = "Editar";
            bot.HeaderText = "";
            bot.FlatStyle = FlatStyle.Flat;
            bot.CellTemplate.Style.ForeColor = Color.Transparent;
            dgGrilla.Columns.Add(bot);
            dgGrilla.Visible = true;

        }

        public virtual void setGrilla()
        {
            //VIRTUAL
        }

        public virtual void editarGrilla(int valor)
        {
            //VIRTUAL
        }

        public virtual void eliminarGrilla(int valor)
        {
            //VIRTUAL
        }

        public virtual void Agregar_Click(object sender, EventArgs e)
        {
            //VIRTUAL
        }

        private void dgGrilla_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgGrilla.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                //DataGridViewButtonCell celBoton = this.dgGrilla.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\editar.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 8, e.CellBounds.Top + 8);

                this.dgGrilla.Rows[e.RowIndex].Height = icoAtomico.Height + 16;
                this.dgGrilla.Columns[e.ColumnIndex].Width = icoAtomico.Width + 16;

                e.Handled = true;
            }
        }

        private void dgGrilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (this.dgGrilla.Columns[e.ColumnIndex].Name == "Editar")
                {
                    editarGrilla(Int32.Parse(dgGrilla.CurrentRow.Cells[this.abm.Clave].Value.ToString()));
                }
            }
        }

        private void dgGrilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editarGrilla(Int32.Parse(dgGrilla.CurrentRow.Cells[this.abm.Clave].Value.ToString()));
        }

        private void Filtrar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                aplicarFiltro();
            }
            else
            {
                if (this.txtBuscar.Text.Length > 0)
                {
                    this.btnLimpiar.Visible = true;
                }
                else
                {
                    this.btnLimpiar.Visible = false;
                }
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this.txtBuscar.Text = "";
            this.btnLimpiar.Visible = false;
            aplicarFiltro();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            editarGrilla(0);
        }
    }
}
