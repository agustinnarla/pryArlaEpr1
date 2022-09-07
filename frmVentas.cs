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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            int numeroFactura, numeroVendedor, monto, cliente;
            string mensaje, factura, fecha;


            bool bandera = false;
            numeroFactura = Convert.ToInt32(mtxtMonto.Text);
            fecha = ftpFecha.Text;
            numeroVendedor = Convert.ToInt32(lstVendedor.Text);
            numeroFactura = Convert.ToInt32(lstFactura.Text);
            monto = Convert.ToInt32(mtxtMonto.Text);
            factura = lstFactura.Text;
            cliente = Convert.ToInt32(lstCliente.Text);

            if (numeroFactura != 0 && numeroVendedor != 0 && fecha != "" && numeroFactura != 0 && monto != 0 && factura != "")
            {
                mensaje = factura + "," + numeroFactura + "," + fecha + "," + cliente + "," + numeroVendedor + "," + monto;
                char separador = Convert.ToChar(",");
                StreamReader srVentas = new StreamReader("./Ventas.txt");
                while (!srVentas.EndOfStream)
                {
                    string[] vecClientes = srVentas.ReadLine().Split(separador);
                    int codigoVec = Convert.ToInt32(vecClientes[1]);
                    if (numeroFactura == codigoVec)
                    {
                        bandera = true;
                        MessageBox.Show("Numero de factura repetido");
                        numeroFactura = 0;
                        lstFactura.Focus();
                    }
                }
                srVentas.Close();
                using (StreamWriter swCliente = File.AppendText("./Clientes.txt"))
                {
                    if (bandera == false)
                    {
                        swCliente.WriteLine(mensaje);
                        MessageBox.Show("Carga Realizada");
                        mtxtMonto.Text = "";
                        lstVendedor.Text = "";
                        lstFactura.Text = "";
                        mtxtMonto.Text = "";
                        lstFactura.Text = "";
                        lstCliente.Text = "";
                        lstFactura.Focus();
                    }

                    swCliente.Close();
                }


            }
            else
            {
                MessageBox.Show("Complete con los datos, por favor ");

            }
        }
    }
}
