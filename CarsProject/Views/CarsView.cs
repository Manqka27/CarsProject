using CarsProject.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsProject.Views
{
    public partial class CarsView : Form
    {
        public CarsView()
        {
            InitializeComponent();
            CarsController carController = new CarsController();
        }

        private void CarsView_Load(object sender, EventArgs e, CarsController carsController)
        {
            // TODO: This line of code loads data into the 'carsDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.carsDBDataSet.Table);
            dgvCars.DataSource = carsController.GetAll();

        }
    }
}
