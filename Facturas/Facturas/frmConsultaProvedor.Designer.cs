namespace Facturas
{
    partial class frmConsultaProvedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProvedor));
            this.lblClave = new System.Windows.Forms.Label();
            this.lblConsultaProvedor = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(30, 172);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(45, 18);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // lblConsultaProvedor
            // 
            this.lblConsultaProvedor.AutoSize = true;
            this.lblConsultaProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaProvedor.Location = new System.Drawing.Point(128, 9);
            this.lblConsultaProvedor.Name = "lblConsultaProvedor";
            this.lblConsultaProvedor.Size = new System.Drawing.Size(255, 24);
            this.lblConsultaProvedor.TabIndex = 2;
            this.lblConsultaProvedor.Text = "CONSULTA PROVEEDOR";
            // 
            // txtRFC
            // 
            this.txtRFC.CausesValidation = false;
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.Location = new System.Drawing.Point(105, 115);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.ReadOnly = true;
            this.txtRFC.Size = new System.Drawing.Size(173, 20);
            this.txtRFC.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtRFC, "RFC del Proveedor");
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.Location = new System.Drawing.Point(30, 121);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(39, 18);
            this.lblRFC.TabIndex = 0;
            this.lblRFC.Text = "RFC";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(30, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CausesValidation = false;
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Location = new System.Drawing.Point(105, 224);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(189, 20);
            this.txtDomicilio.TabIndex = 0;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(30, 226);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(70, 18);
            this.lblDomicilio.TabIndex = 0;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(105, 276);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(121, 20);
            this.txtSueldo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtSueldo, "Saldo del proveedor");
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(30, 278);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(46, 18);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtClave
            // 
            this.txtClave.CausesValidation = false;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Location = new System.Drawing.Point(105, 170);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(121, 20);
            this.txtClave.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtClave, "Clave del Proveedor");
            // 
            // cmbNombre
            // 
            this.cmbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(105, 69);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(173, 21);
            this.cmbNombre.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbNombre, "Nombre del Proveedor");
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(330, 56);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(222, 223);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 14;
            this.pbImagen.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(408, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaProvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(564, 352);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.lblConsultaProvedor);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Name = "frmConsultaProvedor";
            this.Text = "Consultar Provedor";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblConsultaProvedor;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSalir;
    }
}