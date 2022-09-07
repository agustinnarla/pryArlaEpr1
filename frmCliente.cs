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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            
            //variable utilizadas
            int codigo;
            string cliente, mensaje;
            bool bandera = false;
            codigo = Convert.ToInt32(nupCliente.Text);
            cliente = txtNombreCliente.Text;

            //si estos campos estan distinto de vacio que siga el proceso 
            if (codigo != 0 && cliente != "")
            {
                mensaje = cliente + "," + codigo;
                char separador = Convert.ToChar(",");
                //lectura del archivo 
                //distinto a final de archivo 
                StreamReader srClientes = new StreamReader("./Clientes.txt");
                while (!srClientes.EndOfStream)
                {
                    string[] vecClientes = srClientes.ReadLine().Split(separador);
                    int codigoVec = Convert.ToInt32(vecClientes[1]);

                    //confirmo si el numero no se repita a partir del vector y su posiciòn
                    if (codigo == codigoVec)
                    {
                        bandera = true;
                        MessageBox.Show("Numero repetido");
                        nupCliente.Value = 0;
                        nupCliente.Focus();
                    }
                }
                srClientes.Close();
                //si la bandera es falsa q se cree el archivo 
                StreamWriter swCliente = File.AppendText("./Clientes.txt");
                if (bandera == false)
                    {
                        swCliente.WriteLine(mensaje);
                        MessageBox.Show("Carga Realizada");
                        nupCliente.Value = 0;
                        txtNombreCliente.Text = "";
                        nupCliente.Focus();
                    }
                swCliente.Close();
                
                

            }
            else
            {
                MessageBox.Show("Complete con los datos, por favor ");

            }






        }
    }
}
