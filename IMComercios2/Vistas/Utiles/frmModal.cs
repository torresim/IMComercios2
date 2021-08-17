using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMComercios2.Vistas.Utiles
{
    public partial class frmModal : Form
    {
        public string tipoVentana = "Alerta";

        //sombra
        #region
        //------------------------------------------------------------------
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
            );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

        }
        #endregion

        public frmModal(Funciones.TipoVentana tipoventana,string mensaje)
        {
            m_aeroEnabled = false;

            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            this.lblMensaje.Text = mensaje;
            tipoVentana = tipoventana.ToString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int iParam);

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmModal_Load(object sender, EventArgs e)
        {
            this.Top = this.Top + 50;

            if (tipoVentana == "Alerta")
            {
                lblTitulo.Text = "ALERTA";
                icoModal.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                icoModal.IconColor = Color.Orange;
                btnAceptar.Visible = true;
                btnAceptar.Left = btnAceptar.Left - (btnAceptar.Width / 2) - 6;
            }

            if (tipoVentana == "Mensaje")
            {
                lblTitulo.Text = "MENSAJE";
                icoModal.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
                icoModal.IconColor = Color.DeepSkyBlue;
                btnAceptar.Visible = true;
                btnAceptar.Left = btnAceptar.Left - (btnAceptar.Width / 2) - 6;
            }

            if (tipoVentana == "Correcto")
            {
                lblTitulo.Text = "CORRECTO";
                icoModal.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                icoModal.IconFont = FontAwesome.Sharp.IconFont.Solid;
                icoModal.IconColor = Color.DeepSkyBlue;
                btnAceptar.Visible = true;
                btnAceptar.Left = btnAceptar.Left - (btnAceptar.Width / 2) - 6;
            }

            if (tipoVentana == "Error")
            {
                lblTitulo.Text = "ERROR";
                icoModal.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                icoModal.IconColor = Color.Crimson;
                btnAceptar.Visible = true;
                btnAceptar.Left = btnAceptar.Left - (btnAceptar.Width / 2) - 6;
            }

            if (tipoVentana == "Pregunta")
            {
                lblTitulo.Text = "PREGUNTA";
                icoModal.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
                icoModal.IconFont = FontAwesome.Sharp.IconFont.Solid;
                icoModal.IconColor = Color.DeepSkyBlue;
                btnAceptar.Visible = true;
                btnCancelar.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                timer1.Enabled = false;
            }
            else
            {
                this.Opacity = this.Opacity + 0.2;
                this.Top = this.Top - 4;
            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
