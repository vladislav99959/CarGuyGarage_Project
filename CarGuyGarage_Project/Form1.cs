using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGuyGarage_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenAvailability_Click(object sender, EventArgs e)
        {
            Form formAvailability = new FormAvailability();
            formAvailability.Show();
        }

        private void buttonOpenCompany_Click(object sender, EventArgs e)
        {
            Form formCompany = new FormCompany();
            formCompany.Show();
        }

        private void buttonOpenCars_Click(object sender, EventArgs e)
        {
            Form formCars = new FormCars();
            formCars.Show();
        }
    }
}
