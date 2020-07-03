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
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
            ShowCars();
        }

        void ShowCars()
        {
            listViewCars.Items.Clear();
            foreach (Cars cars in Program.wftDb.Cars)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    cars.Id.ToString(),
                    cars.Model,
                    cars.Color,
                    cars.Price.ToString(),
                    cars.PlateNumber,
                    cars.Year.ToString()
                });
                item.Tag = cars;
                listViewCars.Items.Add(item);
            }
            listViewCars.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxColor.SelectedItem != null && textBoxModel.Text != ""
                && textBoxPlateNumber.Text != "" && textBoxPrice.Text != ""
                && textBoxYear.Text != "")
            {
                Cars cars = new Cars();
                cars.Model = textBoxModel.Text;
                cars.PlateNumber = textBoxPlateNumber.Text;
                cars.Price = Convert.ToInt32(textBoxPrice.Text);
                cars.Year = Convert.ToInt32(textBoxYear.Text);
                cars.Color = comboBoxColor.Text;
                Program.wftDb.Cars.Add(cars);
                Program.wftDb.SaveChanges();
                ShowCars();
            }
            else MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 1)
            {
                if (comboBoxColor.SelectedItem != null && textBoxModel.Text != ""
                && textBoxPlateNumber.Text != "" && textBoxPrice.Text != ""
                && textBoxYear.Text != "")
                {
                    Cars cars = listViewCars.SelectedItems[0].Tag as Cars;
                    cars.Model = textBoxModel.Text;
                    cars.PlateNumber = textBoxPlateNumber.Text;
                    cars.Price = Convert.ToInt32(textBoxPrice.Text);
                    cars.Year = Convert.ToInt32(textBoxYear.Text);
                    cars.Color = comboBoxColor.Text;
                    Program.wftDb.SaveChanges();
                    ShowCars();
                }
                else MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCars.SelectedItems.Count == 1)
                {
                    Cars cars = listViewCars.SelectedItems[0].Tag as Cars;
                    Program.wftDb.Cars.Remove(cars);
                    Program.wftDb.SaveChanges();
                    ShowCars();
                }
                comboBoxColor.SelectedItem = null;
                textBoxModel.Text = "";
                textBoxPlateNumber.Text = "";
                textBoxPrice.Text = "";
                textBoxYear.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 1)
            {
                Cars cars = listViewCars.SelectedItems[0].Tag as Cars;
                textBoxYear.Text = cars.Year.ToString();
                textBoxPrice.Text = cars.Price.ToString();
                textBoxPlateNumber.Text = cars.PlateNumber;
                textBoxModel.Text = cars.Model;
                comboBoxColor.Text = cars.Color;
            }
            else
            {
                comboBoxColor.SelectedItem = null;
                textBoxModel.Text = "";
                textBoxPlateNumber.Text = "";
                textBoxPrice.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void textBoxYear_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void textBoxPrice_TextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void FormCars_Load(object sender, EventArgs e)
        {

        }
    }
}
