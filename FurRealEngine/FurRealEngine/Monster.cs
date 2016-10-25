using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurRealEngine;

namespace FurRealEngine
{
    public enum TYPE
    {
        HUMANOID,
        UNDEAD
    }

    public enum VARIANT
    {
        KOBOLD,
        GOBLIN,
        ORC,
        BUGBEAR,
        //////
        SKELETON,
        ZOMBIE,
        GHOST,
        VAMPIRE,
        LICH
    }

    public class Monster
    {
        TYPE type;
        VARIANT name;
        uint curHealth;
        uint maxHealth;
        int numAttacks;
        int damage;
        uint difficultyLevel;
        uint initiative;

        public Monster(VARIANT name)
        {
            this.name = name;
            if (name < VARIANT.SKELETON)
            {
                type = TYPE.HUMANOID;
            }
            else
            {
                type = TYPE.UNDEAD;
            }
            if (name == VARIANT.VAMPIRE)
            {
                numAttacks = 2;
            }
            else
            {
                numAttacks = 1;
            }
            setDifficultyLevel();
            if (type == TYPE.HUMANOID)
            {
                maxHealth = curHealth = SimulatorController.diceRoll(difficultyLevel, 4) + difficultyLevel;
                initiative = SimulatorController.diceRoll(1, 20) + difficultyLevel;
            }
            else
            {
                maxHealth = curHealth = SimulatorController.diceRoll(difficultyLevel, 6) + difficultyLevel;
                initiative = SimulatorController.diceRoll(1, 20) - 5 + difficultyLevel;
            }
        }

        public string getType()
        {
            switch(type)
            {
                case TYPE.HUMANOID:
                    return "Humanoid";
                case TYPE.UNDEAD:
                    return "Undead";
                default:
                    return "Alien";
            }
        }

        public string getName()
        {
            switch(name)
            {
                case VARIANT.KOBOLD:
                    return "Kobold";
                case VARIANT.GOBLIN:
                    return "Goblin";
                case VARIANT.ORC:
                    return "Orc";
                case VARIANT.BUGBEAR:
                    return "Bugbear";
                case VARIANT.SKELETON:
                    return "Skeleton";
                case VARIANT.ZOMBIE:
                    return "Zombie";
                case VARIANT.GHOST:
                    return "Ghost";
                case VARIANT.VAMPIRE:
                    return "Vampire";
                case VARIANT.LICH:
                    return "Lich";
                default:
                    return "Alien";
            }
        }

        public static VARIANT getVariant(string name)
        {
            switch (name)
            {
                case "Kobold":
                    return VARIANT.KOBOLD;
                case "Goblin":
                    return VARIANT.GOBLIN;
                case "Orc":
                    return VARIANT.ORC;
                case "Bugbear":
                    return VARIANT.BUGBEAR;
                case "Skeleton":
                    return VARIANT.SKELETON;
                case "Zombie":
                    return VARIANT.ZOMBIE;
                case "Ghost":
                    return VARIANT.GHOST;
                case "Vampire":
                    return VARIANT.VAMPIRE;
                case "Lich":
                    return VARIANT.LICH;
                default:
                    return VARIANT.KOBOLD;
            }
        }

        public uint getDifficultyLevel()
        {
            return difficultyLevel;
        }

        public void setDifficultyLevel()
        {
            switch(name)
            {
                case VARIANT.KOBOLD:
                    difficultyLevel = 1;
                    return;
                case VARIANT.GOBLIN:
                    difficultyLevel = 2;
                    return;
                case VARIANT.ORC:
                    difficultyLevel = 3;
                    return;
                case VARIANT.BUGBEAR:
                    difficultyLevel = 6;
                    return;
                case VARIANT.SKELETON:
                    difficultyLevel = 1;
                    return;
                case VARIANT.ZOMBIE:
                    difficultyLevel = 2;
                    return;
                case VARIANT.GHOST:
                    difficultyLevel = 6;
                    return;
                case VARIANT.VAMPIRE:
                    difficultyLevel = 9;
                    return;
                case VARIANT.LICH:
                    difficultyLevel = 12;
                    return;
                default:
                    difficultyLevel = 1;
                    return;
            }
        }

        public uint getCurHealth()
        {
            return curHealth;
        }

        public uint getMaxHealth()
        {
            return maxHealth;
        }

        public void setCurHealth(uint health)
        {
            curHealth = health;
        }
    }
}
