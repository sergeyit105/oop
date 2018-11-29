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
    public partial class fTown : Form
    {
        public fTown()
        {
            InitializeComponent();
        }

         public Town TheTown;
         public fTown(Town t)
         {
             TheTown = t;
             InitializeComponent();
         }
        private void fTown_Load(object sender, EventArgs e)
        {
            if (TheTown != null)
            {
                tbName.Text = TheTown.Name;
                tbCountry.Text = TheTown.Country;
                tbRegion.Text = TheTown.Region;
                tbPopulation.Text = TheTown.Population;
                tbYearIncome.Text = TheTown.YearIncome;
                tbSquare.Text = TheTown.Square;
                chbHasPort.Checked = TheTown.HasPort; 
                chbHasAirport.Checked = TheTown.HasAirport;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TheTown.Name = tbName.Text.Trim();
            TheTown.Country = tbCountry.Text.Trim();
            TheTown.Region = tbRegion.Text.Trim(); 
            TheTown.Population = tbPopulation.Text.Trim(); 
            TheTown.YearIncome = tbYearIncome.Text.Trim();
            TheTown.Square = tbSquare.Text.Trim();
            TheTown.HasPort = chbHasPort.Checked;
            TheTown.HasAirport = chbHasAirport.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
