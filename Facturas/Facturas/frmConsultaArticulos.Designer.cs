namespace Facturas
{
    partial class frmConsultaArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaArticulos));
            this.dgwArticulos = new System.Windows.Forms.DataGridView();
            this.toolTipMostrar = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbArtiulos = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtiulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwArticulos
            // 
            this.dgwArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgwArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgwArticulos.GridColor = System.Drawing.Color.DimGray;
            this.dgwArticulos.Location = new System.Drawing.Point(30, 95);
            this.dgwArticulos.Name = "dgwArticulos";
            this.dgwArticulos.ReadOnly = true;
            this.dgwArticulos.Size = new System.Drawing.Size(544, 166);
            this.dgwArticulos.TabIndex = 0;
            this.toolTipMostrar.SetToolTip(this.dgwArticulos, "Catalogo de Articulos");
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(454, 281);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 39);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.toolTipMostrar.SetToolTip(this.btnSalir, "Salir de la ventana");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(152, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CATALOGO DE ARTICULOS";
            // 
            // pbArtiulos
            // 
            this.pbArtiulos.BackColor = System.Drawing.Color.Transparent;
            this.pbArtiulos.Image = ((System.Drawing.Image)(resources.GetObject("pbArtiulos.Image")));
            this.pbArtiulos.Location = new System.Drawing.Point(435, 12);
            this.pbArtiulos.Name = "pbArtiulos";
            this.pbArtiulos.Size = new System.Drawing.Size(74, 63);
            this.pbArtiulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArtiulos.TabIndex = 1;
            this.pbArtiulos.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Clave del Articulo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad en Exitencia";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmConsultaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 332);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbArtiulos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgwArticulos);
            this.Name = "frmConsultaArticulos";
            this.Text = "Consulta todos los  Articulos";
            this.Load += new System.EventHandler(this.frmConsultaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtiulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwArticulos;
        private System.Windows.Forms.ToolTip toolTipMostrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbArtiulos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}