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
        private List<Character> characters;
        private List<Monster> monsters;
        private User user;
        private SimulatorController simController;
        private int numChars = 0;

        public ConfigController(ConfigGUI gui)
        {
            this.gui = gui;
            characters = new List<Character>();
            monsters = new List<Monster>();
        }

        public void show()
        {
            if (gui != null)
            {
                gui.Show();
                simController = null;
            }
        }

        public void initSimulation(List<string> monsterTypes)
        {
            int totalDL = initializeMonsters(monsterTypes);
            autoFillMonstersToMatchCD(totalDL);
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

        public void updatedMonsters(List<string> monsterTypes, NumericUpDown oldDL)
        {
            int curDL = initializeMonsters(monsterTypes);
            if ((int)oldDL.Value < curDL )
            {
                oldDL.Value = curDL;
            }
        }

        public int initializeMonsters(List<string> monsterTypes)
        {
            monsters.Clear();
            int totalDL = 0;
            foreach (string type in monsterTypes)
            {
                VARIANT variant = Monster.getVariant(type);
                Monster monster = new Monster(variant);
                monsters.Add(monster);
                totalDL += monster.getDifficultyLevel();
            }
            return totalDL;
        }

        private void autoFillMonstersToMatchCD(int curDL)
        {
            int rem = scenario.initCD - curDL;
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

        public PROFESSION getProfessionIdentifier(string profession)
        {
            if (profession.Equals("Combat Mage"))
            {
                return PROFESSION.MAGE;
            }

            if (profession.Equals("Soldier"))
            {
                return PROFESSION.SOLDIER;
            }
            return PROFESSION.PRIEST;
        }

        public List<Character> getCharacters()
        {
            return characters;
        }

        public void resetChars()
        {
            characters.Clear();
            numChars = 0;
        }

        public void updateChars(int num, CheckedListBox checks, ListBox list)
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

        public void assignProfession(int character, string profession, CheckedListBox checks, ListBox list)
        {
            characters[character].setProfession(getProfessionIdentifier(profession));
            checks.Items[character] = characters[character].getProfessionName();
            list.Items[character] = characters[character].getProfessionName();
        }

        public void setProfLevel(int character, int level)
        {
            if (character >= 0 && level >= 0)
            {
                characters[character].setLevel(level);
            }
        }

        public void setReviveOpt(int character, int opt)
        {
            if (character >= 0 && opt >= 0)
            {
                characters[character].setHealOption((HEAL_OPTION)opt);
            }
        }

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

        public void setCharacterPlayability(int identifier)
        {
            foreach (Character character in characters)
            {
                if (character.getIdentifier() == identifier)
                {
                    character.setPlayable(true);
                }
            }
        }
    }
}
