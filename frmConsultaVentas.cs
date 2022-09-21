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
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (File.Exists("./Ventas.txt"))
            {
                char separador = Convert.ToChar(";");
                StreamReader srConsultaVentas = new StreamReader("./Ventas.txt");
                while (!srConsultaVentas.EndOfStream)
                {
                    string[] vecConsultaVentas = srConsultaVentas.ReadLine().Split(separador);
                    grlVentas.Rows.Add(vecConsultaVentas);
                    cmdConsultar.Enabled = false;

                }
                srConsultaVentas.Close();
            }
            else
            {
                MessageBox.Show("Porfavor, primero registre los datos.");
            }
        }
    }
}
