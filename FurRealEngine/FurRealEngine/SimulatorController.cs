using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurRealEngine
{
    public class SimulatorController
    {
        SimulatorGUI simGUI;
        CombatRoundController roundController;
        ScenarioSettings scenario;
        SceneSettings scene;
        List<Character> characters;
        List<Monster> monsters;
        ConfigController config;
        int runNum = 1;
        int curLevel;

        static Random rand = new Random();

        public SimulatorController(ScenarioSettings scenario, SceneSettings scene, List<Character> characters, List<Monster> monsters, ConfigController config)
        {
            this.scenario = scenario;
            this.scene = scene;
            this.characters = characters;
            this.monsters = monsters;
            this.config = config;
            roundController = new CombatRoundController(scenario, scene, characters, monsters);
            simGUI = new SimulatorGUI(this, roundController);
            setBackground();
            curLevel = scenario.startLevel;
            // make a deep copy of every character and monster in the scene settings
            // so that they can be restored after every level
            this.scene.characters = new List<Character>();
            this.scene.monsters = new List<Monster>();
            foreach (Character character in this.characters)
            {
                this.scene.characters.Add(character.clone());
            }
            foreach (Monster monster in this.monsters)
            {
                this.scene.monsters.Add(monster.clone());
            }
        }

        public static int diceRoll(int numRolls, int sides)
        {
            int result = 0;
            for (int i = 0; i < numRolls; ++i)
            {
                result += (rand.Next() % sides) + 1;
            }
            return result;
        }

        // fill the list box with every character
        public void fillCharacterList(ListBox list)
        {
            list.Items.Clear();
            foreach (Character character in characters) {
                string prof = "";
                prof = character.getProfessionName();
                list.Items.Add(prof);
            }
        }

        // fill the group box with info about the selected character
        public void fillCharacterGroup(GroupBox group, int index)
        {
            if (characters.Count() > 0)
            {
                Character character = characters.ElementAt(index);
                IEnumerable<TextBox> boxes = group.Controls.OfType<TextBox>();
                List<TextBox> boxesList = boxes.ToList();
                foreach (TextBox box in boxesList)
                {
                    if (box.Name == "professionText")
                    {
                        box.Text = character.getProfessionName();
                    }
                    else if (box.Name == "levelText")
                    {
                        box.Text = character.getLevel().ToString();
                    }
                    else if (box.Name == "charCurHealthText")
                    {
                        box.Text = character.getCurHealth().ToString();
                    }
                    else if (box.Name == "charMaxHealthText")
                    {
                        box.Text = character.getMaxHealth().ToString();
                    }
                    else if (box.Name == "strengthText")
                    {
                        box.Text = character.getStrength().ToString();
                    }
                    else if (box.Name == "intelligenceText")
                    {
                        box.Text = character.getIntelligence().ToString();
                    }
                    else if (box.Name == "wisdomText")
                    {
                        box.Text = character.getWisdom().ToString();
                    }
                    else if (box.Name == "dexterityText")
                    {
                        box.Text = character.getDexterity().ToString();
                    }
                    else if (box.Name == "constitutionText")
                    {
                        box.Text = character.getConstitution().ToString();
                    }
                    else if (box.Name == "playableText")
                    {
                        if (character.isCharacterPlayable())
                        {
                            box.Text = "Yes";
                        }
                        else
                        {
                            box.Text = "No";
                        }
                    }
                }
            }
        }

        // fill the list with every monster
        public void fillMonsterList(ListBox list)
        {
            list.Items.Clear();
            foreach (Monster monster in monsters)
            {
                list.Items.Add(monster.getVariantName() + " - LVL " + monster.getDifficultyLevel().ToString());
            }
        }

        // fill the group box with info about the selected monster
        public void fillMonsterGroup(GroupBox group, int index)
        {
            if (monsters.Count() > 0 && index >= 0 && index < monsters.Count())
            {
                Monster monster = monsters.ElementAt(index);
                IEnumerable<TextBox> boxes = group.Controls.OfType<TextBox>();
                List<TextBox> boxesList = boxes.ToList();
                foreach (TextBox box in boxesList)
                {
                    if (box.Name == "typeText")
                    {
                        box.Text = monster.getTypeName();
                    }
                    else if (box.Name == "nameText")
                    {
                        box.Text = monster.getVariantName();
                    }
                    else if (box.Name == "monsterCurHealthText")
                    {
                        box.Text = monster.getCurHealth().ToString();
                    }
                    else if (box.Name == "monsterMaxHealthText")
                    {
                        box.Text = monster.getMaxHealth().ToString();
                    }
                    else if (box.Name == "difficultyLevelText")
                    {
                        box.Text = monster.getDifficultyLevel().ToString();
                    }
                }
            }
        }

        // enable/disable attack buttons based on profession of selected character
        public void activateAttackButtons(Button meleeButton, Button spellButton, int character)
        {
            PROFESSION prof = characters[character].getProfession();
            if (prof == PROFESSION.SOLDIER)
            {
                meleeButton.Enabled = true;
                spellButton.Enabled = false;
            }
            else if (prof == PROFESSION.MAGE)
            {
                meleeButton.Enabled = false;
                spellButton.Enabled = true;
            }
            else if (prof == PROFESSION.PRIEST)
            {
                meleeButton.Enabled = true;
                spellButton.Enabled = true;
            }
        }

        // look for any character/monster health that hit zero or below
        // and remove them from the list
        public void checkForDeath()
        {
            for (int i = 0; i < monsters.Count(); ++i)
            {
                if (monsters[i].getCurHealth() <= 0)
                {
                    simGUI.removeFromMonsterList(i);
                    monsters.RemoveAt(i);
                }
            }
        }

        // check if every monster is dead
        // if so, reload characters/monsters for next level
        // close sim when all levels have finished
        public void checkForEndOfLevel()
        {
            if (monsters.Count() == 0)
            {
                curLevel++;
                if (curLevel > scenario.endLevel)
                {
                    curLevel = scenario.startLevel;
                    runNum++;
                    if (runNum > scenario.numberOfRuns)
                    {
                        close();
                    }
                }
                characters = new List<Character>();
                monsters = new List<Monster>();
                foreach (Character character in scene.characters)
                {
                    characters.Add(character.clone());
                }
                foreach (Monster monster in scene.monsters)
                {
                    monsters.Add(monster.clone());
                }
                roundController.setCharacters(characters);
                roundController.setMonsters(monsters);
            }
        }

        // set background image based on environment
        public void setBackground()
        {
            if (scene.environment == "dungeon")
            {
                simGUI.BackgroundImage = Properties.Resources.dungeon;
            }
            else if (scene.environment == "cavern")
            {
                simGUI.BackgroundImage = Properties.Resources.cavern;
            }
            else if (scene.environment == "forest")
            {
                simGUI.BackgroundImage = Properties.Resources.forest;
            }
        }

        // when all levels have finished, return to the config gui
        public void close()
        {
            if (simGUI != null)
            {
                simGUI.Hide();
            }
            simGUI = null;
            config.show();
        }
    }
}
