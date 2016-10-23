using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    struct SceneSettings
    {
        int level;
        string environment;
        int challengeDifficulty;
        List<Monster> monsters; 
        List<Character> characters;
        
        public SceneSettings(int level, String environment, int challengeDifficulty, List<Monster> monsters, List<Character> characters)
        {
            this.level = level;
            this.environment = environment;
            this.challengeDifficulty = challengeDifficulty;
            this.monsters = monsters;
            this.characters = characters;
        } 

    }
}
