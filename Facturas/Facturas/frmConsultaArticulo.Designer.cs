namespace Facturas
{
    partial class frmConsultaArticulo
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.gbInfoArticulo = new System.Windows.Forms.GroupBox();
            this.gbInfoArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(28, 54);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(87, 18);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Descripción";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(28, 90);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(58, 18);
            this.lblMod.TabIndex = 1;
            this.lblMod.Text = "Modelo";
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Location = new System.Drawing.Point(28, 123);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(51, 18);
            this.lblPrec.TabIndex = 2;
            this.lblPrec.Text = "Precio";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(28, 155);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(127, 18);
            this.lblCant.TabIndex = 3;
            this.lblCant.Text = "Cantidad exixtente";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(174, 54);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(16, 18);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "1";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(174, 90);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(16, 18);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "2";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(174, 123);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(16, 18);
            this.Precio.TabIndex = 6;
            this.Precio.Text = "3";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(174, 155);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(16, 18);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "4";
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(32, 141);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(244, 26);
            this.cmbArticulos.TabIndex = 8;
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.Location = new System.Drawing.Point(39, 89);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(84, 20);
            this.lblArticulos.TabIndex = 9;
            this.lblArticulos.Text = "Articulos ";
            // 
            // gbInfoArticulo
            // 
            this.gbInfoArticulo.Controls.Add(this.lblDesc);
            this.gbInfoArticulo.Controls.Add(this.lblMod);
            this.gbInfoArticulo.Controls.Add(this.lblPrec);
            this.gbInfoArticulo.Controls.Add(this.lblCantidad);
            this.gbInfoArticulo.Controls.Add(this.lblCant);
            this.gbInfoArticulo.Controls.Add(this.Precio);
            this.gbInfoArticulo.Controls.Add(this.lblDescripcion);
            this.gbInfoArticulo.Controls.Add(this.lblModelo);
            this.gbInfoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoArticulo.Location = new System.Drawing.Point(282, 70);
            this.gbInfoArticulo.Name = "gbInfoArticulo";
            this.gbInfoArticulo.Size = new System.Drawing.Size(418, 222);
            this.gbInfoArticulo.TabIndex = 10;
            this.gbInfoArticulo.TabStop = false;
            this.gbInfoArticulo.Text = "Información Articulo";
            // 
            // frmConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 337);
            this.Controls.Add(this.gbInfoArticulo);
            this.Controls.Add(this.lblArticulos);
            this.Controls.Add(this.cmbArticulos);
            this.Name = "frmConsultaArticulo";
            this.Text = "Consulta Articulo";
            this.gbInfoArticulo.ResumeLayout(false);
            this.gbInfoArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.GroupBox gbInfoArticulo;
    }
}