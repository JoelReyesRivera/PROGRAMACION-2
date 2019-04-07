namespace Facturas
{
    partial class frmModificaExistenciaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificaExistenciaArticulo));
            this.lblArticulos = new System.Windows.Forms.Label();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolTipMostrar = new System.Windows.Forms.ToolTip(this.components);
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbImagen1 = new System.Windows.Forms.PictureBox();
            this.gpArticulo = new System.Windows.Forms.GroupBox();
            this.pbImagen2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
            this.gpArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.Location = new System.Drawing.Point(6, 46);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(59, 16);
            this.lblArticulos.TabIndex = 0;
            this.lblArticulos.Text = "Articulos";
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Items.AddRange(new object[] {
            "-SELECCIONE UN ARTICULO-"});
            this.cmbArticulos.Location = new System.Drawing.Point(6, 67);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(220, 24);
            this.cmbArticulos.TabIndex = 1;
            this.toolTipMostrar.SetToolTip(this.cmbArticulos, "Catalogo de Articulos");
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(9, 131);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.ReadOnly = true;
            this.nudCantidad.Size = new System.Drawing.Size(81, 22);
            this.nudCantidad.TabIndex = 2;
            this.toolTipMostrar.SetToolTip(this.nudCantidad, "Seleccione Cantidad de Articulos ");
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 112);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(135, 16);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad de Articulos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(20, 289);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 37);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.toolTipMostrar.SetToolTip(this.btnGuardar, "Guardar datos");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(168, 289);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 37);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.toolTipMostrar.SetToolTip(this.btnLimpiar, "Limpiar ventana");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(328, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 37);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.toolTipMostrar.SetToolTip(this.btnSalir, "Salir de la ventana");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(47, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(343, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MODIFICA EXISTENCIA ARTICULO";
            // 
            // pbImagen1
            // 
            this.pbImagen1.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen1.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen1.Image")));
            this.pbImagen1.Location = new System.Drawing.Point(309, 116);
            this.pbImagen1.Name = "pbImagen1";
            this.pbImagen1.Size = new System.Drawing.Size(128, 119);
            this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen1.TabIndex = 7;
            this.pbImagen1.TabStop = false;
            // 
            // gpArticulo
            // 
            this.gpArticulo.BackColor = System.Drawing.Color.Transparent;
            this.gpArticulo.Controls.Add(this.lblArticulos);
            this.gpArticulo.Controls.Add(this.cmbArticulos);
            this.gpArticulo.Controls.Add(this.lblCantidad);
            this.gpArticulo.Controls.Add(this.nudCantidad);
            this.gpArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpArticulo.Location = new System.Drawing.Point(24, 82);
            this.gpArticulo.Name = "gpArticulo";
            this.gpArticulo.Size = new System.Drawing.Size(258, 176);
            this.gpArticulo.TabIndex = 0;
            this.gpArticulo.TabStop = false;
            this.gpArticulo.Text = "Agrega en exitencia";
            // 
            // pbImagen2
            // 
            this.pbImagen2.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen2.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen2.Image")));
            this.pbImagen2.Location = new System.Drawing.Point(406, 22);
            this.pbImagen2.Name = "pbImagen2";
            this.pbImagen2.Size = new System.Drawing.Size(42, 33);
            this.pbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen2.TabIndex = 8;
            this.pbImagen2.TabStop = false;
            // 
            // frmModificaExistenciaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(469, 354);
            this.ControlBox = false;
            this.Controls.Add(this.pbImagen2);
            this.Controls.Add(this.gpArticulo);
            this.Controls.Add(this.pbImagen1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmModificaExistenciaArticulo";
            this.Text = "Modifica la Existencia de un Articulo";
            this.Load += new System.EventHandler(this.frmModificaExistenciaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
            this.gpArticulo.ResumeLayout(false);
            this.gpArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTipMostrar;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.PictureBox pbImagen1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpArticulo;
        private System.Windows.Forms.PictureBox pbImagen2;
    }
}