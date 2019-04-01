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
            _frmAddRacersViewModel.GetNextStartNumber();
            InitializeComponent();
            Init();
        }

        public FrmAddRacer(FrmRacers frmRacers, FrmAddRacersViewModel frmAddRacersViewModel, int index)
        {
            _frmRacers = frmRacers;
            _frmAddRacersViewModel = frmAddRacersViewModel;
            _frmAddRacersViewModel.GetRacerByIndex(index);
            _frmAddRacersViewModel.IsEdit = true;
            InitializeComponent();
            InitForEdit();
        }

        private void Init()
        {
            CountryRepository countries = new CountryRepository();
            cmbCountry.DataSource = new BindingSource(countries.GetCountries(),null);
            cmbCountry.DisplayMember = "Value";
            cmbCountry.ValueMember = "Value";
            numStartNumber.Value = _frmAddRacersViewModel.NextStartNumber;
            cmbCountry.SelectedIndex = cmbCountry.FindString("Slovensko");
        }

        private void InitForEdit()
        {
            numStartNumber.Value = _frmAddRacersViewModel.StartNumber;
            txtName.Text = _frmAddRacersViewModel.Name;
            numAge.Value = _frmAddRacersViewModel.Age;

            if (_frmAddRacersViewModel.Gender ==Gender.Female)
            {
                rdnWoman.Select();
            }
            else
            {
                rdnMale.Select();
            }

            CountryRepository countries = new CountryRepository();
            cmbCountry.DataSource = new BindingSource(countries.GetCountries(), null);
            cmbCountry.DisplayMember = "Value";
            cmbCountry.ValueMember = "Value";
            cmbCountry.SelectedIndex = cmbCountry.FindString(_frmAddRacersViewModel.Country);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _frmAddRacersViewModel.StartNumber = (int)numStartNumber.Value;
            _frmAddRacersViewModel.Name = txtName.Text;
            _frmAddRacersViewModel.Age = (int)numAge.Value;
            if (rdnWoman.Checked)
            {
                _frmAddRacersViewModel.Gender = Gender.Female;
            }
            else
            {
                _frmAddRacersViewModel.Gender = Gender.Male;
            }
            _frmAddRacersViewModel.Country = cmbCountry.SelectedValue.ToString();
            try
            {
                if (_frmAddRacersViewModel.IsEdit)
                {
                    _frmAddRacersViewModel.EditRacer();
                }
                else
                {
                    _frmAddRacersViewModel.AddRacer();
                }

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
