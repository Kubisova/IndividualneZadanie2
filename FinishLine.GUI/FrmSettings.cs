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
    public partial class FrmSettings : Form
    {
        private FrmSettingsViewModel _frmSettingsViewModel;

        public FrmSettings(FrmView frmView, FrmSettingsViewModel frmSettingsViewModel)
        {
            _frmSettingsViewModel = frmSettingsViewModel;
            _frmSettingsViewModel.GetSettings();
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            numRoundLength.Value = _frmSettingsViewModel.RoundLength;
            numRoundCount.Value = _frmSettingsViewModel.RoundCount;
            numNumberOfWinners.Value = _frmSettingsViewModel.NumberOfWinners;

            if (_frmSettingsViewModel.Race.HasStarted)
            {
                btnSave.Enabled = false;
                MessageBox.Show("Preteky sa už začali a preto nie je možné meniť nastavenia.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _frmSettingsViewModel.RoundLength = (int)numRoundLength.Value;
            _frmSettingsViewModel.RoundCount = (int)numRoundCount.Value;
            _frmSettingsViewModel.NumberOfWinners = (int)numNumberOfWinners.Value;
            _frmSettingsViewModel.SaveSettings();
            Close();
        }
    }
}
