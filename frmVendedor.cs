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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void nupActivo_ValueChanged(object sender, EventArgs e)
        {
            nupActivo.Maximum = 0;
            nupActivo.Minimum = -1;
        }

        private void nupComision_ValueChanged(object sender, EventArgs e)
        {
            nupComision.Maximum = 0;
            nupComision.Minimum = -1;
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            int codigo, activo, comision;
            string vendedor, mensaje;
            bool bandera = false;
            codigo = Convert.ToInt32(mtxtVendedor.Text);
            vendedor = txtNombreVendedor.Text;
            activo = Convert.ToInt32(nupActivo.Text);
            comision = Convert.ToInt32(nupComision.Text);

            if (codigo != 0 && vendedor != "")
            {
                mensaje = vendedor + "," + codigo + "," + activo + "," + comision;
                char separador = Convert.ToChar(",");
                StreamReader srVendedores = new StreamReader("./Vendedores.txt");
                while (!srVendedores.EndOfStream)
                {
                    string[] vecClientes = srVendedores.ReadLine().Split(separador);
                    int codigoVec = Convert.ToInt32(vecClientes[1]);
                    if (codigo == codigoVec)
                    {
                        bandera = true;
                        MessageBox.Show("Numero de vendedor repetido");
                        mtxtVendedor.Text = "";
                        nupActivo.Value = 0;
                        nupComision.Value = 0;
                        mtxtVendedor.Focus();
                    }
                }
                srVendedores.Close();
                using (StreamWriter swVendedores = File.AppendText("./Vendedores.txt"))
                {
                    if (bandera == false)
                    {
                        swVendedores.WriteLine(mensaje);
                        MessageBox.Show("Carga Realizada");
                        txtNombreVendedor.Text = "";
                        mtxtVendedor.Text = "";
                        nupActivo.Value = 0;
                        nupComision.Value = 0;
                        mtxtVendedor.Focus();
                    }

                    swVendedores.Close();
                }

            }
            else
            {
                MessageBox.Show("Complete con los datos, por favor ");

            }
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
