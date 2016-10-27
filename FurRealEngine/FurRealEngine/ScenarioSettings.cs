using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    public enum DIFFICULTY
    {
        NOVICE,
        APPRENTICE,
        MASTER
    }

    public struct ScenarioSettings
    {
        public DIFFICULTY difficulty;
        public int startLevel;
        public int endLevel;
        public int numberOfRuns;
        public int numberOfCharacters;
        public int initCD;

        public ScenarioSettings(DIFFICULTY difficulty, int startLevel, int endLevel, int numberOfRuns, int numberOfCharacters, int initCD)
        {
            this.difficulty = difficulty;
            this.startLevel = startLevel;
            this.endLevel = endLevel;
            this.numberOfRuns = numberOfRuns;
            this.numberOfCharacters = numberOfCharacters;
            this.initCD = initCD;
        }

    }
}
