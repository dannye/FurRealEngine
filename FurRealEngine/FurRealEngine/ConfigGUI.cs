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
        private User user;
        private static int NOVICE = 1;
        private static int APPRENTICE = 2;
        private static int MASTER = 3;

        public ConfigGUI()
        {
            InitializeComponent();
            configController = new ConfigController();
        }

        public void initConfigGui(User user)
        {
            this.user = user;
            configController.setActiveUser(user);
            this.Show();
        }

        public void hideSettingsGui()
        {
            this.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (areFieldsEmpty())
            {
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

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (listBoxMonsters.Items.Count == 0)
            {
                MessageBox.Show("No monsters to remove!");
                return;
            }
            listBoxMonsters.Items.Clear();
        }

        private void buttonRandomizeNumOfChars_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            numericUpDownNumOfChars.Value = rng.Next(1, 6 + 1);
        }

        private void buttonRandomizeEnvironment_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            comboBoxEnvironment.SelectedIndex = rng.Next(0, comboBoxEnvironment.Items.Count);
        }

        private void buttonRadomizeCD_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            numericUpDownMonsterCD.Value = rng.Next(1, 100 + 1);
        }

        private void numericUpDownNumOfChars_ValueChanged(object sender, EventArgs e)
        {
            checkedListBoxChars.Items.Clear();
            listBoxCharacters.Items.Clear();

            for (int i = 0; i < this.getNumberOfCharacters(); i++)
            {
                checkedListBoxChars.Items.Add("Character" + (i+1));
                listBoxCharacters.Items.Add("Character" + (i+1));
                configController.addCharacter((i + 1));
            }

            configController.checkForListUpdate(listBoxCharacters.Items.Count);

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxProfessions.SelectedItem == null)
            {
                MessageBox.Show("You must select a profession to assign a profession!");
                return;
            }
            if(listBoxCharacters.SelectedItem == null)
            {
                MessageBox.Show("You must select a character before assigning a profession!");
                return;
            }
            int characterIdentifier = listBoxCharacters.SelectedIndex + 1;
            string selectedProfession = comboBoxProfessions.SelectedItem.ToString();
            configController.assignProfession(characterIdentifier, selectedProfession);
            MessageBox.Show("Profession assigned!");
        }

        private void initSimulationSettings()
        {
            if (!areNumericsValid())
            {
                MessageBox.Show("Numeric values cannot be negative or zero!");
                return;
            }
            mapScenarioSettings();
            mapSceneSettings();
            configController.initSimulation(listBoxMonsters.Items.Cast<string>().ToList());
            hideSettingsGui();
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
            List<string> monsterTypes = getSelectedMonsters();
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

        private List<string> getSelectedMonsters()
        {
            List<string> monsters = new List<string>();
            foreach (var item in listBoxMonsters.Items)
            {
                monsters.Add(item.ToString());
            }
            return monsters;
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
            // TODO: Assign profesion level to selected character
        }

        private void buttonSelectRevive_Click(object sender, EventArgs e)
        {
            //TODO: Assign revive option to selected character
        }
    }
}
