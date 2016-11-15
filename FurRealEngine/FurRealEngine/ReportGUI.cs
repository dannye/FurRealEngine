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
            populateReportsListBox();
            if (listBoxReports.Items.Count > 0)
            {
                listBoxReports.SelectedIndex = 0;
                populateReportStatsBreakDown((Report)listBoxReports.SelectedItem);
            }
            Show();
        }

        private void populateReportsListBox()
        {
            foreach (Report report in reportController.getReports())
            {
                this.listBoxReports.Items.Add(report);
            }
        }

        private void populateReportStatsBreakDown(Report report)
        {
            this.textBoxLevelsCompleted.Text = report.getNumOfLevelsProgressed().ToString();
            this.textBoxDifficulty.Text = report.getSimulationDifficulty();
            this.textBoxReplays.Text = report.getNumOfTimesSimRan().ToString();
            this.textBoxNumOfChars.Text = report.getTotalNumOfChars().ToString();
            this.textBoxCharacterDeaths.Text = report.getNumOfCharDefeated().ToString();
            this.textBoxEnv.Text = report.getEnvionrmentOfBattle();
            this.textBoxTotalMonsters.Text = report.getTotalNumOfMonsters().ToString();
            this.textBoxMonstersDefeated.Text = report.getNumOfMonstersDefeated().ToString();
            this.textBoxTotalCD.Text = report.getTotalCD().ToString();
            this.textBoxDamageGiven.Text = report.getTotalDamageGiven().ToString();
            this.textBoxDamageTaken.Text = report.getTotalDamageTaken().ToString();
            this.textBoxTreasure.Text = report.getTreasure().ToString();
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
            Report selectedReport = (Report)this.listBoxReports.SelectedItem;
            if(selectedReport == null)
            {
                MessageBox.Show("Select a valid report to view stats!");
                return;
            }
            populateReportStatsBreakDown(selectedReport);
        }

        private void ReportGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}