namespace Facturas
{
    partial class frmInformacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacion));
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbImagen1 = new System.Windows.Forms.PictureBox();
            this.pbImagen2 = new System.Windows.Forms.PictureBox();
            this.pbImagen3 = new System.Windows.Forms.PictureBox();
            this.tooltInformacion = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Lavender;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(257, 239);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 30);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.tooltInformacion.SetToolTip(this.btnSalir, "Regresar");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbImagen1
            // 
            this.pbImagen1.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen1.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen1.Image")));
            this.pbImagen1.Location = new System.Drawing.Point(399, 29);
            this.pbImagen1.Name = "pbImagen1";
            this.pbImagen1.Size = new System.Drawing.Size(185, 176);
            this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen1.TabIndex = 1;
            this.pbImagen1.TabStop = false;
            this.tooltInformacion.SetToolTip(this.pbImagen1, "Joel Reyes Rivera");
            // 
            // pbImagen2
            // 
            this.pbImagen2.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen2.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen2.Image")));
            this.pbImagen2.Location = new System.Drawing.Point(232, 29);
            this.pbImagen2.Name = "pbImagen2";
            this.pbImagen2.Size = new System.Drawing.Size(144, 197);
            this.pbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen2.TabIndex = 2;
            this.pbImagen2.TabStop = false;
            this.tooltInformacion.SetToolTip(this.pbImagen2, "María Cristina Beltrán Angulo");
            // 
            // pbImagen3
            // 
            this.pbImagen3.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen3.Image")));
            this.pbImagen3.Location = new System.Drawing.Point(12, 29);
            this.pbImagen3.Name = "pbImagen3";
            this.pbImagen3.Size = new System.Drawing.Size(185, 176);
            this.pbImagen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen3.TabIndex = 3;
            this.pbImagen3.TabStop = false;
            this.tooltInformacion.SetToolTip(this.pbImagen3, "Endhir Fernando Abitia Rojo");
            // 
            // frmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(597, 281);
            this.ControlBox = false;
            this.Controls.Add(this.pbImagen3);
            this.Controls.Add(this.pbImagen2);
            this.Controls.Add(this.pbImagen1);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbImagen1;
        private System.Windows.Forms.PictureBox pbImagen2;
        private System.Windows.Forms.PictureBox pbImagen3;
        private System.Windows.Forms.ToolTip tooltInformacion;
    }
}