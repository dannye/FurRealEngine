using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    class CombatRoundController
    {
        ScenarioSettings scenario;
        SceneSettings scene;
        List<Character> characters;
        List<Monster> monsters;

        static Random rand = new Random();
        public CombatRoundController(ScenarioSettings scenario, SceneSettings scene, List<Character> characters, List<Monster> monsters)
        {
            this.scenario = scenario;
            this.scene = scene;
            this.characters = characters;
            this.monsters = monsters;
        }
        public void meleeAttack(int character, int monster)
        {
            //add real level once Zach adds it to his class
            int lvl = 1;
            int damage = 0;
            int toHit = 0;
            int attackDef = 0;

            if (characters[character].getProfessionName() == "Soldier")
            {
                toHit = (int)diceRoll(1, 20) + (2 * lvl) + getStrMod(character);
                attackDef = getPhysAttackDef(monster);
                if (toHit >= 20)
                {
                    damage = 12 + lvl;
                }
                else if (toHit >= attackDef)
                {
                    damage = (int)diceRoll(1, 12) + lvl;
                }
                monsters[monster].setCurHealth(monsters[monster].getCurHealth() - (uint)damage);
            }
            else if (characters[character].getProfessionName() == "Priest")
            {
                toHit = (int)diceRoll(1, 20) + (2 * lvl) + getWisMod(character);
                attackDef = getPhysAttackDef(monster);
                if (toHit >= 20)
                {
                    damage = 6 + lvl;
                }
                else if (toHit >= attackDef)
                {
                    damage = (int)diceRoll(2, 6) + lvl;
                }

                monsters[monster].setCurHealth(monsters[monster].getCurHealth() - (uint)damage);
            }
        }

        public void spellAttack(int character, int monster)
        {
            //add real level once Zach adds it to his class
            int lvl = 1;
            int damage = 0;
            int toHit = 0;
            int attackDef = 0;

            if (characters[character].getProfessionName() == "Combat Mage")
            {
                toHit = (int)diceRoll(1, 20) + (2 * lvl) + getIntMod(character);
                attackDef = getMagicAttackDef(monster);
                if (toHit >= 20)
                {
                    damage = 8 + lvl;
                }
                else if (toHit >= attackDef)
                {
                    damage = (int)diceRoll(2, 8) + lvl;
                }
                monsters[monster].setCurHealth(monsters[monster].getCurHealth() - (uint)damage);
            }
            else if (characters[character].getProfessionName() == "Priest")
            {
                toHit = (int)diceRoll(1, 20) + (2 * lvl) + getWisMod(character);
                attackDef = getPhysAttackDef(monster);
                if (toHit >= 20)
                {
                    damage = 6 + lvl;
                }
                else if (toHit >= attackDef)
                {
                    damage = (int)diceRoll(2, 6) + lvl;
                }
                monsters[monster].setCurHealth(monsters[monster].getCurHealth() - (uint)damage);
            }
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

        private int getStrMod(int character)
        {
            int strMod = 0;
            int strength = (int)characters[character].getStrength();
            if(strength < 3)
            {
                strMod = -5;
            }
            else if(strength >= 3 || strength <= 5)
            {
                strMod = -3;
            }
            else if(strength >= 6 || strength <= 9)
            {
                strMod = -1;
            }
            else if(strength >= 10 || strength <= 12)
            {
                strMod = 0;
            }
            else if(strength >= 13 || strength <= 15)
            {
                strMod = 1;
            }
            else if(strength >= 16 || strength <= 18)
            {
                strMod = 3;
            }
            else if(strength > 18)
            {
                strMod = 5;
            }
            return strMod;
        }

        private int getIntMod(int character)
        {
            int intMod = 0;
            int intelligence = (int)characters[character].getIntelligence();
            if (intelligence < 3)
            {
                intMod = -5;
            }
            else if (intelligence >= 3 || intelligence <= 5)
            {
                intMod = -3;
            }
            else if (intelligence >= 6 || intelligence <= 9)
            {
                intMod = -1;
            }
            else if (intelligence >= 10 || intelligence <= 12)
            {
                intMod = 0;
            }
            else if (intelligence >= 13 || intelligence <= 15)
            {
                intMod = 1;
            }
            else if (intelligence >= 16 || intelligence <= 18)
            {
                intMod = 3;
            }
            else if (intelligence > 18)
            {
                intMod = 5;
            }
            return intMod;
        }

        private int getWisMod(int character)
        {
            int wisMod = 0;
            int wisdom = (int)characters[character].getWisdom();
            if (wisdom < 3)
            {
                wisMod = -5;
            }
            else if (wisdom >= 3 || wisdom <= 5)
            {
                wisMod = -3;
            }
            else if (wisdom >= 6 || wisdom <= 9)
            {
                wisMod = -1;
            }
            else if (wisdom >= 10 || wisdom <= 12)
            {
                wisMod = 0;
            }
            else if (wisdom >= 13 || wisdom <= 15)
            {
                wisMod = 1;
            }
            else if (wisdom >= 16 || wisdom <= 18)
            {
                wisMod = 3;
            }
            else if (wisdom > 18)
            {
                wisMod = 5;
            }
            return wisMod;
        }

        private int getPhysAttackDef(int monster)
        {
            int attackDef = 0;
            if(monsters[monster].getType() == "Humanoid")
            {
                attackDef = (int)diceRoll(1, 20) + (2 * (int)monsters[monster].getDifficultyLevel());
            }
            else if(monsters[monster].getType() == "Undead")
            {
                attackDef = (int)diceRoll(1, 10) + (2 * (int)monsters[monster].getDifficultyLevel());
            }
            return attackDef;
        }

        private int getMagicAttackDef(int monster)
        {
            int attackDef = 0;
            if (monsters[monster].getType() == "Humanoid")
            {
                attackDef = (int)diceRoll(1, 20) - 5 + (int)monsters[monster].getDifficultyLevel();
            }
            else if (monsters[monster].getType() == "Undead")
            {
                attackDef = (int)diceRoll(1, 20) + (int)monsters[monster].getDifficultyLevel();
            }
            return attackDef;
        }
    }
}
