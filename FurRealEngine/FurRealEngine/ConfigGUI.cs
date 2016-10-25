using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FurRealEngine
{
    public partial class ConfigGUI : Form
    {
        private ConfigController configController;
        private User user;
        private static int NOVICE = 1;
        private static int APPRENTICE = 2;
        private static int MASTER = 3;

        public ConfigGUI()
        {
            InitializeComponent();
            configController = new ConfigController(this);
            comboBoxMonsters.SelectedIndex = 0;
            comboBoxDifficulty.SelectedIndex = 0;
            comboBoxEnvironment.SelectedIndex = 0;
        }

        public void initConfigGui(User user)
        {
            this.user = user;
            configController.setActiveUser(user);
            Show();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (areFieldsEmpty())
            {
                return;
            }
            if (!areNumericsValid())
            {
                MessageBox.Show("Numeric values cannot be negative or zero!");
                return;
            }
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
                MessageBox.Show("Cannot add empty item!");
                return;
            }
            int curDL = configController.initializeMonsters(listBoxMonsters.Items.Cast<string>().ToList());
            VARIANT variant = Monster.getVariant(comboBoxMonsters.SelectedItem.ToString());
            Monster monster = new Monster(variant);
            if (curDL + monster.getDifficultyLevel() > 100)
            {
                MessageBox.Show("There are already too many monsters!");
                return;
            }
            listBoxMonsters.Items.Add(comboBoxMonsters.SelectedItem);
            configController.updatedMonsters(listBoxMonsters.Items.Cast<string>().ToList(), numericUpDownMonsterCD);
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
            configController.updatedMonsters(listBoxMonsters.Items.Cast<string>().ToList(), numericUpDownMonsterCD);
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (listBoxMonsters.Items.Count == 0)
            {
                MessageBox.Show("No monsters to remove!");
                return;
            }
            listBoxMonsters.Items.Clear();
            configController.updatedMonsters(listBoxMonsters.Items.Cast<string>().ToList(), numericUpDownMonsterCD);
        }

        private void buttonRandomizeNumOfChars_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            checkedListBoxChars.Items.Clear();
            listBoxCharacters.Items.Clear();
            configController.resetChars();
            int newNum;
            do
            {
                newNum = rng.Next(1, 6 + 1);
            } while (newNum == numericUpDownNumOfChars.Value);
            numericUpDownNumOfChars.Value = newNum;
        }

        private void buttonRandomizeEnvironment_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            comboBoxEnvironment.SelectedIndex = rng.Next(0, comboBoxEnvironment.Items.Count);
        }

        private void buttonRadomizeCD_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            numericUpDownMonsterCD.Value = rng.Next(configController.initializeMonsters(listBoxMonsters.Items.Cast<string>().ToList()), 100 + 1);
        }

        private void numericUpDownNumOfChars_ValueChanged(object sender, EventArgs e)
        {
            configController.updateChars(getNumberOfCharacters(), checkedListBoxChars, listBoxCharacters);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxProfessions.SelectedItem == null)
            {
                MessageBox.Show("You must select a profession to assign a profession!");
                return;
            }
            if (listBoxCharacters.SelectedItem == null)
            {
                MessageBox.Show("You must select a character before assigning a profession!");
                return;
            }
            int characterIdentifier = listBoxCharacters.SelectedIndex;
            string selectedProfession = comboBoxProfessions.SelectedItem.ToString();
            configController.assignProfession(characterIdentifier, selectedProfession, checkedListBoxChars, listBoxCharacters);
            MessageBox.Show("Profession assigned!");
        }

        private void initSimulationSettings()
        {
            mapScenarioSettings();
            mapSceneSettings();
            configController.initSimulation(listBoxMonsters.Items.Cast<string>().ToList());
        }

        private bool areNumericsValid()
        {
            int invalids = 0;
            if ((int) numericUpDownMaxLevel.Value <= 0)
            {
                invalids++;
            }

            if ((int) numericUpDownMonsterCD.Value <= 0)
            {
                invalids++;
            }

            if ((int) numericUpDownNumOfChars.Value <= 0)
            {
                invalids++;
            }

            if ((int) numericUpDownRepeat.Value <= 0)
            {
                invalids++;
            }

            if ((int) numericUpDownStartLevel.Value <= 0)
            {
                invalids++;
            }

            if(invalids > 0)
            {
                return false;
            }

            return true;
        }

        private void mapSceneSettings()
        {
            setCharacterPlayability();
            configController.setScene(getStartingLevel(), getEnvironment(), getMonstersStartingCD());
        }

        private void mapScenarioSettings()
        {
            ScenarioSettings scenario = new ScenarioSettings(getStartingDifficulty(), getStartingLevel(), getMaxLevel(),
                getRepeatTimes(), getNumberOfCharacters(), getMonstersStartingCD());
            configController.setScenario(scenario);
        }

        public bool areFieldsEmpty()
        {
            if (comboBoxDifficulty.SelectedItem == null)
            {
                MessageBox.Show("You must select a difficulty!");
                return true;
            }

            if (comboBoxEnvironment.SelectedItem == null)
            {
                MessageBox.Show("You must select an environment!");
                return true;
            }
            return false;
        }

        private void setCharacterPlayability()
        {
            foreach (int index in checkedListBoxChars.CheckedIndices)
            {
                int id = index + 1;
                configController.setCharacterPlayability(id);
            }
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
            if (comboBoxDifficulty.SelectedItem.ToString().Equals("Novice"))
            {
                return NOVICE;
            }
            if (comboBoxDifficulty.SelectedItem.ToString().Equals("Apprentice"))
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

        private string getEnvironment()
        {
            return comboBoxEnvironment.SelectedItem.ToString();
        }

        private void buttonSelectProfessionLevel_Click(object sender, EventArgs e)
        {
            if (listBoxCharacters.SelectedIndex < 0 || comboBoxProfessionLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a character and a Level!");
                return;
            }
            configController.setProfLevel(listBoxCharacters.SelectedIndex, comboBoxProfessionLevel.SelectedIndex + 5);
            MessageBox.Show("Profession level assigned!");
        }

        private void buttonSelectRevive_Click(object sender, EventArgs e)
        {
            if (listBoxCharacters.SelectedIndex < 0 || comboBoxReviveOpt.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a character and a revive option!");
                return;
            }
            configController.setReviveOpt(listBoxCharacters.SelectedIndex, comboBoxReviveOpt.SelectedIndex);
            MessageBox.Show("Revive option assigned!");
        }

        private void ConfigGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            configController.setProfessionFields(comboBoxProfessions, comboBoxProfessionLevel, comboBoxReviveOpt, listBoxCharacters.SelectedIndex);
        }

        private void numericUpDownStartLevel_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownStartLevel.Value > numericUpDownMaxLevel.Value)
            {
                numericUpDownMaxLevel.Value = numericUpDownStartLevel.Value;
            }
        }

        private void numericUpDownMaxLevel_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownStartLevel.Value > numericUpDownMaxLevel.Value)
            {
                numericUpDownStartLevel.Value = numericUpDownMaxLevel.Value;
            }
        }
    }
}
