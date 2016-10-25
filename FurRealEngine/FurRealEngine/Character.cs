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

        public Character()
        {
            profession = PROFESSION.SOLDIER;
            healOption = HEAL_OPTION.NEVER;
            level = 5;
            playable = false;
            strength = SimulatorController.diceRoll(3, 6);
            intelligence = SimulatorController.diceRoll(3, 6);
            wisdom = SimulatorController.diceRoll(3, 6);
            dexterity = SimulatorController.diceRoll(3, 6);
            constitution = SimulatorController.diceRoll(3, 6);
            if (profession == PROFESSION.SOLDIER)
            {
                
            }
        }

        public Character(PROFESSION prof, HEAL_OPTION heal, bool playable)
        : this()
        {
            setProfession(prof);
            setHealOption(heal);
            setPlayable(playable);
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

        public int getLevel()
        {
            return level;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public int getCurHealth()
        {
            return curHealth;
        }

        public int getMaxHealth()
        {
            return maxHealth;
        }

        public bool isCharacterPlayable()
        {
            return playable;
        }

        public void setPlayable(bool playable)
        {
            this.playable = playable;
        }

        public int getIdentifier()
        {
            return identifier;
        }

        public void setIdentifier(int identifier)
        {
            this.identifier = identifier;
        }

        public PROFESSION getProfession()
        {
            return profession;
        }

        public void setProfession(PROFESSION profession)
        {
            this.profession = profession;
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

        public void setIntelligence(int intelligence)
        {
            this.intelligence = intelligence;
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

        public void setConstitution(int constitution)
        {
            this.constitution = constitution;
        }
    }
}
