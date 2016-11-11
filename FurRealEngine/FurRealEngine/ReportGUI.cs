using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurRealEngine
{
    internal partial class ReportGUI : Form
    {

        ReportController reportController;
        public ReportGUI(ReportController reportController)
        {
            this.reportController = reportController;
            InitializeComponent();
            Show();
        }

        private void populateReportsListBox()
        {

        }

        private void buttonNewSim_Click(object sender, EventArgs e)
        {
            reportController.close();
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSelectReport_Click(object sender, EventArgs e)
        {

        }
    }
}