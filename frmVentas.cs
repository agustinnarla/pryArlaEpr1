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
using System.Text.RegularExpressions;


namespace pryArlaEPR
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            //declaracion de variable 
            int vendedor, cliente;
            string factura, fecha, monto;
            int numeroFactura = 1000;
          
            fecha = ftpFecha.Text;
            vendedor = Convert.ToInt32(lstVendedor.Text);
            monto = Convert.ToString(txtMonto.Text);
            factura = lstFactura.Text;
            cliente = Convert.ToInt32(lstCliente.Text);
           
            //creamos archivo 
           

            if ( cliente != -1 && vendedor != -1 && fecha != "" &&  monto != "" && factura != "")
            {
                if (File.Exists("./Ventas.txt"))
                {
                    char separador = Convert.ToChar(";");
                    StreamReader srVentas = new StreamReader("./Ventas.txt");

                    //mientras no sea final de archivo 
                    while (!srVentas.EndOfStream)
                    {
                        //codigo aleatorio
                        string[] vecVentas = srVentas.ReadLine().Split(separador);
                        int codigoVec = Convert.ToInt32(vecVentas[1]);
                        numeroFactura = codigoVec + 1;
                
                    }
                    srVentas.Close();
                }
                //evitar que se sobrescriba 
                StreamWriter swVentas = File.AppendText("./Ventas.txt");
                    {
                        
                            swVentas.WriteLine(factura + ";" + numeroFactura + ";" + fecha + ";" + cliente + ";" + vendedor + ";" + monto );
                            MessageBox.Show("Carga Realizada");
                            lstVendedor.SelectedIndex = -1;
                            lstFactura.Text = "";
                            txtMonto.Text = "";
                           lstCliente.SelectedIndex = -1;
                            lstFactura.Focus();  
                            swVentas.Close();
                    }

            }
            else
            {
                MessageBox.Show("Complete con los datos, por favor ");

            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");
            if (File.Exists("./Clientes.txt"))
            {
                StreamReader srClientes = new StreamReader("./Clientes.txt");
                while (!srClientes.EndOfStream)
                {
                    string[] vecClientes = srClientes.ReadLine().Split(separador);
                    lstCliente.Items.Add(vecClientes[1]);

                }
                srClientes.Close();
            }
            if (File.Exists("./Vendedores.txt"))
            {
                StreamReader srVendedores = new StreamReader("./Vendedores.txt");
                while (!srVendedores.EndOfStream)
                {
                    string[] vecVendedores = srVendedores.ReadLine().Split(separador);
                    lstVendedor.Items.Add(vecVendedores[1]);
                }
                srVendedores.Close();
            }

        }

        private void lstFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void lstVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            //eliminar archivo
            File.Delete("./Ventas.txt");
            MessageBox.Show("Archivo Eliminado");
        }

        private void txtMonto_TextChanged(object sender, EventArgs e) 
        {
           
        }
       
    }
}
