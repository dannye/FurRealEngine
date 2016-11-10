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
        Report report;
        ReportController reportController;
        public ReportGUI(Report report, ReportController reportController)
        {
            this.report = report;
            this.reportController = reportController;
            InitializeComponent();
            Show();
        }

        private void buttonNewSim_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            reportController.close();
        }

        private void buttonSelectReport_Click(object sender, EventArgs e)
        {

        }
    }
}