using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinishLine.Core;

namespace FinishLine
{
    public partial class FrmAddRacer : Form
    {
        private FrmRacers _frmRacers;
        private FrmAddRacersViewModel _frmAddRacersViewModel;

        public FrmAddRacer(FrmRacers frmRacers, FrmAddRacersViewModel frmAddRacersViewModel)
        {
            _frmRacers = frmRacers;
            _frmAddRacersViewModel = frmAddRacersViewModel;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            CountryRepository countries = new CountryRepository();
            cmbCountry.DataSource = new BindingSource(countries.GetCountries(),null);
            cmbCountry.DisplayMember = "Value";
            cmbCountry.ValueMember = "Key";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _frmAddRacersViewModel.StartNumber = (int)numStartNumber.Value;
            _frmAddRacersViewModel.Name = txtName.Text;
            _frmAddRacersViewModel.Name = txtName.Text;

        }
    }
}
