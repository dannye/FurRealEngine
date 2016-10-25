using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    class ConfigController
    {

        private SceneSettings scene;
        private ScenarioSettings scenario;
        private List<Character> characters;
        private List<Monster> monsters;
        private User user;

        public ConfigController()
        {
            characters = new List<Character>();
            monsters = new List<Monster>();
        }

        public void initSimulation(List<string> monsterTypes)
        {
            initializeMonsters(monsterTypes);
            autoAssignMissingProfessions();
            autoFillMonstersToMatchCD();
            SimulatorGUI simGui = new SimulatorGUI(scenario, scene, characters, monsters);
        }

        public void setActiveUser(User user)
        {
            this.user = user;
        }

        public void setScene(int level, string environment, int challengeDifficulty, List<string> monsterTypes)
        {
            this.scene = new SceneSettings(level, environment.ToLower(), challengeDifficulty);
        }

        public void setScenario(ScenarioSettings scenario)
        {
            this.scenario = scenario;
        }

        private void initializeMonsters(List<string> monsterTypes)
        {
            foreach (string type in monsterTypes)
            {
                VARIANT variant = Monster.getVariant(type);
                Monster monster = new Monster(variant);
                monsters.Add(monster);
            }
        }

        private void autoFillMonstersToMatchCD()
        {
            //TODO: will determine how many/which monsters need added to the monster list
            //      to fill the remainder of entered CD the the monsters list couldn't fill
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
            return this.characters;
        }

        public void assignProfession(int identifier, string profession)
        {
            foreach (Character character in characters)
            {
                if (character.getIdentifier() == identifier)
                {
                    character.setProfession(getProfessionIdentifier(profession));
                }
            }
        }

        public void assignProfession(Character character, PROFESSION profession)
        {
            character.setProfession(profession);
        }

        private void autoAssignMissingProfessions()
        {
            Random rng = new Random();
            foreach (Character character in characters)
            {
                if (character.getProfession() == 0)
                {
                    assignProfession(character, (PROFESSION)rng.Next(0, 2 + 1));
                }
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

        public void checkForListUpdate(int listBoxLength)
        {
            if (listBoxLength < characters.Count)
            {
                List<Character> charactersToRemove = new List<Character>();
                foreach (Character character in characters)
                {
                    if (character.getIdentifier() > listBoxLength)
                    {
                        charactersToRemove.Add(character);
                    }
                }
                removeCharacter(charactersToRemove);
            }
        }

        private void removeCharacter(List<Character> charactersToRemove)
        {
            foreach (Character character in charactersToRemove)
            {
                characters.Remove(character);
            }
        }

    }
}
