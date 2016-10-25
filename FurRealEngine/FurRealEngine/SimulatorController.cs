using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurRealEngine
{
    class SimulatorController
    {
        ScenarioSettings scenario;
        SceneSettings scene;
        List<Character> characters;
        List<Monster> monsters;

        static Random rand = new Random();

        public SimulatorController(ScenarioSettings scenario, SceneSettings scene, List<Character> characters, List<Monster> monsters)
        {
            this.scenario = scenario;
            this.scene = scene;
            this.characters = characters;
            this.monsters = monsters;
        }

        public static uint diceRoll(uint numRolls, uint sides)
        {
            uint result = 0;
            for (int i = 0; i < numRolls; ++i)
            {
                result += ((uint)rand.Next() % sides) + 1;
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

        public void fillCharacterGroup(GroupBox group)
        {
            if (characters.Count() > 0)
            {
                Character character = characters.First();
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

        public void fillMonsterGroup(GroupBox group)
        {
            if (monsters.Count() > 0)
            {
                Monster monster = monsters.First();
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
    }
}
