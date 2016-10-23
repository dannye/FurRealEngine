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
    public partial class ConfigGUI : Form
    {
        private ConfigController configController;
        private static int NOVICE = 1;
        private static int APPRENTICE = 2;
        private static int MASTER = 3;

        public ConfigGUI()
        {
            InitializeComponent();
            configController = new ConfigController();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            initSimulationSettings();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddMonster_Click(object sender, EventArgs e)
        {
            if (comboBoxMonsters.SelectedItem == null)
            {
                MessageBox.Show("Cannot add empty item");
                return;
            }

            listBoxMonsters.Items.Add(comboBoxMonsters.SelectedItem);
        }

        private void buttonRemoveMonster_Click(object sender, EventArgs e)
        {
            if (listBoxMonsters.Items.Count == 0)
            {
                MessageBox.Show("No monsters to remove!");
                return;
            }
            if (listBoxMonsters.SelectedItem == null)
            {
                MessageBox.Show("You must select a monster to be able to remove!");
                return;
            }
            listBoxMonsters.Items.Remove(listBoxMonsters.SelectedItem);
        }

        private void buttonRandomizeNumOfChars_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            numericUpDownNumOfChars.Value = rng.Next(1, 6);
        }

        private void buttonRandomizeEnvironment_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            comboBoxEnvironment.SelectedIndex = rng.Next(0, comboBoxEnvironment.Items.Count);
        }

        private void buttonRadomizeCD_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            numericUpDownMonsterCD.Value = rng.Next(1, 100);
        }

        private void initSimulationSettings()
        {
            mapScenarioSettings();
            mapSceneSettings();
        }

        private void mapSceneSettings()
        {
            SceneSettings scene = new SceneSettings();
        }

        private void mapScenarioSettings()
        {
            ScenarioSettings scenario = new ScenarioSettings(getStartingDifficulty(), getStartingLevel(), getMaxLevel(),
                getRepeatTimes(), getNumberOfCharacters(), getMonstersStartingCD());
        }

        private int getStartingLevel()
        {
            return (int)numericUpDownStartLevel.Value;
        }

        private int getMaxLevel()
        {
            return (int)numericUpDownMaxLevel.Value;
        }

        private int getNumberOfCharacters()
        {
            return (int)numericUpDownNumOfChars.Value;
        }

        private int getStartingDifficulty()
        {
            if (comboBoxDifficulty.SelectedText.Equals("Novice"))
            {
                return NOVICE;
            }
            if (comboBoxDifficulty.SelectedText.Equals("Apprentice"))
            {
                return APPRENTICE;
            }
            return MASTER;
        }

        private int getRepeatTimes()
        {
            return (int)numericUpDownRepeat.Value;
        }

        private List<string> getUserSelectedMonsters()
        {
            List<string> monsterNames = new List<string>();
            foreach (var monsterName in listBoxMonsters.Items)
            {
                monsterNames.Add(monsterName.ToString());
            }
            return monsterNames;
        }

        private int getMonstersStartingCD()
        {
            return (int) numericUpDownMonsterCD.Value;
        }

        private String getEnvironment()
        {
            return comboBoxEnvironment.SelectedItem.ToString();
        }

    }
}
