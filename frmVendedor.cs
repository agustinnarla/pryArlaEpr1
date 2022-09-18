using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaEPR
{
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void nupActivo_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void nupComision_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            //declaraciones de variables 
            int activo, comision;
            int codigoID = 100;
            string vendedor;
            vendedor = txtNombreVendedor.Text;
            activo = Convert.ToInt32(nupActivo.Text);
            comision = Convert.ToInt32(nupComision.Text);
            //confirmamos que no este en vacio 
            if ( vendedor != "")
            {
                if (File.Exists("./Vendedores.txt"))
                {
                    char separador = Convert.ToChar(",");
                    //leemos el texto
                    StreamReader srVendedores = new StreamReader("./Vendedores.txt");
                    //distinto de final a archivo 
                    while (!srVendedores.EndOfStream)
                    {
                        string[] vecVendedores = srVendedores.ReadLine().Split(separador);
                        int codigoVec = Convert.ToInt32(vecVendedores[1]);
                        codigoID = codigoVec + 1;
                     
                    }
                    srVendedores.Close();
                }
                    StreamWriter swVendedores = File.AppendText("./Vendedores.txt");
                    swVendedores.WriteLine(vendedor + "," + codigoID + "," + activo + "," + comision);
                    MessageBox.Show("Carga Realizada");
                    txtNombreVendedor.Text = "";
                    nupActivo.Value = 0;
                    nupComision.Value = 0;
                    swVendedores.Close();
            }
            else
            {
                MessageBox.Show("Complete con los datos, por favor ");

            }
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Vendedores.txt");
            MessageBox.Show("Archivo Eliminado");
        }
    }
}
