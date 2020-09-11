using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Group
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (SonameTB.Text != "" && NameTB.Text != "" && PatronymicTB.Text != "" && AddressTB.Text != "" && NumberTB.Text != "")
            {
                dataGridView1.Rows.Add(SonameTB.Text, NameTB.Text, PatronymicTB.Text, AddressTB.Text, NumberTB.Text);
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }
    }
}
