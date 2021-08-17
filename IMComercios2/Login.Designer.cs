
namespace IMComercios2
{
    partial class Login
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNoti = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.icoNoti = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBase2 = new IMComercios2.Vistas.Utiles.ctrlCombo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnEntrar = new FontAwesome.Sharp.IconButton();
            this.panError = new System.Windows.Forms.Panel();
            this.lblNotiDetalle = new System.Windows.Forms.Label();
            this.lblNoti = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panProcesando = new System.Windows.Forms.Panel();
            this.lblProcesando = new System.Windows.Forms.TextBox();
            this.picProcesando = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoNoti)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panProcesando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcesando)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(0, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Credenciales inválidas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.btnNoti);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(5, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 85);
            this.panel3.TabIndex = 18;
            // 
            // btnNoti
            // 
            this.btnNoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNoti.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnNoti.IconColor = System.Drawing.Color.ForestGreen;
            this.btnNoti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNoti.IconSize = 15;
            this.btnNoti.Location = new System.Drawing.Point(278, 2);
            this.btnNoti.Name = "btnNoti";
            this.btnNoti.Size = new System.Drawing.Size(25, 25);
            this.btnNoti.TabIndex = 16;
            this.btnNoti.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(0, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Por favor revise e intente de nuevo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icoNoti
            // 
            this.icoNoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.icoNoti.ForeColor = System.Drawing.Color.Crimson;
            this.icoNoti.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.icoNoti.IconColor = System.Drawing.Color.Crimson;
            this.icoNoti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoNoti.IconSize = 37;
            this.icoNoti.Location = new System.Drawing.Point(136, 3);
            this.icoNoti.Name = "icoNoti";
            this.icoNoti.Size = new System.Drawing.Size(40, 37);
            this.icoNoti.TabIndex = 15;
            this.icoNoti.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(129, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panProcesando);
            this.panel1.Controls.Add(this.cbBase2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.panError);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(150)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 454);
            this.panel1.TabIndex = 17;
            // 
            // cbBase2
            // 
            this.cbBase2.BackColor = System.Drawing.Color.Transparent;
            this.cbBase2.Enabled = false;
            this.cbBase2.Location = new System.Drawing.Point(29, 247);
            this.cbBase2.Name = "cbBase2";
            this.cbBase2.Size = new System.Drawing.Size(254, 22);
            this.cbBase2.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 26);
            this.panel2.TabIndex = 17;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titulo_MouseDown);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(150)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(271, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(29, 23);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(150)))));
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(100)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.IconChar = FontAwesome.Sharp.IconChar.Wpexplorer;
            this.btnEntrar.IconColor = System.Drawing.Color.White;
            this.btnEntrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEntrar.IconSize = 36;
            this.btnEntrar.Location = new System.Drawing.Point(31, 301);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(253, 38);
            this.btnEntrar.TabIndex = 16;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // panError
            // 
            this.panError.BackColor = System.Drawing.Color.MistyRose;
            this.panError.Controls.Add(this.icoNoti);
            this.panError.Controls.Add(this.lblNotiDetalle);
            this.panError.Controls.Add(this.lblNoti);
            this.panError.Location = new System.Drawing.Point(0, 458);
            this.panError.Name = "panError";
            this.panError.Size = new System.Drawing.Size(312, 85);
            this.panError.TabIndex = 15;
            // 
            // lblNotiDetalle
            // 
            this.lblNotiDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotiDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotiDetalle.ForeColor = System.Drawing.Color.Gray;
            this.lblNotiDetalle.Location = new System.Drawing.Point(3, 56);
            this.lblNotiDetalle.Name = "lblNotiDetalle";
            this.lblNotiDetalle.Size = new System.Drawing.Size(306, 20);
            this.lblNotiDetalle.TabIndex = 2;
            this.lblNotiDetalle.Text = "Por favor revise e intente de nuevo";
            this.lblNotiDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoti
            // 
            this.lblNoti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNoti.Location = new System.Drawing.Point(3, 36);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(306, 23);
            this.lblNoti.TabIndex = 0;
            this.lblNoti.Text = "Credenciales inválidas";
            this.lblNoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(29, 363);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 66);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Si presenta inconvenientes para ingresar por favor comuniquese con Infomanager al" +
    " (0381) 4301040";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BASE DE DATOS";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(29, 200);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(253, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "123";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(29, 155);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.Size = new System.Drawing.Size(253, 22);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMComercios2.Properties.Resources.imLogo4;
            this.pictureBox1.Location = new System.Drawing.Point(29, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panProcesando
            // 
            this.panProcesando.Controls.Add(this.lblProcesando);
            this.panProcesando.Controls.Add(this.picProcesando);
            this.panProcesando.Location = new System.Drawing.Point(25, 140);
            this.panProcesando.Margin = new System.Windows.Forms.Padding(2);
            this.panProcesando.Name = "panProcesando";
            this.panProcesando.Size = new System.Drawing.Size(259, 202);
            this.panProcesando.TabIndex = 14;
            this.panProcesando.Visible = false;
            // 
            // lblProcesando
            // 
            this.lblProcesando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProcesando.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProcesando.Enabled = false;
            this.lblProcesando.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesando.ForeColor = System.Drawing.Color.Transparent;
            this.lblProcesando.Location = new System.Drawing.Point(3, 110);
            this.lblProcesando.Multiline = true;
            this.lblProcesando.Name = "lblProcesando";
            this.lblProcesando.Size = new System.Drawing.Size(253, 20);
            this.lblProcesando.TabIndex = 15;
            this.lblProcesando.Text = "Ingresando...";
            this.lblProcesando.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picProcesando
            // 
            this.picProcesando.Image = global::IMComercios2.Properties.Resources.unnamed1;
            this.picProcesando.Location = new System.Drawing.Point(3, 53);
            this.picProcesando.Margin = new System.Windows.Forms.Padding(2);
            this.picProcesando.Name = "picProcesando";
            this.picProcesando.Size = new System.Drawing.Size(251, 52);
            this.picProcesando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProcesando.TabIndex = 13;
            this.picProcesando.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(314, 456);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoNoti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panProcesando.ResumeLayout(false);
            this.panProcesando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcesando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnNoti;
        private FontAwesome.Sharp.IconPictureBox icoNoti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panProcesando;
        private System.Windows.Forms.TextBox lblProcesando;
        private System.Windows.Forms.PictureBox picProcesando;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnEntrar;
        private System.Windows.Forms.Panel panError;
        private System.Windows.Forms.Label lblNotiDetalle;
        private System.Windows.Forms.Label lblNoti;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Vistas.Utiles.ctrlCombo cbBase2;
    }
}