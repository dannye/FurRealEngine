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

        public static int diceRoll(int numRolls, int sides)
        {
            int result = 0;
            for (int i = 0; i < numRolls; ++i)
            {
                result += (rand.Next() % sides) + 1;
            }
            return result;
        }

        public void meleeAttack(int character, int monster)
        {
            int damage = 0;
            int toHit = 0;
            int attackDef = getPhysAttackDef(monster);

            if (character >= 0 && monster >= 0)
            {
                Character c = characters[character];
                if (c.getProfessionName() == "Soldier")
                {
                    toHit = diceRoll(1, 20) + (2 * c.getLevel()) + c.getStrMod();
                    if (toHit >= 20)
                    {
                        damage = 12 + c.getLevel();
                    }
                    else if (toHit >= attackDef)
                    {
                        damage = diceRoll(1, 12) + c.getLevel();
                    }
                    if (monsters[monster].getVariantName() == "Ghost")
                    {
                        damage = 0;
                    }
                    monsters[monster].setCurHealth(monsters[monster].getCurHealth() - damage);
                }
                else if (c.getProfessionName() == "Priest")
                {
                    toHit = diceRoll(1, 20) + (2 * c.getLevel()) + c.getWisMod();
                    if (toHit >= 20)
                    {
                        damage = 12 + c.getLevel();
                    }
                    else if (toHit >= attackDef)
                    {
                        damage = diceRoll(2, 6) + c.getLevel();
                    }
                    if (monsters[monster].getVariantName() == "Ghost")
                    {
                        damage = 0;
                    }
                    monsters[monster].setCurHealth(monsters[monster].getCurHealth() - damage);
                }
            }
            SimulatorController.totalDamageGiven += damage;
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
                        for (int i = 0; i < monsters.Count; ++i)
                        {
                            if (i != monster)
                            {
                                damage = diceRoll(2, 4);
                                monsters[i].setCurHealth(monsters[i].getCurHealth() - damage);
                                SimulatorController.totalDamageGiven += damage;
                            }
                        }
                        damage = diceRoll(2, 8) + c.getLevel();
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
                    if (monsters[monster].getTypeName() == "Undead")
                    {
                        attackDef -= 10;
                    }
                    if (toHit >= 20)
                    {
                        for (int i = 0; i < monsters.Count; ++i)
                        {
                            if (i != monster)
                            {
                                damage = diceRoll(1, 4);
                                monsters[i].setCurHealth(monsters[i].getCurHealth() - damage);
                                SimulatorController.totalDamageGiven += damage;
                            }
                        }
                        damage = diceRoll(2, 6) + c.getLevel();
                    }
                    else if (toHit >= attackDef)
                    {
                        damage = diceRoll(2, 6) + c.getLevel();
                    }
                    monsters[monster].setCurHealth(monsters[monster].getCurHealth() - damage);
                }
            }
            SimulatorController.totalDamageGiven += damage;
        }

        public void monsterAttack(int character, int monster)
        {
            int damage = 0;
            int toHit = 0;
            int attackDef = 0;
            if (monsters[monster].getTypeName() == "Humanoid")
            {
                toHit = diceRoll(1, 20) + monsters[monster].getDifficultyLevel();
                attackDef = getCharacterPhysAttackDef(character);
                if (toHit >= 20)
                {
                    damage = 6 + monsters[monster].getDifficultyLevel();
                }
                else if (toHit >= attackDef)
                {
                    damage = diceRoll(1, 6) + monsters[monster].getDifficultyLevel();
                }
                characters[character].setCurHealth(characters[character].getCurHealth() - damage);
            }
            else
            {
                toHit = diceRoll(1, 20) + monsters[monster].getDifficultyLevel();
                if (monsters[monster].getVariantName() == "Lich")
                {
                    attackDef = getCharacterMagicAttackDef(character);
                }
                else
                {
                    attackDef = getCharacterPhysAttackDef(character);
                }
                if (characters[character].getProfession() == PROFESSION.PRIEST)
                {
                    attackDef += characters[character].getLevel();
                }
                if (toHit >= 20)
                {
                    if (monsters[monster].getVariantName() == "Lich")
                    {
                        for (int i = 0; i < characters.Count; ++i)
                        {
                            if (i != character)
                            {
                                damage = diceRoll(1, 4);
                                characters[i].setCurHealth(characters[i].getCurHealth() - damage);
                                SimulatorController.totalDamageTaken += damage;
                            }
                        }
                    }
                    damage = 8 + monsters[monster].getDifficultyLevel();
                }
                else if (toHit >= attackDef)
                {
                    damage = diceRoll(2, 4) + monsters[monster].getDifficultyLevel();
                }
                characters[character].setCurHealth(characters[character].getCurHealth() - damage);
            }
            SimulatorController.totalDamageTaken += damage;
        }

        private int getPhysAttackDef(int monster)
        {
            int attackDef = 0;
            if (monster >= 0)
            {
                if (monsters[monster].getTypeName() == "Humanoid")
                {
                    attackDef = diceRoll(1, 20) + (2 * monsters[monster].getDifficultyLevel());
                }
                else
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
                if (monsters[monster].getTypeName() == "Humanoid")
                {
                    attackDef = diceRoll(1, 20) - 5 + monsters[monster].getDifficultyLevel();
                }
                else
                {
                    attackDef = diceRoll(1, 20) + monsters[monster].getDifficultyLevel();
                }
            }
            return attackDef;
        }

        private int getCharacterPhysAttackDef(int character)
        {
            int attackDef = 0;
            if (characters[character].getProfession() == PROFESSION.SOLDIER)
            {
                attackDef = diceRoll(1, 20) + 2 * characters[character].getLevel() + characters[character].getDexMod();
            }
            else if (characters[character].getProfession() == PROFESSION.MAGE)
            {
                attackDef = diceRoll(1, 20) + characters[character].getDexMod();
            }
            else
            {
                attackDef = diceRoll(1, 20) + characters[character].getDexMod();
            }
            return attackDef;
        }

        private int getCharacterMagicAttackDef(int character)
        {
            int attackDef = 0;
            if (characters[character].getProfession() == PROFESSION.SOLDIER)
            {
                attackDef = diceRoll(1, 20) + characters[character].getIntMod();
            }
            else if (characters[character].getProfession() == PROFESSION.MAGE)
            {
                attackDef = diceRoll(1, 20) + 2 * characters[character].getLevel() + characters[character].getIntMod();
            }
            else
            {
                attackDef = diceRoll(1, 20) + 2 * characters[character].getLevel() + characters[character].getIntMod();
            }
            return attackDef;
        }
    }
}
