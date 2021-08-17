using IMComercios.Modelos.Entidades;
using IMComercios2.Controladores;
using IMComercios2.Modelos.Entidades;
using IMComercios2.Vistas.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using static IMComercios2.Vistas.Utiles.frmModal;

namespace IMComercios2
{
    public partial class Login : Form
    {

        conLogin log = new conLogin();
        entUsuario u1 = new entUsuario();

        public bool logueo;

        public Login()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void loguearUsuario()
        {
            //Para que se puedan usar los controles en el subproceso
            Control.CheckForIllegalCrossThreadCalls = false;

            u1.usuario = this.txtUsuario.Text;
            u1.clave = this.txtPassword.Text;

            var logear = log.Logear(u1);

            if ( logear != "0" && logear != "1" && logear != "2")            
            {
                Globales.token = logear;
                panError.BackColor = Color.MintCream;
                icoNoti.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                icoNoti.IconColor = Color.DarkGreen;
                icoNoti.BackColor = Color.MintCream;
                lblNoti.ForeColor = Color.DarkGreen;
                btnNoti.IconColor = Color.ForestGreen;
                btnNoti.ForeColor = Color.MintCream;
                lblNoti.Text = "Acceso correcto";
                lblNotiDetalle.Text = "Verificado y accediendo. Espere...";
                Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
                t.add(panError, "Top", 369);
                t.run();
                logueo = true;
                this.Hide();
            }
            else 
            {
                panError.BackColor = Color.MistyRose;
                icoNoti.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
                icoNoti.IconColor = Color.Crimson;
                icoNoti.BackColor = Color.MistyRose;
                lblNoti.ForeColor = Color.FromArgb(1, 200, 80, 80);

                if (logear == "0")
                {
                    lblNoti.Text = "Faltan datos";
                }

                if (logear == "1")
                {
                    lblNoti.Text = "Credenciales inválidas";
                }

                if (logear == "2")
                {
                    lblNoti.Text = "La API no esta corriendo";
                }

                lblNotiDetalle.Text = "Revise e intente de nuevo";
                btnNoti.IconColor = Color.Crimson;
                btnNoti.ForeColor = Color.MistyRose;
                Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
                t.add(panError, "Top", 369);
                t.run();
                panProcesando.Visible = false;
                logueo = false;
            }
        }

        private void abrirPrincipal()
        {
            Main main = new Main();
            main.Show();
        }

        private void btnNoti_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
            t.add(panError, "Top", 458);
            t.run();
            panProcesando.Visible = false;
        }

        public void leerDsn()
        {
            string fichero = "Gestion.dsn";

            try
            {
                using (StreamReader lector = new StreamReader(fichero))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            if (linea.IndexOf("Database") == 0)
                            {
                                string[] parametro = linea.Split('=');
                                entDsn.Database = parametro[1].Trim();
                            }
                            if (linea.IndexOf("HOST_ALTER_1") == 0)
                            {
                                string[] parametro = linea.Split('=');
                                entDsn.Server = parametro[1].Trim();
                            }
                            if (linea.IndexOf("PORT") == 0)
                            {
                                string[] parametro = linea.Split('=');
                                entDsn.Port = int.Parse(parametro[1].Trim());
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se puede leer el archivo DSN. Pro favor revise");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            leerDsn();
            prepararTxt();
        }

        private void prepararTxt()
        {
            //cbBase.Text = entDsn.Database;
            cbBase2.cbText.Text = entDsn.Database;
        }

        //static CancellationTokenSource token = new CancellationTokenSource();
        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            if (panError.Location.Y == 369)
            {
                panError.Top = 458;
            }

            panProcesando.Visible = true;
            await Task.Run(loguearUsuario/*, token.Token*/);
            if (logueo) abrirPrincipal();
        }

    }
}
