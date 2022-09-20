using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryArlaEPR
{
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (File.Exists("./Clientes.txt"))
            {
                char separador = Convert.ToChar(",");
                StreamReader srConsultaCliente = new StreamReader("./Clientes.txt");
                while (!srConsultaCliente.EndOfStream)
                {
                    string[] vecConsultaCliente = srConsultaCliente.ReadLine().Split(separador);
                    grlCliente.Rows.Add(vecConsultaCliente);
                    cmdConsultar.Enabled = false;
                    
                }
                srConsultaCliente.Close();
            }
            else
            {
                MessageBox.Show("Porfavor, primero registre los datos.");
            }
        }
    }
}
