using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurRealEngine;

namespace FurRealEngine
{
    public enum PROFESSION
    {
        SOLDIER,
        MAGE,
        PRIEST
    };

    public enum HEAL_OPTION
    {
        NEVER,
        ON_DEATH,
        ALWAYS
    };

    public class Character
    {
        int identifier;
        PROFESSION profession;
        HEAL_OPTION healOption;
        int level;
        int maxHealth;
        int curHealth;
        int strength;
        int intelligence;
        int wisdom;
        int dexterity;
        int constitution;
        bool playable;
        int initiative;

        public Character clone()
        {
            Character c = new Character();
            c.identifier = identifier;
            c.profession = profession;
            c.healOption = healOption;
            c.level = level;
            c.maxHealth = maxHealth;
            c.curHealth = curHealth;
            c.strength = strength;
            c.intelligence = intelligence;
            c.wisdom = wisdom;
            c.dexterity = dexterity;
            c.constitution = constitution;
            c.playable = playable;
            c.initiative = initiative;
            return c;
        }

        public Character(PROFESSION prof = PROFESSION.SOLDIER)
        {
            init(prof);
        }

        public Character(string prof)
        {
            init(stringToProfession(prof));
        }

        private void init(PROFESSION prof)
        {
            level = 5;
            strength = SimulatorController.diceRoll(3, 6);
            intelligence = SimulatorController.diceRoll(3, 6);
            wisdom = SimulatorController.diceRoll(3, 6);
            dexterity = SimulatorController.diceRoll(3, 6);
            constitution = SimulatorController.diceRoll(3, 6);
            setProfession(prof);
            setHealOption(HEAL_OPTION.NEVER);
            setPlayable(false);
            calcHealth();
            if (profession == PROFESSION.SOLDIER)
            {
                if (strength < 13)
                {
                    strength = 13;
                }
                if (dexterity < 13)
                {
                    dexterity = 13;
                }
                if (constitution < 10)
                {
                    constitution = 10;
                }
                initiative = SimulatorController.diceRoll(1, 20) + 1 + getWisMod();
            }
            else if (profession == PROFESSION.MAGE)
            {
                if (intelligence < 13)
                {
                    intelligence = 13;
                }
                if (constitution < 13)
                {
                    constitution = 13;
                }
                if (wisdom < 10)
                {
                    wisdom = 10;
                }
                initiative = SimulatorController.diceRoll(1, 20) - 3 + getWisMod();
            }
            else if (profession == PROFESSION.PRIEST)
            {
                if (intelligence < 13)
                {
                    intelligence = 13;
                }
                if (wisdom < 13)
                {
                    wisdom = 13;
                }
                initiative = SimulatorController.diceRoll(1, 20) + getWisMod();
            }
        }

        public string getProfessionName()
        {
            string prof = "";
            if (profession == PROFESSION.SOLDIER)
            {
                prof = "Soldier";
            }
            else if (profession == PROFESSION.MAGE)
            {
                prof = "Combat Mage";
            }
            else if (profession == PROFESSION.PRIEST)
            {
                prof = "Priest";
            }
            return prof;
        }

        public static PROFESSION stringToProfession(string profession)
        {
            if (profession == "Combat Mage")
            {
                return PROFESSION.MAGE;
            }

            if (profession == "Soldier")
            {
                return PROFESSION.SOLDIER;
            }
            return PROFESSION.PRIEST;
        }

        private void calcHealth()
        {
            if (profession == PROFESSION.SOLDIER)
            {
                maxHealth = curHealth = SimulatorController.diceRoll(level, 12) + 10 + getConMod();
            }
            else if (profession == PROFESSION.MAGE)
            {
                maxHealth = curHealth = SimulatorController.diceRoll(level, 6) + 4 + getConMod();
            }
            else if (profession == PROFESSION.PRIEST)
            {
                maxHealth = curHealth = SimulatorController.diceRoll(level, 8) + 8 + getConMod();
            }
        }

        public int getLevel()
        {
            return level;
        }

        public void setLevel(int level)
        {
            this.level = level;
            calcHealth();
        }

        public int getCurHealth()
        {
            return curHealth;
        }

        public void setCurHealth(int health)
        {
            curHealth = health;
        }

        public int getMaxHealth()
        {
            return maxHealth;
        }

        public void setMaxHealth(int health)
        {
            maxHealth = health;
        }

        public bool isCharacterPlayable()
        {
            return playable;
        }

        public void setPlayable(bool play)
        {
            playable = play;
        }

        public int getIdentifier()
        {
            return identifier;
        }

        public void setIdentifier(int id)
        {
            identifier = id;
        }

        public PROFESSION getProfession()
        {
            return profession;
        }

        public void setProfession(PROFESSION prof)
        {
            profession = prof;
        }

        public HEAL_OPTION getHealOption()
        {
            return healOption;
        }

        public void setHealOption(HEAL_OPTION heal)
        {
            healOption = heal;
        }

        public int getStrength()
        {
            return strength;
        }

        public void setStrength(int str)
        {
            strength = str;
        }

        public int getIntelligence()
        {
            return intelligence;
        }

        public void setIntelligence(int intel)
        {
            intelligence = intel;
        }

        public int getWisdom()
        {
            return wisdom;
        }

        public void setWisdom(int wis)
        {
            wisdom = wis;
        }

        public int getDexterity()
        {
            return dexterity;
        }

        public void setDexterity(int dex)
        {
            dexterity = dex;
        }

        public int getConstitution()
        {
            return constitution;
        }

        public void setConstitution(int con)
        {
            constitution = con;
        }

        public int getStrMod()
        {
            return getStatMod(strength);
        }

        public int getIntMod()
        {
            return getStatMod(intelligence);
        }

        public int getWisMod()
        {
            return getStatMod(wisdom);
        }

        public int getDexMod()
        {
            return getStatMod(dexterity);
        }

        public int getConMod()
        {
            return getStatMod(constitution);
        }

        private int getStatMod(int stat)
        {
            int statMod = 0;
            if (stat < 3)
            {
                statMod = -5;
            }
            else if (stat >= 3 && stat <= 5)
            {
                statMod = -3;
            }
            else if (stat >= 6 && stat <= 9)
            {
                statMod = -1;
            }
            else if (stat >= 10 && stat <= 12)
            {
                statMod = 0;
            }
            else if (stat >= 13 && stat <= 15)
            {
                statMod = 1;
            }
            else if (stat >= 16 && stat <= 18)
            {
                statMod = 3;
            }
            else if (stat > 18)
            {
                statMod = 5;
            }
            return statMod;
        }
    }
}
