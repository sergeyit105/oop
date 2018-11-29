using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTown_Click(object sender, EventArgs e)
        {
            Town town = new Town();
            fTown ft = new fTown(town);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbTownsInfo.Text +=
                string.Format("{0} {1} {2}. Громадянство: {3}. Адресса {4}. Номер телефону {5}. {6}, {7} \r\n",
                town.Name, town.Country, town.Region,
                town.Population, town.YearIncome, town.Square,
                town.HasPort ? "Повнолітній" : "Неповнолітній",
                town.HasAirport ? "Студент" : "Не студент");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
            "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
