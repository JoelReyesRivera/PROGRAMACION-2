namespace Facturas
{
    partial class frmReporteArticulos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteArticulos = new Facturas.ReporteArticulos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ArticuloTableAdapter = new Facturas.ReporteArticulosTableAdapters.ArticuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticuloBindingSource
            // 
            this.ArticuloBindingSource.DataMember = "Articulo";
            this.ArticuloBindingSource.DataSource = this.ReporteArticulos;
            // 
            // ReporteArticulos
            // 
            this.ReporteArticulos.DataSetName = "ReporteArticulos";
            this.ReporteArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Articulos";
            reportDataSource1.Value = this.ArticuloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Facturas.ReporteArticulo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ArticuloTableAdapter
            // 
            this.ArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmReporteArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Articulos";
            this.Load += new System.EventHandler(this.frmReporteArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArticuloBindingSource;
        private ReporteArticulos ReporteArticulos;
        private ReporteArticulosTableAdapters.ArticuloTableAdapter ArticuloTableAdapter;
    }
}