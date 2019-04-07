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
    public partial class FrmView : Form
    {
        private FrmMainViewModel _frmMainViewModel;

        public FrmView(FrmMainViewModel frmMainViewModel)
        {
            _frmMainViewModel = frmMainViewModel;
            InitializeComponent();
            dGVFinishedRounds.DataSource = _frmMainViewModel.Race.FinishedRounds;
            dGVResults.DataSource =  _frmMainViewModel.Race.Results;
            dGVFinishedRounds.Columns[4].DefaultCellStyle.Format = "hh\\:mm\\:ss\\.ff";
            dGVFinishedRounds.Columns[0].DefaultCellStyle.Format = "000";
            dGVResults.Columns[4].DefaultCellStyle.Format = "hh\\:mm\\:ss\\.ff";
            dGVResults.Columns[1].DefaultCellStyle.Format = "000";
        }

        private void RacersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                using (var frmRacers = new FrmRacers(this, new FrmRacersViewModel(_frmMainViewModel.Race, _frmMainViewModel.RacerRepository)))
                {
                    frmRacers.StartPosition = FormStartPosition.CenterParent;
                    frmRacers.ShowDialog();
                }
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                using (var frmSettings = new FrmSettings(this, new FrmSettingsViewModel(_frmMainViewModel.Race)))
                {
                    frmSettings.StartPosition = FormStartPosition.CenterParent;
                    frmSettings.ShowDialog();
                }
            }
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            try
            {
                _frmMainViewModel.StartRace();
                txtRaceStart.Text = _frmMainViewModel.GetRaceStartTimeString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegisterFinishedRound_Click(object sender, EventArgs e)
        {
            _frmMainViewModel.RacerNumber = (int)numRacerNumber.Value; 
            try
            {
                _frmMainViewModel.RegisterFinishedRound();
                numRacerNumber.Value = 0;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                var path = folderBrowserDialog1.SelectedPath;

                try
                {
                    _frmMainViewModel.SaveToFile(path);
                }
                catch
                {
                    MessageBox.Show("Chyba pri uložení dát.");
                }
            }
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = folderBrowserDialog1.SelectedPath;

                try
                {
                    _frmMainViewModel.LoadFromFile(path);
                }
                catch
                {
                    MessageBox.Show("Chyba pri načítaní dát.");
                }

                dGVFinishedRounds.DataSource = _frmMainViewModel.Race.FinishedRounds;
                dGVResults.DataSource = _frmMainViewModel.Race.Results;

                if (_frmMainViewModel.Race.HasStarted)
                {
                    txtRaceStart.Text = _frmMainViewModel.GetRaceStartTimeString();
                }
                if (_frmMainViewModel.Race.HasEnded)
                {
                    txtRaceEnd.Text = _frmMainViewModel.GetRaceEndTimeString();
                }
            }
        }

        private void btnRaceEnd_Click(object sender, EventArgs e)
        {
            try
            {
                _frmMainViewModel.EndRace();
                txtRaceEnd.Text = _frmMainViewModel.GetRaceEndTimeString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
