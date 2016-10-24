using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurRealEngine;

namespace FurRealEngine
{
    enum PROFESSION
    {
        SOLDIER,
        MAGE,
        PRIEST
    };

    enum HEAL_OPTION
    {
        NEVER,
        ON_DEATH,
        ALWAYS
    };

    class Character
    {
        int identifier;
        PROFESSION profession;
        HEAL_OPTION healOption;
        int maxHealth;
        int curHealth;
        uint strength;
        uint intelligence;
        uint wisdom;
        uint dexterity;
        uint constitution;
        bool playable;
        int initiative;

        public Character()
        {
            profession = PROFESSION.SOLDIER;
            healOption = HEAL_OPTION.NEVER;
            playable = false;
            strength = SimulatorController.diceRoll(3, 6);
            intelligence = SimulatorController.diceRoll(3, 6);
            wisdom = SimulatorController.diceRoll(3, 6);
            dexterity = SimulatorController.diceRoll(3, 6);
            constitution = SimulatorController.diceRoll(3, 6);
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
            return this.playable;
        }

        public void setPlayable(bool playable)
        {
            this.playable = playable;
        }

        public int getIdentifier()
        {
            return this.identifier;
        }

        public void setIdentifier(int identifier)
        {
            this.identifier = identifier;
        }

        public PROFESSION getProfession()
        {
            return this.profession;
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

        public uint getStrength()
        {
            return strength;
        }

        public void setStrength(uint str)
        {
            strength = str;
        }

        public uint getIntelligence()
        {
            return intelligence;
        }

        public void setIntelligence(uint intelligence)
        {
            this.intelligence = intelligence;
        }

        public uint getWisdom()
        {
            return wisdom;
        }

        public void setWisdom(uint wis)
        {
            wisdom = wis;
        }

        public uint getDexterity()
        {
            return dexterity;
        }

        public void setDexterity(uint dex)
        {
            dexterity = dex;
        }

        public uint getConstitution()
        {
            return constitution;
        }

        public void setConstitution(uint constitution)
        {
            this.constitution = constitution;
        }
    }
}
