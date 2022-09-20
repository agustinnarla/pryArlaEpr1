namespace pryArlaEPR
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.cmdVentas = new System.Windows.Forms.Button();
            this.cmdVendedor = new System.Windows.Forms.Button();
            this.cmdCliente = new System.Windows.Forms.Button();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.cmdVentasConsultas = new System.Windows.Forms.Button();
            this.cmdVendedorConsulta = new System.Windows.Forms.Button();
            this.cmdClienteConsulta = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabRegistrar);
            this.tabMenu.Controls.Add(this.tabConsultar);
            this.tabMenu.Location = new System.Drawing.Point(29, 3);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(166, 226);
            this.tabMenu.TabIndex = 0;
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Controls.Add(this.cmdVentas);
            this.tabRegistrar.Controls.Add(this.cmdVendedor);
            this.tabRegistrar.Controls.Add(this.cmdCliente);
            this.tabRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(158, 200);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // cmdVentas
            // 
            this.cmdVentas.Location = new System.Drawing.Point(32, 136);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(94, 46);
            this.cmdVentas.TabIndex = 2;
            this.cmdVentas.Text = "Ventas";
            this.cmdVentas.UseVisualStyleBackColor = true;
            this.cmdVentas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // cmdVendedor
            // 
            this.cmdVendedor.Location = new System.Drawing.Point(32, 74);
            this.cmdVendedor.Name = "cmdVendedor";
            this.cmdVendedor.Size = new System.Drawing.Size(94, 46);
            this.cmdVendedor.TabIndex = 1;
            this.cmdVendedor.Text = "Vendedor";
            this.cmdVendedor.UseVisualStyleBackColor = true;
            this.cmdVendedor.Click += new System.EventHandler(this.cmdVendedor_Click);
            // 
            // cmdCliente
            // 
            this.cmdCliente.Location = new System.Drawing.Point(32, 12);
            this.cmdCliente.Name = "cmdCliente";
            this.cmdCliente.Size = new System.Drawing.Size(94, 46);
            this.cmdCliente.TabIndex = 0;
            this.cmdCliente.Text = "Cliente";
            this.cmdCliente.UseVisualStyleBackColor = true;
            this.cmdCliente.Click += new System.EventHandler(this.cmdCliente_Click);
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.cmdVentasConsultas);
            this.tabConsultar.Controls.Add(this.cmdVendedorConsulta);
            this.tabConsultar.Controls.Add(this.cmdClienteConsulta);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(158, 200);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // cmdVentasConsultas
            // 
            this.cmdVentasConsultas.Location = new System.Drawing.Point(32, 139);
            this.cmdVentasConsultas.Name = "cmdVentasConsultas";
            this.cmdVentasConsultas.Size = new System.Drawing.Size(94, 46);
            this.cmdVentasConsultas.TabIndex = 5;
            this.cmdVentasConsultas.Text = "Ventas";
            this.cmdVentasConsultas.UseVisualStyleBackColor = true;
            this.cmdVentasConsultas.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdVendedorConsulta
            // 
            this.cmdVendedorConsulta.Location = new System.Drawing.Point(32, 77);
            this.cmdVendedorConsulta.Name = "cmdVendedorConsulta";
            this.cmdVendedorConsulta.Size = new System.Drawing.Size(94, 46);
            this.cmdVendedorConsulta.TabIndex = 4;
            this.cmdVendedorConsulta.Text = "Vendedor";
            this.cmdVendedorConsulta.UseVisualStyleBackColor = true;
            this.cmdVendedorConsulta.Click += new System.EventHandler(this.cmdVendedorConsulta_Click);
            // 
            // cmdClienteConsulta
            // 
            this.cmdClienteConsulta.Location = new System.Drawing.Point(32, 15);
            this.cmdClienteConsulta.Name = "cmdClienteConsulta";
            this.cmdClienteConsulta.Size = new System.Drawing.Size(94, 46);
            this.cmdClienteConsulta.TabIndex = 3;
            this.cmdClienteConsulta.Text = "Cliente";
            this.cmdClienteConsulta.UseVisualStyleBackColor = true;
            this.cmdClienteConsulta.Click += new System.EventHandler(this.cmdClienteConsulta_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(216, 234);
            this.Controls.Add(this.tabMenu);
            this.Name = "frmPrincipal";
            this.Text = "VenKaktus ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabRegistrar.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Button cmdVendedor;
        private System.Windows.Forms.Button cmdCliente;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.Button cmdVentasConsultas;
        private System.Windows.Forms.Button cmdVendedorConsulta;
        private System.Windows.Forms.Button cmdClienteConsulta;
    }
}

