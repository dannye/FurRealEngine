using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    public class ReportController
    {
        ReportGUI reportGUI;
        ConfigController config;
        ScenarioSettings scenario;
        SceneSettings scene;
        Report report;
        List<Report> reports;

        public ReportController(ScenarioSettings scenario, SceneSettings scene, ConfigController config)
        {
            this.report = new Report();
            this.config = config;
            this.scenario = scenario;
            this.scene = scene;
            initializeReport();
            DBManager.saveReport(config.getUser(), report);
            reports = DBManager.loadReports(config.getUser());
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
            this.report.setSimulationDifficulty(scenario.difficulty);
            this.report.setEnvironmentOfBattle(scene.environment);
            this.report.setTreasure(SimulatorController.treasure);
        }

        public List<Report> getReports()
        {
            return reports;
        }

        public void close()
        {
            reportGUI.Hide();
            reportGUI = null;
            config.show();
        }

    }
}
