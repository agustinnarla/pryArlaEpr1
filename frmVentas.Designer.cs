namespace pryArlaEPR
{
    partial class frmVentas
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
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.lstVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lstCliente = new System.Windows.Forms.ComboBox();
            this.ftpFecha = new System.Windows.Forms.DateTimePicker();
            this.lstFactura = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblFactura = new System.Windows.Forms.Label();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.txtMonto);
            this.mrcDatos.Controls.Add(this.cmdBorrar);
            this.mrcDatos.Controls.Add(this.lstVendedor);
            this.mrcDatos.Controls.Add(this.lblVendedor);
            this.mrcDatos.Controls.Add(this.lblMonto);
            this.mrcDatos.Controls.Add(this.lstCliente);
            this.mrcDatos.Controls.Add(this.ftpFecha);
            this.mrcDatos.Controls.Add(this.lstFactura);
            this.mrcDatos.Controls.Add(this.lblFecha);
            this.mrcDatos.Controls.Add(this.lblCliente);
            this.mrcDatos.Controls.Add(this.cmdCargar);
            this.mrcDatos.Controls.Add(this.lblFactura);
            this.mrcDatos.Location = new System.Drawing.Point(6, 3);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(349, 201);
            this.mrcDatos.TabIndex = 6;
            this.mrcDatos.TabStop = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(129, 145);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(80, 20);
            this.txtMonto.TabIndex = 19;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(171, 171);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(83, 21);
            this.cmdBorrar.TabIndex = 18;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // lstVendedor
            // 
            this.lstVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVendedor.FormattingEnabled = true;
            this.lstVendedor.Location = new System.Drawing.Point(127, 112);
            this.lstVendedor.Name = "lstVendedor";
            this.lstVendedor.Size = new System.Drawing.Size(83, 21);
            this.lstVendedor.TabIndex = 17;
            this.lstVendedor.SelectedIndexChanged += new System.EventHandler(this.lstVendedor_SelectedIndexChanged);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(14, 118);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 14;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(14, 149);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 13;
            this.lblMonto.Text = "Monto";
            // 
            // lstCliente
            // 
            this.lstCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(127, 80);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(83, 21);
            this.lstCliente.TabIndex = 12;
            this.lstCliente.SelectedIndexChanged += new System.EventHandler(this.lstCliente_SelectedIndexChanged);
            // 
            // ftpFecha
            // 
            this.ftpFecha.Location = new System.Drawing.Point(127, 49);
            this.ftpFecha.Name = "ftpFecha";
            this.ftpFecha.Size = new System.Drawing.Size(211, 20);
            this.ftpFecha.TabIndex = 11;
            // 
            // lstFactura
            // 
            this.lstFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstFactura.FormattingEnabled = true;
            this.lstFactura.Items.AddRange(new object[] {
            "Factura A",
            "Factura B",
            "Factura C",
            "Factura M",
            "Factura E",
            "Factura T",
            ""});
            this.lstFactura.Location = new System.Drawing.Point(127, 17);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(83, 21);
            this.lstFactura.TabIndex = 9;
            this.lstFactura.SelectedIndexChanged += new System.EventHandler(this.lstFactura_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(14, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(14, 87);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(260, 171);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(83, 21);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(14, 25);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(43, 13);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 205);
            this.Controls.Add(this.mrcDatos);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.ComboBox lstFactura;
        private System.Windows.Forms.DateTimePicker ftpFecha;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox lstVendedor;
        public System.Windows.Forms.ComboBox lstCliente;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.TextBox txtMonto;
    }
}