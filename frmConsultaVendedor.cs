using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaEPR
{
    public partial class frmConsultaVendedor : Form
    {
        public frmConsultaVendedor()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (File.Exists("./Vendedores.txt"))
            {
                char separador = Convert.ToChar(",");
                StreamReader srConsultaVendedores = new StreamReader("./Vendedores.txt");
                while (!srConsultaVendedores.EndOfStream)
                {
                    string[] vecConsultaVendedores = srConsultaVendedores.ReadLine().Split(separador);
                    grlVendedor.Rows.Add(vecConsultaVendedores);
                    cmdConsultar.Enabled = false;

                }
                srConsultaVendedores.Close();
            }
            else
            {
                MessageBox.Show("Porfavor, primero registre los datos.");
            }
        }
    }
}
