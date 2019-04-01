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
            dGVFinishedRounds.DataSource = Race.FinishedRounds;
            dGVResults.DataSource = Race.Results;
        }

        private void RacersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmRacers = new FrmRacers(this, new FrmRacersViewModel()))
            {
                frmRacers.StartPosition = FormStartPosition.CenterParent;
                frmRacers.ShowDialog();
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmSettings = new FrmSettings(this, new FrmSettingsViewModel()))
            {
                frmSettings.StartPosition = FormStartPosition.CenterParent;
                frmSettings.ShowDialog();
            }
        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {
            _frmMainViewModel.StartRace();
            txtRaceStart.Text = Race.RaceStartTime.ToLongTimeString();
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

                dGVFinishedRounds.DataSource = Race.FinishedRounds;
                dGVResults.DataSource = Race.Results;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnRaceEnd_Click(object sender, EventArgs e)
        {
            _frmMainViewModel.EndRace();
            txtRaceEnd.Text = Race.RaceEndTime.ToLongTimeString();
        }
    }
}
