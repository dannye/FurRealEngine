using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    class ReportController
    {
        ReportGUI reportGUI;
        ConfigController config;
        Report report;
        List<Report> reports;

        public ReportController()
        {
            reports = new List<Report>();
            reportGUI = new ReportGUI(report, this);
        }

        public ReportController(Report report, ConfigController config)
        {
            this.report = report;
            this.config = config;
            reportGUI = new ReportGUI(report, this);
        }
        public void close()
        {
            reportGUI.Hide();
            reportGUI = null;
            config.show();
        }

    }
}
