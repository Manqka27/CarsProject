using CarsProject.Controller;
using CarsProject.Models;
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
        CarsController carsController = new CarsController();

        public CarsView()
        {
            InitializeComponent();
        }

        private void CarsView_Load(object sender, EventArgs e)
        {
            dgvCars.DataSource = carsController.GetAll();
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         
        private void RefreshTable()
        {
            dgvCars.DataSource = carsController.GetAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Model = txtModel.Text;
            car.Hp = int.Parse(txtHP.Text);
            car.Price = int.Parse(txtPrice.Text);
            carsController.AddCar(car);
            RefreshTable();
        }
    }
}
