
namespace IMComercios2.Vistas.Utiles
{
    partial class ctrlVentana
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVantana = new System.Windows.Forms.Label();
            this.btnVisible = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAcoplable = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblVantana
            // 
            this.lblVantana.AutoSize = true;
            this.lblVantana.ForeColor = System.Drawing.Color.White;
            this.lblVantana.Location = new System.Drawing.Point(14, 8);
            this.lblVantana.Name = "lblVantana";
            this.lblVantana.Size = new System.Drawing.Size(84, 13);
            this.lblVantana.TabIndex = 1;
            this.lblVantana.Text = "NombreVentana";
            this.lblVantana.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.lblVantana.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // btnVisible
            // 
            this.btnVisible.FlatAppearance.BorderSize = 0;
            this.btnVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisible.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVisible.IconColor = System.Drawing.Color.White;
            this.btnVisible.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVisible.IconSize = 15;
            this.btnVisible.Location = new System.Drawing.Point(104, 6);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(20, 20);
            this.btnVisible.TabIndex = 4;
            this.btnVisible.Tag = "";
            this.toolTip1.SetToolTip(this.btnVisible, "Mostrar / Ocultar ventana");
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.iconButton1_Click);
            this.btnVisible.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.btnVisible.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // btnAcoplable
            // 
            this.btnAcoplable.FlatAppearance.BorderSize = 0;
            this.btnAcoplable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcoplable.IconChar = FontAwesome.Sharp.IconChar.Thumbtack;
            this.btnAcoplable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAcoplable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcoplable.IconSize = 15;
            this.btnAcoplable.Location = new System.Drawing.Point(122, 6);
            this.btnAcoplable.Name = "btnAcoplable";
            this.btnAcoplable.Size = new System.Drawing.Size(20, 20);
            this.btnAcoplable.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnAcoplable, "Acoplar ventana");
            this.btnAcoplable.UseVisualStyleBackColor = true;
            this.btnAcoplable.Click += new System.EventHandler(this.btnAcoplable_Click);
            this.btnAcoplable.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.btnAcoplable.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 15;
            this.iconButton3.Location = new System.Drawing.Point(140, 6);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(20, 20);
            this.iconButton3.TabIndex = 6;
            this.toolTip1.SetToolTip(this.iconButton3, "Cerrar ventana");
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            this.iconButton3.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.iconButton3.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // ctrlVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.btnAcoplable);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.lblVantana);
            this.Name = "ctrlVentana";
            this.Size = new System.Drawing.Size(163, 30);
            this.Tag = "t";
            this.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVantana;
        private FontAwesome.Sharp.IconButton btnVisible;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnAcoplable;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}
