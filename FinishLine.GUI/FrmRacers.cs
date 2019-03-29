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
            Init();
        }

        private void Init()
        {
            
        }

        private void btnAddRacer_Click(object sender, EventArgs e)
        {
            using (var frmAddRacer = new FrmAddRacer(this, new FrmAddRacersViewModel()))
            {
                frmAddRacer.ShowDialog();
            }
        }
    }
}
