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

        private static int COMBAT_MAGE = 1;
        private static int SOLDIER = 2;
        private static int PRIEST = 3;

        public ConfigController()
        {
            characters = new List<Character>();
            monsters = new List<Monster>();
        }

        public void setScene(int level, string environment, int challengeDifficulty, List<string> monsterTypes)
        {
            this.scene = new SceneSettings(level, environment, challengeDifficulty, monsters, characters);
        }

        public void setScenario(ScenarioSettings scenario)
        {
            this.scenario = scenario;
        }

        private void initializeMonsters(List<string> monsterTypes)
        {
            foreach (string type in monsterTypes)
            {
                Monster monster = new Monster(type);
                monsters.Add(monster);
            }
        }

        public bool areSettingsValid()
        {
            return false;
        }

        public int getProfessionIdentifier(string profession)
        {
            if (profession.Equals("Combat Mage"))
            {
                return COMBAT_MAGE;
            }

            if (profession.Equals("Soldier"))
            {
                return SOLDIER;
            }
            return PRIEST;
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
                    character.setIsPlayable(true);
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
