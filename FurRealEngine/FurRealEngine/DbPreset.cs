using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    public struct DbPreset
    {
        public int numberOfCharacters;
        public Boolean areCharsPlayablePreset;
        public int defaultProfessionPreset;
        public int defaultProfessionLevelPreset;
        public int defaultReviveOptionPreset;
        public int defaultCdPreset;
        public int defaultStartingDifficultyPreset;
        public int defaultStartingLevelPreset;
        public int defaultMaxLevelPreset;
        public int defaultEnviornmentPreset;
        public int defaultRepeatScenarioPreset;

        public DbPreset(int numberOfCharacters, Boolean areCharsPlayablePreset,
           int defaultProfessionPreset,
           int defaultProfessionLevelPreset,
           int defaultReviveOptionPreset,
           int defaultCdPreset,
           int defalutStartingDifficultyPreset,
           int defaultStartingLevelPreset,
           int defaultMaxLevelPreset,
           int defalutEnviornmentPreset,
           int defalutRepeatScenarioPreset)
        {
            this.numberOfCharacters = numberOfCharacters;
            this.areCharsPlayablePreset = areCharsPlayablePreset;
            this.defaultProfessionPreset = defaultProfessionPreset;
            this.defaultProfessionLevelPreset = defaultProfessionLevelPreset;
            this.defaultReviveOptionPreset = defaultReviveOptionPreset;
            this.defaultCdPreset = defaultCdPreset;
            this.defaultStartingDifficultyPreset = defalutStartingDifficultyPreset;
            this.defaultStartingLevelPreset = defaultStartingLevelPreset;
            this.defaultMaxLevelPreset = defaultMaxLevelPreset;
            this.defaultEnviornmentPreset = defalutEnviornmentPreset;
            this.defaultRepeatScenarioPreset = defalutRepeatScenarioPreset;
        }

    }
}
