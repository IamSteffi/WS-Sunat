using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //llamar al servicio
        private static ServiceReference1.WebService1SoapClient servicio;
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ruc = txtRUC.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();

            dgvRUC.DataSource = servicio.Buscar(txtRUC.Text).Tables[0];
        }

        private void dgvRUC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
