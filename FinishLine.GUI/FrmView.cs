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
            Init();
        }

        private void Init()
        {

        }

        private void pretekáriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmRacers = new FrmRacers(this, new FrmRacersViewModel()))
            {
                frmRacers.ShowDialog();
            }
        }
    }
}
