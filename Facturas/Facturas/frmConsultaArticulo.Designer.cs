﻿namespace Facturas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaArticulo));
            this.lblArticulos = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.gbInfoArticulo = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.toolTipMostrar = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbInfoArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.Location = new System.Drawing.Point(14, 59);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(149, 18);
            this.lblArticulos.TabIndex = 0;
            this.lblArticulos.Text = "Catalogo de Articulos";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(15, 42);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(87, 18);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Descripción";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(15, 80);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(58, 18);
            this.lblMod.TabIndex = 0;
            this.lblMod.Text = "Modelo";
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Location = new System.Drawing.Point(15, 113);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(51, 18);
            this.lblPrec.TabIndex = 0;
            this.lblPrec.Text = "Precio";
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Items.AddRange(new object[] {
            "-SELECCIONE UN ARTICULO-"});
            this.cmbArticulos.Location = new System.Drawing.Point(15, 82);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(242, 26);
            this.cmbArticulos.TabIndex = 1;
            this.toolTipMostrar.SetToolTip(this.cmbArticulos, "Catalogo de Articulos");
            this.cmbArticulos.SelectedIndexChanged += new System.EventHandler(this.cmbArticulos_SelectedIndexChanged);
            // 
            // gbInfoArticulo
            // 
            this.gbInfoArticulo.BackColor = System.Drawing.Color.White;
            this.gbInfoArticulo.Controls.Add(this.pictureBox2);
            this.gbInfoArticulo.Controls.Add(this.lblCantidad);
            this.gbInfoArticulo.Controls.Add(this.lblPrecio);
            this.gbInfoArticulo.Controls.Add(this.lblModelo);
            this.gbInfoArticulo.Controls.Add(this.lblDescripcion);
            this.gbInfoArticulo.Controls.Add(this.lblCant);
            this.gbInfoArticulo.Controls.Add(this.lblDesc);
            this.gbInfoArticulo.Controls.Add(this.lblMod);
            this.gbInfoArticulo.Controls.Add(this.lblPrec);
            this.gbInfoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoArticulo.Location = new System.Drawing.Point(267, 63);
            this.gbInfoArticulo.Name = "gbInfoArticulo";
            this.gbInfoArticulo.Size = new System.Drawing.Size(421, 199);
            this.gbInfoArticulo.TabIndex = 0;
            this.gbInfoArticulo.TabStop = false;
            this.gbInfoArticulo.Text = "Información Articulo";
            this.toolTipMostrar.SetToolTip(this.gbInfoArticulo, "Información basica del Articulo");
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(164, 148);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 18);
            this.lblCantidad.TabIndex = 0;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(164, 113);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 18);
            this.lblPrecio.TabIndex = 0;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(164, 80);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(0, 18);
            this.lblModelo.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(164, 42);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 18);
            this.lblDescripcion.TabIndex = 0;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(15, 148);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(128, 18);
            this.lblCant.TabIndex = 0;
            this.lblCant.Text = "Cantidad existente";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(572, 275);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 32);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.toolTipMostrar.SetToolTip(this.btnSalir, "Salir de la ventana");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(240, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONSULTA ARTICULO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(356, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 321);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbInfoArticulo);
            this.Controls.Add(this.cmbArticulos);
            this.Controls.Add(this.lblArticulos);
            this.Name = "frmConsultaArticulo";
            this.Text = "Consulta Articulo";
            this.Load += new System.EventHandler(this.frmConsultaArticulo_Load);
            this.gbInfoArticulo.ResumeLayout(false);
            this.gbInfoArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.GroupBox gbInfoArticulo;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ToolTip toolTipMostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}