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
    public partial class FormAvailability : Form
    {
        public FormAvailability()
        {
            InitializeComponent();
            ShowCars();
            ShowCompany();
            ShowAvailability();
        }

        void ShowCars()
        {
            comboBoxCars.Items.Clear();
            foreach (Cars cars in Program.wftDb.Cars)
            {
                string[] item = { cars.Id.ToString() + ". " + cars.Model +", " + cars.Price};
                comboBoxCars.Items.Add(string.Join(" ", item));
            }
        }

        void ShowCompany()
        {
            comboBoxCompany.Items.Clear();
            foreach (Company comp in Program.wftDb.Company)
            {
                string[] item = { comp.Id.ToString() + ". " + comp.Name };
                comboBoxCompany.Items.Add(string.Join(" ", item));
            }
        }

        void ShowAvailability()
        {
            listViewAvailability.Items.Clear();
            foreach (Availability availability in Program.wftDb.Availability)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        availability.Id.ToString(),
                        availability.Company.Id.ToString(),
                        availability.Company.Name,
                        availability.Cars.Id.ToString(),
                        availability.Cars.Model,
                        availability.Cars.Price.ToString(),
                }) ;
                item.Tag = availability;
                listViewAvailability.Items.Add(item);
                    
            }
            listViewAvailability.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxCars.SelectedItem != null && comboBoxCompany.SelectedItem != null)
            {
                Availability availability = new Availability();
                availability.IdCars = Convert.ToInt32(comboBoxCars.SelectedItem.ToString().Split('.')[0]);
                availability.IdCompany = Convert.ToInt32(comboBoxCompany.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.Availability.Add(availability);
                Program.wftDb.SaveChanges();
                ShowAvailability();
            }
            else MessageBox.Show("Выберите автомобиль и фирму!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void listViewAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                Availability availability = listViewAvailability.SelectedItems[0].Tag as Availability;
                comboBoxCars.SelectedIndex = comboBoxCars.FindString(availability.IdCars.ToString());
                comboBoxCompany.SelectedIndex = comboBoxCompany.FindString(availability.IdCompany.ToString());
            }
            else
            {
                comboBoxCompany.SelectedItem = null;
                comboBoxCars.SelectedItem = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                if (comboBoxCars.SelectedItem != null && comboBoxCompany.SelectedItem != null)
                {
                    Availability availability = listViewAvailability.SelectedItems[0].Tag as Availability;
                    availability.IdCars = Convert.ToInt32(comboBoxCars.SelectedItem.ToString().Split('.')[0]);
                    availability.IdCompany = Convert.ToInt32(comboBoxCompany.SelectedItem.ToString().Split('.')[0]);
                    Program.wftDb.SaveChanges();
                    ShowAvailability();
                }
                else MessageBox.Show("Выберите автомобиль и фирму!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAvailability.SelectedItems.Count == 1)
                {
                    Availability availability = listViewAvailability.SelectedItems[0].Tag as Availability;
                    Program.wftDb.Availability.Remove(availability);
                    Program.wftDb.SaveChanges();
                    ShowAvailability();
                }
                comboBoxCars.SelectedItem = null;
                comboBoxCompany.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
