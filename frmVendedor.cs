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
            //le doy dos valores como maximo y como minimo 
            nupComision.Maximum = 0;
            nupComision.Minimum = -1;
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            //declaraciones de variables 
            int codigo, activo, comision;
            string vendedor, mensaje;
            bool bandera = false;
            codigo = Convert.ToInt32(mtxtVendedor.Text);
            vendedor = txtNombreVendedor.Text;
            activo = Convert.ToInt32(nupActivo.Text);
            comision = Convert.ToInt32(nupComision.Text);
            StreamWriter swVendedores = new StreamWriter("./Vendedores.txt", true);
            swVendedores.Close();

            //confirmamos que no este en vacio 
            if (codigo != 0 && vendedor != "")
            {
                //declaracion para que sea mas bonito 
                mensaje = vendedor + "," + codigo + "," + activo + "," + comision;
                char separador = Convert.ToChar(",");
                //leemos el texto
                StreamReader srVendedores = new StreamReader("./Vendedores.txt");
                //distinto de final a archivo 
                while (!srVendedores.EndOfStream)
                {
                    string[] vecVendedores = srVendedores.ReadLine().Split(separador);
                    int codigoVec = Convert.ToInt32(vecVendedores[1]);
                    //ver si no se repite el codigo si es asi que pase lo siguiente 
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
                
                StreamWriter swVendedores2 = File.AppendText("./Vendedores.txt");
                {
                    //creacion de la carga y limpieza 
                    if (bandera == false)
                    {
                        swVendedores2.WriteLine(mensaje);
                        MessageBox.Show("Carga Realizada");
                        txtNombreVendedor.Text = "";
                        mtxtVendedor.Text = "";
                        nupActivo.Value = 0;
                        nupComision.Value = 0;
                        mtxtVendedor.Focus();
                    }

                    swVendedores2.Close();
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
