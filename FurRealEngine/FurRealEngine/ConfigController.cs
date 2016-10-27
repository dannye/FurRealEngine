using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurRealEngine
{
    public class ConfigController
    {
        private ConfigGUI gui;
        private SceneSettings scene;
        private ScenarioSettings scenario;
        private List<Character> characters = new List<Character>();
        private List<Monster> monsters = new List<Monster>();
        private User user;
        private SimulatorController simController;
        private int numChars = 0;

        public ConfigController(ConfigGUI gui)
        {
            this.gui = gui;
        }

        // called when returning from simulation, show config gui again
        public void show()
        {
            if (gui != null)
            {
                gui.Show();
                simController = null;
                initializeMonsters(gui.getUserSelectedMonsters());
            }
        }

        // begin simulation, hide config gui and show sim gui
        // if the sum of all monster difficulty levels is less
        // than the challenge difficulty specified by the user,
        // then add extra monsters
        public void initSimulation()
        {
            autoFillMonstersToMatchCD();
            simController = new SimulatorController(scenario, scene, characters, monsters, this);
            
            gui.Hide();
        }

        public void setActiveUser(User user)
        {
            this.user = user;
        }

        public void setScene(int level, string environment, int challengeDifficulty)
        {
            scene = new SceneSettings(level, environment.ToLower(), challengeDifficulty, null, null);
        }

        public void setScenario(ScenarioSettings scenario)
        {
            this.scenario = scenario;
        }

        // if the sum of all monster diffculty levels exceeds
        // challenge difficulty specified by the user, increase CD to match
        private void updateChallengeDifficulty(NumericUpDown oldCD)
        {
            int curDL = currentDL();
            if ((int)oldCD.Value < curDL )
            {
                oldCD.Value = curDL;
            }
        }

        // add a monster and update the challenge difficulty if needed
        public void addMonster(Monster monster, NumericUpDown CD)
        {
            monsters.Add(monster);
            updateChallengeDifficulty(CD);
        }

        public void removeMonster(int i)
        {
            monsters.RemoveAt(i);
        }

        public void removeAllMonsters()
        {
            monsters.Clear();
        }

        // returns the sum of all monster difficulty levels
        public int currentDL()
        {
            int totalDL = 0;
            foreach (Monster monster in monsters)
            {
                totalDL += monster.getDifficultyLevel();
            }
            return totalDL;
        }

        // add monsters until the total DL matches the CD for the scenario
        // TODO: implement proper algorithm for adding monsters in clusters
        private void autoFillMonstersToMatchCD()
        {
            int rem = scenario.initCD - currentDL();
            while (rem > 0)
            {
                if (rem >= 12)
                {
                    monsters.Add(new Monster(VARIANT.LICH));
                    rem -= 12;
                    continue;
                }
                else if (rem >= 9)
                {
                    monsters.Add(new Monster(VARIANT.VAMPIRE));
                    rem -= 9;
                    continue;
                }
                else if (rem >= 6)
                {
                    monsters.Add(new Monster(VARIANT.GHOST));
                    rem -= 6;
                    continue;
                }
                else if (rem >= 2)
                {
                    monsters.Add(new Monster(VARIANT.ZOMBIE));
                    rem -= 2;
                    continue;
                }
                else
                {
                    monsters.Add(new Monster(VARIANT.SKELETON));
                    rem -= 1;
                    continue;
                }
            }
        }

        // used after a simulation ends, to remove randomized monsters
        // that were added to the end of the list
        private void initializeMonsters(List<string> monsterTypes)
        {
            monsters.Clear();
            foreach (string type in monsterTypes)
            {
                monsters.Add(new Monster(type));
            }
        }

        // used right before a new list of characters is randomized
        public void resetCharacters()
        {
            characters.Clear();
            numChars = 0;
        }

        // used any time numCars needs to be updated
        // add or remove characters accordingly
        public void updateCharacters(int num, CheckedListBox checks, ListBox list)
        {
            Random rng = new Random();
            while (num < numChars)
            {
                checks.Items.RemoveAt(characters.Count() - 1);
                list.Items.RemoveAt(characters.Count() - 1);
                characters.RemoveAt(characters.Count() - 1);
                numChars--;
            }
            while (num > numChars)
            {
                Character newChar = new Character((PROFESSION)rng.Next(0, 2 + 1));
                characters.Add(newChar);
                list.Items.Add(newChar.getProfessionName());
                checks.Items.Add(newChar.getProfessionName());
                numChars++;
            }
        }

        // used to display info about the currently selected character
        // at the bottom of the gui
        public void setProfessionFields(ComboBox profession, ComboBox professionLevel, ComboBox reviveOpt, int index)
        {
            if (index >= 0)
            {
                profession.SelectedItem = characters[index].getProfessionName();
                professionLevel.SelectedItem = characters[index].getLevel().ToString();
                reviveOpt.SelectedIndex = (int)characters[index].getHealOption();
            }
            else
            {
                profession.SelectedItem = null;
                professionLevel.SelectedItem = null;
                reviveOpt.SelectedItem = null;
            }
        }

        // used when the tester selects a new profession
        public void assignProfession(int character, string profession, CheckedListBox checks, ListBox list)
        {
            characters[character].setProfession(Character.stringToProfession(profession));
            checks.Items[character] = characters[character].getProfessionName();
            list.Items[character] = characters[character].getProfessionName();
        }

        // used when the tester selects a new level
        public void setProfLevel(int character, int level)
        {
            if (character >= 0 && level >= 0)
            {
                characters[character].setLevel(level);
            }
        }

        // used when the user selects a new heal option
        public void setReviveOpt(int character, int opt)
        {
            if (character >= 0 && opt >= 0)
            {
                characters[character].setHealOption((HEAL_OPTION)opt);
            }
        }

        // used when the tester changes a playable checkbox
        public void setCharacterPlayability(int character, bool playable)
        {
            characters[character].setPlayable(playable);
        }

        // deprecated, characters no longer need IDs
        // only used in unit tests
        public void addCharacter(int identifier)
        {
            foreach (Character item in characters)
            {
                if (item.getIdentifier() == identifier)
                {
                    // character already exists in list
                    return;
                }
            }
            Character character = new Character();
            character.setIdentifier(identifier);
            characters.Add(character);
        }

        // only used by unit tests
        public List<Character> getCharacters()
        {
            return characters;
        }
    }
}
