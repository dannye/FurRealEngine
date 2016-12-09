using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    public struct SceneSettings
    {
        public int level;
        public ENVIRONMENT environment;
        public int challengeDifficulty;
        public List<Character> characters;
        public List<Monster> monsters;

        public SceneSettings(int level, ENVIRONMENT environment, int challengeDifficulty, List<Character> characters, List<Monster> monsters)
        {
            this.level = level;
            this.environment = environment;
            this.challengeDifficulty = challengeDifficulty;
            this.characters = characters;
            this.monsters = monsters;
        } 

    }
}
