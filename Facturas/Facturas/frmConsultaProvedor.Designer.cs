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
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblConsultaProvedor = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblRFC = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(52, 110);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(80, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave Provedor";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(157, 107);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 1;
            // 
            // lblConsultaProvedor
            // 
            this.lblConsultaProvedor.AutoSize = true;
            this.lblConsultaProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaProvedor.Location = new System.Drawing.Point(46, 19);
            this.lblConsultaProvedor.Name = "lblConsultaProvedor";
            this.lblConsultaProvedor.Size = new System.Drawing.Size(239, 31);
            this.lblConsultaProvedor.TabIndex = 2;
            this.lblConsultaProvedor.Text = "Consulta Provedor";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(157, 176);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(100, 20);
            this.txtRFC.TabIndex = 4;
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(52, 179);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(28, 13);
            this.lblRFC.TabIndex = 3;
            this.lblRFC.Text = "RFC";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 244);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(52, 247);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(157, 307);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtDomicilio.TabIndex = 8;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(52, 310);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 7;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(157, 365);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 10;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(52, 368);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "Saldo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(297, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar Provedor";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Location = new System.Drawing.Point(52, 72);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(214, 13);
            this.lblAyuda.TabIndex = 12;
            this.lblAyuda.Text = "Ingrese la clave del provedor para consultar";
            // 
            // frmConsultaProvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 403);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.lblConsultaProvedor);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Name = "frmConsultaProvedor";
            this.Text = "Consultar Provedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblConsultaProvedor;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblAyuda;
    }
}