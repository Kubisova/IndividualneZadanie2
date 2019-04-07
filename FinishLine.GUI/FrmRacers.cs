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
    public partial class FrmRacers : Form
    {
        private FrmRacersViewModel _frmRacersViewModel;

        public FrmRacers(FrmView frmView, FrmRacersViewModel frmRacersViewModel)
        {
            _frmRacersViewModel = frmRacersViewModel;
            InitializeComponent();
            dGVRacers.DataSource = _frmRacersViewModel.RacerRepository.Racers;
            dGVRacers.Columns[0].DefaultCellStyle.Format = "000";
            Init();
        }

        private void Init()
        {
            if (_frmRacersViewModel.RacerRepository.Racers.Count >= Race.NUMBER_OF_RUNNERS)
            {
                btnAddRacer.Enabled = false;
            }

            if (_frmRacersViewModel.Race.HasStarted)
            {
                btnAddRacer.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAddRacer_Click(object sender, EventArgs e)
        {
            using (var frmAddRacer = new FrmAddRacer(this, new FrmAddRacersViewModel(_frmRacersViewModel.RacerRepository)))
            {
                frmAddRacer.StartPosition = FormStartPosition.CenterParent;
                frmAddRacer.ShowDialog();
            }
            if (_frmRacersViewModel.RacerRepository.Racers.Count >= Race.NUMBER_OF_RUNNERS)
            {
                btnAddRacer.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (dGVRacers.CurrentRow != null)
            {
                int index = dGVRacers.CurrentRow.Index;
                using (var frmAddRacer = new FrmAddRacer(this, new FrmAddRacersViewModel(_frmRacersViewModel.RacerRepository), index))
                {
                    frmAddRacer.Text = "Oprav pretekára";
                    frmAddRacer.StartPosition = FormStartPosition.CenterParent;
                    frmAddRacer.ShowDialog();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dGVRacers.SelectedRows)
            {
                dGVRacers.Rows.RemoveAt(row.Index);
            }

            if (_frmRacersViewModel.RacerRepository.Racers.Count < Race.NUMBER_OF_RUNNERS)
            {
                btnAddRacer.Enabled = true;
            }
        }
    }
}
