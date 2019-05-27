namespace Facturas
{
    partial class frmConsultaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProveedores));
            this.lblProvedores = new System.Windows.Forms.Label();
            this.dtgvProveedores = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbProveedor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProvedores
            // 
            this.lblProvedores.AutoSize = true;
            this.lblProvedores.BackColor = System.Drawing.Color.Transparent;
            this.lblProvedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvedores.ForeColor = System.Drawing.Color.Black;
            this.lblProvedores.Location = new System.Drawing.Point(50, 36);
            this.lblProvedores.Name = "lblProvedores";
            this.lblProvedores.Size = new System.Drawing.Size(460, 33);
            this.lblProvedores.TabIndex = 0;
            this.lblProvedores.Text = "PROVEDORES REGISTRADOS";
            // 
            // dtgvProveedores
            // 
            this.dtgvProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dtgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.RFC,
            this.Nombre,
            this.Domicilio,
            this.Saldo});
            this.dtgvProveedores.Location = new System.Drawing.Point(38, 92);
            this.dtgvProveedores.Name = "dtgvProveedores";
            this.dtgvProveedores.ReadOnly = true;
            this.dtgvProveedores.Size = new System.Drawing.Size(541, 150);
            this.dtgvProveedores.TabIndex = 0;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(516, 275);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbProveedor
            // 
            this.pbProveedor.BackColor = System.Drawing.Color.Transparent;
            this.pbProveedor.Image = ((System.Drawing.Image)(resources.GetObject("pbProveedor.Image")));
            this.pbProveedor.Location = new System.Drawing.Point(516, 12);
            this.pbProveedor.Name = "pbProveedor";
            this.pbProveedor.Size = new System.Drawing.Size(76, 74);
            this.pbProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProveedor.TabIndex = 2;
            this.pbProveedor.TabStop = false;
            // 
            // frmConsultaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 319);
            this.ControlBox = false;
            this.Controls.Add(this.pbProveedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblProvedores);
            this.Controls.Add(this.dtgvProveedores);
            this.Name = "frmConsultaProveedores";
            this.Text = "Consulta Proveedores";
            this.Load += new System.EventHandler(this.frmConsultaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProvedores;
        private System.Windows.Forms.DataGridView dtgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbProveedor;
    }
}