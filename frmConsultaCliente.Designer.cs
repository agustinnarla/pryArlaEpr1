namespace pryArlaEPR
{
    partial class frmConsultaCliente
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
            this.grlCliente = new System.Windows.Forms.DataGridView();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_del_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grlCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grlCliente
            // 
            this.grlCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Nombre_del_Cliente});
            this.grlCliente.Location = new System.Drawing.Point(12, 12);
            this.grlCliente.Name = "grlCliente";
            this.grlCliente.Size = new System.Drawing.Size(413, 206);
            this.grlCliente.TabIndex = 0;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(362, 224);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(63, 25);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 50;
            // 
            // Nombre_del_Cliente
            // 
            this.Nombre_del_Cliente.HeaderText = "Nombre Del Cliente";
            this.Nombre_del_Cliente.Name = "Nombre_del_Cliente";
            this.Nombre_del_Cliente.Width = 200;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 259);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.grlCliente);
            this.Name = "frmConsultaCliente";
            this.Text = "Consulta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.grlCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlCliente;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_del_Cliente;
    }
}