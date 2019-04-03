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
            this.lblProvedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvedores.ForeColor = System.Drawing.Color.Black;
            this.lblProvedores.Location = new System.Drawing.Point(144, 36);
            this.lblProvedores.Name = "lblProvedores";
            this.lblProvedores.Size = new System.Drawing.Size(303, 24);
            this.lblProvedores.TabIndex = 0;
            this.lblProvedores.Text = "PROVEDORES REGISTRADOS";
            // 
            // dtgvProveedores
            // 
            this.dtgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.RFC,
            this.Nombre,
            this.Domicilio,
            this.Saldo});
            this.dtgvProveedores.Location = new System.Drawing.Point(28, 106);
            this.dtgvProveedores.Name = "dtgvProveedores";
            this.dtgvProveedores.Size = new System.Drawing.Size(541, 150);
            this.dtgvProveedores.TabIndex = 0;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(502, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbProveedor
            // 
            this.pbProveedor.Image = ((System.Drawing.Image)(resources.GetObject("pbProveedor.Image")));
            this.pbProveedor.Location = new System.Drawing.Point(472, 12);
            this.pbProveedor.Name = "pbProveedor";
            this.pbProveedor.Size = new System.Drawing.Size(110, 74);
            this.pbProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProveedor.TabIndex = 2;
            this.pbProveedor.TabStop = false;
            // 
            // frmConsultaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 329);
            this.ControlBox = false;
            this.Controls.Add(this.pbProveedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblProvedores);
            this.Controls.Add(this.dtgvProveedores);
            this.Name = "frmConsultaProveedores";
            this.Text = "Consulta Proveedores";
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