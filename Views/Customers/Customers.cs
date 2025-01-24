using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports.Views.Customers
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'adventureWorks2017DataSet.vIndividualCustomer' Puede moverla o quitarla según sea necesario.
            this.vIndividualCustomerTableAdapter.Fill(this.adventureWorks2017DataSet.vIndividualCustomer);
            // TODO: esta línea de código carga datos en la tabla 'adventureWorks2017DataSet.Customer' Puede moverla o quitarla según sea necesario.
            this.reportViewer1.RefreshReport();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            this.vIndividualCustomerTableAdapter.FillByName(this.adventureWorks2017DataSet.vIndividualCustomer, txtFind.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
