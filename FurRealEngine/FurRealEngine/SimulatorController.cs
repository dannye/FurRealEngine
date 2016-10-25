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
        ScenarioSettings scenario;
        SceneSettings scene;
        List<Character> characters;
        List<Monster> monsters;
        ConfigController config;

        static Random rand = new Random();

        public SimulatorController(ScenarioSettings scenario, SceneSettings scene, List<Character> characters, List<Monster> monsters, ConfigController config)
        {
            this.scenario = scenario;
            this.scene = scene;
            this.characters = characters;
            this.monsters = monsters;
            this.config = config;
            simGUI = new SimulatorGUI(this, new CombatRoundController(scenario, scene, characters, monsters));
            setBackground();
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

        public void fillCharacterList(ListBox list)
        {
            foreach (Character character in characters) {
                string prof = "";
                prof = character.getProfessionName();
                list.Items.Add(prof);
            }
        }

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
                    else if (box.Name == "curHealthText")
                    {
                        box.Text = character.getCurHealth().ToString();
                    }
                    else if (box.Name == "maxHealthText")
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
                }
            }
        }

        public void fillMonsterList(ListBox list)
        {
            foreach (Monster monster in monsters)
            {
                list.Items.Add(monster.getName() + " - LVL " + monster.getDifficultyLevel().ToString());
            }
        }

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
                        box.Text = monster.getType();
                    }
                    else if (box.Name == "nameText")
                    {
                        box.Text = monster.getName();
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

        public void close()
        {
            simGUI.Hide();
            simGUI = null;
            config.show();
        }
    }
}
