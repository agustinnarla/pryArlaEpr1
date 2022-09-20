using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaEPR
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }

        private void cmdVendedor_Click(object sender, EventArgs e)
        {
           frmVendedor frmVendedor = new frmVendedor();
            frmVendedor.ShowDialog();
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            frmVentas frmVentas = new frmVentas();
            frmVentas.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultaVentas frmConsultaVentas = new frmConsultaVentas();
            frmConsultaVentas.ShowDialog();
        }

        private void cmdClienteConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frmConsultaCliente = new frmConsultaCliente();
            frmConsultaCliente.ShowDialog();
        }

        private void cmdVendedorConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaVendedor frmConsultaVendedor = new frmConsultaVendedor();
            frmConsultaVendedor.ShowDialog();
        }
    }
}
