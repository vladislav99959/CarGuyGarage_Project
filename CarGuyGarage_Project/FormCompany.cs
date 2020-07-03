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
    public partial class FormCompany : Form
    {
        public FormCompany()
        {
            InitializeComponent();
            ShowCompany();
        }

        void ShowCompany()
        {
            listViewCompany.Items.Clear();
            foreach (Company comp in Program.wftDb.Company)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    comp.Id.ToString(),
                    comp.Name,
                    comp.Addres,
                    comp.City,
                    comp.Phone,

                });
                item.Tag = comp;
                listViewCompany.Items.Add(item);
            }
            listViewCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormCompany_Load(object sender, EventArgs e)
        {

        }

        private void listViewCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCompany.SelectedItems.Count == 1)
            {
                Company firms = listViewCompany.SelectedItems[0].Tag as Company;
                textBoxAddres.Text = firms.Addres;
                textBoxCity.Text = firms.City;
                textBoxName.Text = firms.Name;
                textBoxPhoneNumber.Text = firms.Phone;
            }
            else
            {
                textBoxAddres.Text = "";
                textBoxCity.Text = "";
                textBoxName.Text = "";
                textBoxPhoneNumber.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAddres.Text != "" && textBoxCity.Text != ""
                && textBoxName.Text != "" && textBoxPhoneNumber.Text != "")
            {
                Company comp = new Company();
                comp.Name = textBoxName.Text;
                comp.Phone = textBoxPhoneNumber.Text;
                comp.City = textBoxCity.Text;
                comp.Addres = textBoxAddres.Text;
                Program.wftDb.Company.Add(comp);
                Program.wftDb.SaveChanges();
                ShowCompany();
            }
            else MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCompany.SelectedItems.Count == 1)
            {
                if (textBoxAddres.Text != "" && textBoxCity.Text != ""
                && textBoxName.Text != "" && textBoxPhoneNumber.Text != "")
                {
                    Company comp = listViewCompany.SelectedItems[0].Tag as Company;
                    comp.Name = textBoxName.Text;
                    comp.Addres = textBoxAddres.Text;
                    comp.City = textBoxCity.Text;
                    comp.Phone = textBoxPhoneNumber.Text;
                    Program.wftDb.SaveChanges();
                    ShowCompany();
                }
                else MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCompany.SelectedItems.Count == 1)
                {
                    Company comp = listViewCompany.SelectedItems[0].Tag as Company;
                    Program.wftDb.Company.Remove(comp);
                    Program.wftDb.SaveChanges();
                    ShowCompany();
                }
                textBoxAddres.Text = "";
                textBoxPhoneNumber.Text = "";
                textBoxName.Text = "";
                textBoxCity.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
