using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    public struct SceneSettings
    {
        int level;
        public string environment;
        int challengeDifficulty;
        List<Character> characters;
        List<Monster> monsters;

        public SceneSettings(int level, String environment, int challengeDifficulty, List<Character> characters, List<Monster> monsters)
        {
            this.level = level;
            this.environment = environment;
            this.challengeDifficulty = challengeDifficulty;
            this.characters = characters;
            this.monsters = monsters;
        } 

    }
}
