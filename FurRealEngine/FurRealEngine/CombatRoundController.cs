using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    public class CombatRoundController
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

        public void setCharacters(List<Character> characters)
        {
            this.characters = characters;
        }

        public void setMonsters(List<Monster> monsters)
        {
            this.monsters = monsters;
        }

        public void meleeAttack(int character, int monster)
        {
            int damage = 0;
            int toHit = 0;
            int attackDef = 0;

            if (character >= 0 && monster >= 0)
            {
                Character c = characters[character];
                if (c.getProfessionName() == "Soldier")
                {
                    toHit = diceRoll(1, 20) + (2 * c.getLevel()) + c.getStrMod();
                    attackDef = getPhysAttackDef(monster);
                    if (toHit >= 20)
                    {
                        damage = 12 + c.getLevel();
                    }
                    else if (toHit >= attackDef)
                    {
                        damage = diceRoll(1, 12) + c.getLevel();
                    }
                    monsters[monster].setCurHealth(monsters[monster].getCurHealth() - damage);
                }
                else if (c.getProfessionName() == "Priest")
                {
                    toHit = diceRoll(1, 20) + (2 * c.getLevel()) + c.getWisMod();
                    attackDef = getPhysAttackDef(monster);
                    if (toHit >= 20)
                    {
                        damage = 6 + c.getLevel();
                    }
                    else if (toHit >= attackDef)
                    {
                        damage = diceRoll(2, 6) + c.getLevel();
                    }
                    monsters[monster].setCurHealth(monsters[monster].getCurHealth() - damage);
                }
            }
        }

        public void spellAttack(int character, int monster)
        {
            int damage = 0;
            int toHit = 0;
            int attackDef = 0;
            if (character >= 0 && monster >= 0)
            {
                Character c = characters[character];
                if (c.getProfessionName() == "Combat Mage")
                {
                    toHit = diceRoll(1, 20) + (2 * c.getLevel()) + c.getIntMod();
                    attackDef = getMagicAttackDef(monster);
                    if (toHit >= 20)
                    {
                        damage = 8 + c.getLevel();
                    }
                    else if (toHit >= attackDef)
                    {
                        damage = diceRoll(2, 8) + c.getLevel();
                    }
                    monsters[monster].setCurHealth(monsters[monster].getCurHealth() - damage);
                }
                else if (c.getProfessionName() == "Priest")
                {
                    toHit = diceRoll(1, 20) + (2 * c.getLevel()) + c.getWisMod();
                    attackDef = getPhysAttackDef(monster);
                    if (toHit >= 20)
                    {
                        damage = 6 + c.getLevel();
                    }
                    else if (toHit >= attackDef)
                    {
                        damage = diceRoll(2, 6) + c.getLevel();
                    }
                    monsters[monster].setCurHealth(monsters[monster].getCurHealth() - damage);
                }
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

        private int getPhysAttackDef(int monster)
        {
            int attackDef = 0;
            if (monster >= 0)
            {
                if (monsters[monster].getType() == "Humanoid")
                {
                    attackDef = diceRoll(1, 20) + (2 * monsters[monster].getDifficultyLevel());
                }
                else if (monsters[monster].getType() == "Undead")
                {
                    attackDef = diceRoll(1, 10) + (2 * monsters[monster].getDifficultyLevel());
                }
            }
            return attackDef;
        }

        private int getMagicAttackDef(int monster)
        {
            int attackDef = 0;
            if (monster >= 0)
            {
                if (monsters[monster].getType() == "Humanoid")
                {
                    attackDef = diceRoll(1, 20) - 5 + monsters[monster].getDifficultyLevel();
                }
                else if (monsters[monster].getType() == "Undead")
                {
                    attackDef = diceRoll(1, 20) + monsters[monster].getDifficultyLevel();
                }
            }
            return attackDef;
        }
    }
}
