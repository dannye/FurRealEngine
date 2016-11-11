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
        ScenarioSettings scenario;
        SceneSettings scene;
        Report report;
        static List<Report> reports;

        public ReportController()
        {
            reports = new List<Report>();
            reportGUI = new ReportGUI(this);
        }

        public ReportController(Report report, ScenarioSettings scenario, SceneSettings scene, ConfigController config)
        {
            this.report = report;
            this.config = config;
            this.scenario = scenario;
            this.scene = scene;
            initializeReport();
            this.addReport(report);
            reportGUI = new ReportGUI(this);
        }

        public void initializeReport()
        {
            this.report.setTotalNumOfChars(this.scenario.numberOfCharacters);
            this.report.setTotalNumOfMonsters(this.scene.monsters.Count);
            this.report.setTotalCD(this.scene.challengeDifficulty);
            this.report.setNumOfCharDefeated(SimulatorController.charactersDefeated);
            this.report.setNumOfMonstersDefeated(SimulatorController.monstersDefeated);
            this.report.setTotalDamageTaken(SimulatorController.totalDamageTaken);
            this.report.setTotalDamageGiven(SimulatorController.totalDamageGiven);
            this.report.setNumOfLevelsProgressed(SimulatorController.levelsCompleted);
            this.report.setNumOfTimesSimRan(scenario.numberOfRuns);
            this.report.setSimulationDifficulty(scenario.difficulty.ToString());
            this.report.setEnvionrmentOfBattle(scene.environment);
        }

        public void addReport(Report report)
        {
            reports.Add(report);
        }

        public List<Report> getReports()
        {
            return ReportController.reports;
        }

        public void close()
        {
            reportGUI.Hide();
            reportGUI = null;
            config.show();
        }

    }
}
