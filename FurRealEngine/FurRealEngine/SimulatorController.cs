using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurRealEngine
{
    public enum ENVIRONMENT
    {
        DUNGEON,
        CAVERN,
        FOREST
    };

    public class SimulatorController
    {
        SimulatorGUI simGUI;
        CombatRoundController roundController;
        ReportController reportController;
        ScenarioSettings scenario;
        SceneSettings scene;
        List<Character> characters;
        List<Monster> monsters;
        ConfigController config;
        int runNum = 1;
        int curLevel;
        bool playersTurn = true;
        int currentCharacter = 0;
        int target = 0;

        //Static variables that rollover each run for Report
        public static int monstersDefeated;
        public static int charactersDefeated;
        public static int levelsCompleted;
        public static int totalDamageGiven;
        public static int totalDamageTaken;
        public static int treasure;

        static Random rand = new Random();

        public SimulatorController(ScenarioSettings scenario, SceneSettings scene, List<Character> characters, List<Monster> monsters, ConfigController config)
        {
            this.scenario = scenario;
            this.scene = scene;
            this.characters = characters;
            this.monsters = monsters;
            this.config = config;
            SimulatorController.monstersDefeated = 0;
            SimulatorController.charactersDefeated = 0;
            SimulatorController.levelsCompleted = 0;
            SimulatorController.totalDamageGiven = 0;
            SimulatorController.totalDamageTaken = 0;
            SimulatorController.treasure = 0;
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
            simGUI.setSettings(scenario.difficulty, curLevel, runNum, treasure);
            AudioController.playFerocity();
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

        // after every attack, hightlight the current attacker and target
        public void selectCharacters(ListBox characterList, GroupBox characterGroup, PictureBox characterPicture, ListBox monsterList, GroupBox monsterGroup, PictureBox monsterPicture, Button meleeButton, Button spellButton, Button continueButton)
        {
            // if players turn, highlight current character and target monster
            if (playersTurn)
            {
                characterList.SelectedIndex = currentCharacter;
                if (!characters[currentCharacter].isCharacterPlayable() && target < monsterList.Items.Count)
                {
                    monsterList.SelectedIndex = target;
                }
            }
            // if enemys turn, highlight current monster and target character
            else
            {
                if (target < characterList.Items.Count)
                {
                    characterList.SelectedIndex = target;
                }
                monsterList.SelectedIndex = currentCharacter;
            }
            characterIndexChanged(characterList, characterGroup, characterPicture, meleeButton, spellButton, continueButton);
            monsterIndexChanged(monsterList, monsterGroup, monsterPicture);
        }

        // if a new character is selected
        public void characterIndexChanged(ListBox characterList, GroupBox characterGroup, PictureBox characterPicture, Button meleeButton, Button spellButton, Button continueButton)
        {
            if (characterList.Items.Count > 0)
            {
                // if the selection was deselected, force the first character to be selected
                if (characterList.SelectedIndex < 0)
                {
                    characterList.SelectedIndex = 0;
                }
                // if players turn, force the current character to be selected
                if (playersTurn)
                {
                    characterList.SelectedIndex = currentCharacter;
                }
                // if enemys turn, force the target characger to be selected
                else
                {
                    characterList.SelectedIndex = target;
                }
            }
            fillCharacterGroup(characterGroup, characterList.SelectedIndex);
            setCharacterPicture(characterPicture, characterList.SelectedIndex);
            activateAttackButtons(meleeButton, spellButton, continueButton, characterList.SelectedIndex);
        }

        // if a new monster is selected
        public void monsterIndexChanged(ListBox monsterList, GroupBox monsterGroup, PictureBox monsterPicture)
        {
            if (monsterList.Items.Count > 0)
            {
                // if the selection was deselected, force the first monster to be selected
                if (monsterList.SelectedIndex < 0)
                {
                    monsterList.SelectedIndex = 0;
                }
                // if enemys turn, force the current monster to be selected
                if (!playersTurn)
                {
                    monsterList.SelectedIndex = currentCharacter;
                }
                // if players turn and current character is not playable,
                // force target monster to be selected
                else if (!characters[currentCharacter].isCharacterPlayable())
                {
                    monsterList.SelectedIndex = target;
                }
                // otherwise, leave the user selection alone
            }
            fillMonsterGroup(monsterGroup, monsterList.SelectedIndex);
            setMonsterPicture(monsterPicture, monsterList.SelectedIndex);
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
        private void fillCharacterGroup(GroupBox group, int index)
        {
            if (characters.Count > 0 && index >= 0 && index < characters.Count)
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
                    else if (box.Name == "professionLevelText")
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

        private void setCharacterPicture(PictureBox characterPicture, int character)
        {
            if (character >= 0)
            {
                switch (characters[character].getProfessionName())
                {
                    case "Soldier":
                        characterPicture.BackgroundImage = Properties.Resources.soldier;
                        break;
                    case "Combat Mage":
                        characterPicture.BackgroundImage = Properties.Resources.combat_mage;
                        break;
                    case "Priest":
                        characterPicture.BackgroundImage = Properties.Resources.priest;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                characterPicture.BackgroundImage = null;
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
        private void fillMonsterGroup(GroupBox group, int index)
        {
            if (monsters.Count > 0 && index >= 0 && index < monsters.Count)
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

        private void setMonsterPicture(PictureBox monsterPicture, int monster)
        {
            if (monster >= 0)
            {
                switch (monsters[monster].getVariantName())
                {
                    case "Kobold":
                        monsterPicture.BackgroundImage = Properties.Resources.kobold;
                        break;
                    case "Goblin":
                        monsterPicture.BackgroundImage = Properties.Resources.goblin;
                        break;
                    case "Orc":
                        monsterPicture.BackgroundImage = Properties.Resources.orc;
                        break;
                    case "Bugbear":
                        monsterPicture.BackgroundImage = Properties.Resources.bugbear;
                        break;
                    case "Skeleton":
                        monsterPicture.BackgroundImage = Properties.Resources.skeleton;
                        break;
                    case "Zombie":
                        monsterPicture.BackgroundImage = Properties.Resources.zombie;
                        break;
                    case "Ghost":
                        monsterPicture.BackgroundImage = Properties.Resources.ghost;
                        break;
                    case "Vampire":
                        monsterPicture.BackgroundImage = Properties.Resources.vampire;
                        break;
                    case "Lich":
                        monsterPicture.BackgroundImage = Properties.Resources.lich;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                monsterPicture.BackgroundImage = null;
            }
        }

        // enable/disable attack buttons based on profession of selected character
        private void activateAttackButtons(Button meleeButton, Button spellButton, Button continueButton, int character)
        {
            // only enable attack button if players turn and current character is playable
            if (playersTurn && character >= 0 && characters[character].isCharacterPlayable())
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
                continueButton.Enabled = false;
            }
            // otherwise, only enable 'continue'
            else
            {
                meleeButton.Enabled = false;
                spellButton.Enabled = false;
                continueButton.Enabled = true;
            }
        }

        public void automateMove(ListBox charList, ListBox monsterList, GroupBox monsterGroup, PictureBox monsterPicture, Label playerTurnLabel, Label enemyTurnLabel)
        {
            if (playersTurn)
            {
                charList.SelectedIndex = currentCharacter;
                Character character = characters[currentCharacter];
                if (character.isCharacterPlayable())
                {
                    return;
                }
                if (character.getProfession() == PROFESSION.SOLDIER)
                {
                    meleeAttack(charList, monsterList, monsterGroup, monsterPicture, playerTurnLabel, enemyTurnLabel);
                }
                else if (character.getProfession() == PROFESSION.MAGE)
                {
                    spellAttack(charList, monsterList, monsterGroup, monsterPicture, playerTurnLabel, enemyTurnLabel);
                }
                else
                {
                    if (rand.Next() % 10 > 5)
                    {
                        meleeAttack(charList, monsterList, monsterGroup, monsterPicture, playerTurnLabel, enemyTurnLabel);
                    }
                    else
                    {
                        spellAttack(charList, monsterList, monsterGroup, monsterPicture, playerTurnLabel, enemyTurnLabel);
                    }
                }
            }
            else
            {
                Monster monster = monsters[currentCharacter];
                roundController.monsterAttack(target, currentCharacter);
                checkForDeath();
                currentCharacter++;
                checkForEndOfLevel();
                if (currentCharacter >= monsterList.Items.Count)
                {
                    playersTurn = !playersTurn;
                    currentCharacter = 0;
                    playerTurnLabel.Visible = true;
                    enemyTurnLabel.Visible = false;
                }
            }
        }

        public void meleeAttack(ListBox characterList, ListBox monsterList, GroupBox monsterGroup, PictureBox monsterPicture, Label playerTurnLabel, Label enemyTurnLabel)
        {
            int character = characterList.SelectedIndex;
            int monster = monsterList.SelectedIndex;
            if (monsterList.Items.Count > 0 && characterList.Items.Count > 0)
            {
                if (character >= 0 && monster >= 0)
                {
                    roundController.meleeAttack(character, monster);
                    checkForDeath();
                    checkForEndOfLevel();
                    fillMonsterGroup(monsterGroup, monsterList.SelectedIndex);
                    setMonsterPicture(monsterPicture, monsterList.SelectedIndex);
                }
            }
            if (monsterList.Items.Count == 0)
            {
                fillMonsterList(monsterList);
                monsterList.SelectedIndex = 0;
            }
            currentCharacter++;
            if (currentCharacter >= characterList.Items.Count)
            {
                playersTurn = !playersTurn;
                currentCharacter = 0;
                playerTurnLabel.Visible = false;
                enemyTurnLabel.Visible = true;
            }
            else
            {
                characterList.SelectedIndex = currentCharacter;
            }
        }

        public void spellAttack(ListBox characterList, ListBox monsterList, GroupBox monsterGroup, PictureBox monsterPicture, Label playerTurnLabel, Label enemyTurnLabel)
        {
            int character = characterList.SelectedIndex;
            int monster = monsterList.SelectedIndex;
            if (monsterList.Items.Count > 0 && characterList.Items.Count > 0)
            {
                if (character >= 0 && monster >= 0)
                {
                    roundController.spellAttack(character, monster);
                    checkForDeath();
                    checkForEndOfLevel();
                    fillMonsterGroup(monsterGroup, monsterList.SelectedIndex);
                    setMonsterPicture(monsterPicture, monsterList.SelectedIndex);
                }
            }
            if (monsterList.Items.Count == 0)
            {
                fillMonsterList(monsterList);
                monsterList.SelectedIndex = 0;
            }
            currentCharacter++;
            if (currentCharacter >= characterList.Items.Count)
            {
                playersTurn = !playersTurn;
                currentCharacter = 0;
                playerTurnLabel.Visible = false;
                enemyTurnLabel.Visible = true;
            }
            else
            {
                characterList.SelectedIndex = currentCharacter;
            }
        }

        // look for any character/monster health that hit zero or below
        // and remove them from the list
        public void checkForDeath()
        {
            for (int i = monsters.Count - 1; i >= 0; --i)
            {
                if (monsters[i].getCurHealth() <= 0)
                {
                    simGUI.removeFromMonsterList(i);
                    monsters.RemoveAt(i);
                    monstersDefeated++;
                }
            }
            for (int i = characters.Count - 1; i >= 0; --i)
            {
                if(characters[i].getCurHealth() <= 0)
                {
                    simGUI.removeFromCharacterList(i);
                    characters.RemoveAt(i);
                    charactersDefeated++;
                }
            }
        }

        // check if every monster is dead
        // if so, reload characters/monsters for next level
        // close sim when all levels have finished
        public void checkForEndOfLevel()
        {
            if (characters.Count == 0)
            {
                close();
            }
            if (monsters.Count == 0)
            {
                treasure += 100 * curLevel;
                curLevel++;
                playersTurn = true;
                currentCharacter = 0;
                if (curLevel > scenario.endLevel)
                {
                    SimulatorController.levelsCompleted++;
                    curLevel = scenario.startLevel;
                    runNum++;
                    if (runNum > scenario.numberOfRuns)
                    {
                        close();
                    }
                    treasure = 0;
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
                if (simGUI != null)
                {
                    simGUI.setSettings(scenario.difficulty, curLevel, runNum, treasure);
                }
            }
        }

        // set background image based on environment
        public void setBackground()
        {
            if (scene.environment == ENVIRONMENT.DUNGEON)
            {
                simGUI.BackgroundImage = Properties.Resources.dungeon;
            }
            else if (scene.environment == ENVIRONMENT.CAVERN)
            {
                simGUI.BackgroundImage = Properties.Resources.cavern;
            }
            else if (scene.environment == ENVIRONMENT.FOREST)
            {
                simGUI.BackgroundImage = Properties.Resources.forest;
            }
        }

        private void initializeSimulationReport()
        {
            reportController = new ReportController(scenario, scene, config);
        }

        // when all levels have finished, return to the config gui
        public void close()
        {
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
            if (simGUI != null)
            {
                simGUI.Hide();
            }
            simGUI = null;
            initializeSimulationReport();
        }
    }
}
