using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    public struct ScenarioSettings
    {

        public int difficulty;
        public int startLevel;
        public int endLevel;
        public int numberOfRuns;
        public int numberOfCharacters;
        public int initCD;

        public ScenarioSettings(int difficulty, int startLevel, int endLevel, int numberOfRuns, int numberOfCharacters, int initCD)
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
