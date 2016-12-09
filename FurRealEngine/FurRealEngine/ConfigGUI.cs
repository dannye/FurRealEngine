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
        private DbPreset configurationPreset;
        private Boolean areInitializing;

        Random rng = new Random();

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
            areInitializing = true;
            this.user = user;
            configController.setActiveUser(user);
            if (!user.getAdminStatus())
            {
                editAccountGroup.Enabled = false;
            }
            configurationPreset = configController.loadDefaultPreset(user);        
            Show();
            intializeConfigurationPreset(configurationPreset);
            areInitializing = false;
        }

        // validate input, then begin simulation
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
            configController.setScenario(new ScenarioSettings(getStartingDifficulty(), getStartingLevel(), getMaxLevel(),
                                                              getRepeatTimes(), getNumberOfCharacters(), getMonstersStartingCD()));
            configController.setScene(getStartingLevel(), getEnvironment(), getMonstersStartingCD());
            configController.initSimulation();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // add a new monster if the total difficulty level does not exceed 100
        private void buttonAddMonster_Click(object sender, EventArgs e)
        {
            if (comboBoxMonsters.SelectedItem == null)
            {
                MessageBox.Show("Cannot add empty item!");
                return;
            }
            int curDL = configController.currentDL();
            Monster monster = new Monster(comboBoxMonsters.SelectedItem.ToString());
            if (curDL + monster.getDifficultyLevel() > 100)
            {
                MessageBox.Show("There are already too many monsters!");
                return;
            }
            configController.addMonster(monster, numericUpDownMonsterCD);
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
            configController.removeMonster(listBoxMonsters.SelectedIndex);
            listBoxMonsters.Items.Remove(listBoxMonsters.SelectedItem);
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (listBoxMonsters.Items.Count == 0)
            {
                MessageBox.Show("No monsters to remove!");
                return;
            }
            configController.removeAllMonsters();
            listBoxMonsters.Items.Clear();
        }

        // pick a random number of characters
        // but don't pick the same current number of characters
        private void buttonRandomizeNumOfChars_Click(object sender, EventArgs e)
        {
            checkedListBoxChars.Items.Clear();
            listBoxCharacters.Items.Clear();
            configController.resetCharacters();
            int newNum;
            do
            {
                newNum = rng.Next(1, 6 + 1);
            } while (newNum == numericUpDownNumOfChars.Value);
            numericUpDownNumOfChars.Value = newNum;
        }

        private void buttonRandomizeEnvironment_Click(object sender, EventArgs e)
        {
            comboBoxEnvironment.SelectedIndex = rng.Next(0, comboBoxEnvironment.Items.Count);
        }

        // pick a random challenge difficulty
        // but no smaller than the current sum of monster difficulty levels
        private void buttonRadomizeCD_Click(object sender, EventArgs e)
        {
            numericUpDownMonsterCD.Value = rng.Next(configController.currentDL(), 100 + 1);
        }

        private void numericUpDownNumOfChars_ValueChanged(object sender, EventArgs e)
        {
            configController.updateCharacters(getNumberOfCharacters(), checkedListBoxChars, listBoxCharacters);
        }

        // assign the selected profession to the selected character
        private void buttonSelectProfession_Click(object sender, EventArgs e)
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
            int character = listBoxCharacters.SelectedIndex;
            string selectedProfession = comboBoxProfessions.SelectedItem.ToString();
            configController.assignProfession(character, selectedProfession, checkedListBoxChars, listBoxCharacters);
            if (!areInitializing) { MessageBox.Show("Profession assigned!"); }
        }

        // assign the selected level to the selected character
        private void buttonSelectProfessionLevel_Click(object sender, EventArgs e)
        {
            if (listBoxCharacters.SelectedIndex < 0 || comboBoxProfessionLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a character and a Level!");
                return;
            }
            configController.setProfLevel(listBoxCharacters.SelectedIndex, comboBoxProfessionLevel.SelectedIndex + 5);
            if (!areInitializing) { MessageBox.Show("Profession level assigned!"); }
        }

        // assign the selected heal option to the selected character
        private void buttonSelectRevive_Click(object sender, EventArgs e)
        {
            if (listBoxCharacters.SelectedIndex < 0 || comboBoxReviveOpt.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a character and a revive option!");
                return;
            }
            configController.setReviveOpt(listBoxCharacters.SelectedIndex, comboBoxReviveOpt.SelectedIndex);
            if (!areInitializing) { MessageBox.Show("Revive option assigned!"); }
        }

        private void ConfigGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            configController.setProfessionFields(comboBoxProfessions, comboBoxProfessionLevel, comboBoxReviveOpt, listBoxCharacters.SelectedIndex);
        }

        // update the starting level, but do not exceed the max level
        private void numericUpDownStartLevel_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownStartLevel.Value > numericUpDownMaxLevel.Value)
            {
                numericUpDownMaxLevel.Value = numericUpDownStartLevel.Value;
            }
        }

        // updated the max level, but do not go below the starting level
        private void numericUpDownMaxLevel_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownStartLevel.Value > numericUpDownMaxLevel.Value)
            {
                numericUpDownStartLevel.Value = numericUpDownMaxLevel.Value;
            }
        }

        // update the challenge difficulty, but do not go below the sum
        // of the monster difficulty levels
        private void numericUpDownMonsterCD_ValueChanged(object sender, EventArgs e)
        {
            int curDL = configController.currentDL();
            if (numericUpDownMonsterCD.Value < curDL)
            {
                numericUpDownMonsterCD.Value = curDL;
            }
        }

        private void checkedListBoxChars_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            configController.setCharacterPlayability(e.Index, e.NewValue == CheckState.Checked);
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

        private bool areFieldsEmpty()
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

        private DIFFICULTY getStartingDifficulty()
        {          
            if (comboBoxDifficulty.SelectedItem.ToString().Equals("Novice"))
            {
                return DIFFICULTY.NOVICE;
            }
            if (comboBoxDifficulty.SelectedItem.ToString().Equals("Apprentice"))
            {
                return DIFFICULTY.APPRENTICE;
            }
            return DIFFICULTY.MASTER;
        }

        private int getRepeatTimes()
        {
            return (int)numericUpDownRepeat.Value;
        }

        public List<string> getUserSelectedMonsters()
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

        private void editAccountButton_MouseClick(object sender, MouseEventArgs e)
        {
            ModifyAccountsGUI modify = new ModifyAccountsGUI();
            this.Hide();
            modify.ShowDialog();

        }

        private void intializeConfigurationPreset(DbPreset preset)
        {
            this.configurationPreset = preset;
            initializeCharacterPresets();
            initializeCharProfessionPresets();
            initializeScenePresets();
        }

        private void initializeCharacterPresets()
        {
            numericUpDownNumOfChars.Value = this.configurationPreset.numberOfCharacters;
            if (this.configurationPreset.areCharsPlayablePreset)
            {
                for (int i = 0; i < checkedListBoxChars.Items.Count; i++)
                {
                    checkedListBoxChars.SetItemChecked(i, true);
                }
            }
        }

        private void initializeCharProfessionPresets()
        {
            for (int i = 0; i < listBoxCharacters.Items.Count; i++)
            {
                listBoxCharacters.SelectedIndex = i;
                comboBoxProfessions.SelectedIndex = this.configurationPreset.defaultProfessionPreset;
                buttonSelectProfession.PerformClick();
                comboBoxProfessionLevel.SelectedIndex = this.configurationPreset.defaultProfessionLevelPreset;
                buttonSelectProfessionLevel.PerformClick();
                comboBoxReviveOpt.SelectedIndex = this.configurationPreset.defaultReviveOptionPreset;
                buttonSelectRevive.PerformClick();
            }
        }

        private void initializeScenePresets()
        {
            numericUpDownMonsterCD.Value = this.configurationPreset.defaultCdPreset;
            comboBoxDifficulty.SelectedIndex = this.configurationPreset.defaultStartingDifficultyPreset;
            numericUpDownStartLevel.Value = this.configurationPreset.defaultStartingLevelPreset;
            numericUpDownMaxLevel.Value = this.configurationPreset.defaultMaxLevelPreset;
            comboBoxEnvironment.SelectedIndex = this.configurationPreset.defaultEnviornmentPreset;
            numericUpDownRepeat.Value = this.configurationPreset.defaultRepeatScenarioPreset;

        }

        private void buttonSavePreset_Click(object sender, EventArgs e)
        {

        }
    }
}
