namespace pryArlaEPR
{
    partial class frmVendedor
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
            this.mtxtVendedor = new System.Windows.Forms.MaskedTextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblCobraComsion = new System.Windows.Forms.Label();
            this.nupComision = new System.Windows.Forms.NumericUpDown();
            this.nupActivo = new System.Windows.Forms.NumericUpDown();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.mrcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupComision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.mtxtVendedor);
            this.mrcDatos.Controls.Add(this.lblActivo);
            this.mrcDatos.Controls.Add(this.lblCobraComsion);
            this.mrcDatos.Controls.Add(this.nupComision);
            this.mrcDatos.Controls.Add(this.nupActivo);
            this.mrcDatos.Controls.Add(this.cmdCargar);
            this.mrcDatos.Controls.Add(this.txtNombreVendedor);
            this.mrcDatos.Controls.Add(this.lblNombreVendedor);
            this.mrcDatos.Controls.Add(this.lblVendedor);
            this.mrcDatos.Location = new System.Drawing.Point(12, 8);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(277, 173);
            this.mrcDatos.TabIndex = 5;
            this.mrcDatos.TabStop = false;
            // 
            // mtxtVendedor
            // 
            this.mtxtVendedor.Location = new System.Drawing.Point(129, 23);
            this.mtxtVendedor.Mask = "0000000000000000000";
            this.mtxtVendedor.Name = "mtxtVendedor";
            this.mtxtVendedor.Size = new System.Drawing.Size(142, 20);
            this.mtxtVendedor.TabIndex = 9;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(14, 93);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(37, 13);
            this.lblActivo.TabIndex = 8;
            this.lblActivo.Text = "Activo";
            // 
            // lblCobraComsion
            // 
            this.lblCobraComsion.AutoSize = true;
            this.lblCobraComsion.Location = new System.Drawing.Point(14, 122);
            this.lblCobraComsion.Name = "lblCobraComsion";
            this.lblCobraComsion.Size = new System.Drawing.Size(80, 13);
            this.lblCobraComsion.TabIndex = 7;
            this.lblCobraComsion.Text = "Cobra Comision";
            // 
            // nupComision
            // 
            this.nupComision.Location = new System.Drawing.Point(129, 115);
            this.nupComision.Name = "nupComision";
            this.nupComision.Size = new System.Drawing.Size(142, 20);
            this.nupComision.TabIndex = 6;
            this.nupComision.ValueChanged += new System.EventHandler(this.nupComision_ValueChanged);
            // 
            // nupActivo
            // 
            this.nupActivo.Location = new System.Drawing.Point(129, 86);
            this.nupActivo.Name = "nupActivo";
            this.nupActivo.Size = new System.Drawing.Size(142, 20);
            this.nupActivo.TabIndex = 5;
            this.nupActivo.ValueChanged += new System.EventHandler(this.nupActivo_ValueChanged);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(160, 141);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(111, 23);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(129, 57);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(142, 20);
            this.txtNombreVendedor.TabIndex = 3;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(14, 58);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(110, 13);
            this.lblNombreVendedor.TabIndex = 1;
            this.lblNombreVendedor.Text = "Nombre del Vendedor";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(14, 26);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 0;
            this.lblVendedor.Text = "Vendedor";
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 193);
            this.Controls.Add(this.mrcDatos);
            this.Name = "frmVendedor";
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupComision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblCobraComsion;
        private System.Windows.Forms.NumericUpDown nupComision;
        private System.Windows.Forms.NumericUpDown nupActivo;
        private System.Windows.Forms.MaskedTextBox mtxtVendedor;
    }
}