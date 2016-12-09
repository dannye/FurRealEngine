using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    public struct Preset
    {
        public int numberOfCharacters;
        public bool areCharsPlayablePreset;
        public int defaultProfessionPreset;
        public int defaultProfessionLevelPreset;
        public int defaultReviveOptionPreset;
        public int defaultCdPreset;
        public int defaultStartingDifficultyPreset;
        public int defaultStartingLevelPreset;
        public int defaultMaxLevelPreset;
        public int defaultEnvironmentPreset;
        public int defaultRepeatScenarioPreset;

        public Preset(int numberOfCharacters, bool areCharsPlayablePreset,
           int defaultProfessionPreset,
           int defaultProfessionLevelPreset,
           int defaultReviveOptionPreset,
           int defaultCdPreset,
           int defaultStartingDifficultyPreset,
           int defaultStartingLevelPreset,
           int defaultMaxLevelPreset,
           int defaultEnvironmentPreset,
           int defaultRepeatScenarioPreset)
        {
            this.numberOfCharacters = numberOfCharacters;
            this.areCharsPlayablePreset = areCharsPlayablePreset;
            this.defaultProfessionPreset = defaultProfessionPreset;
            this.defaultProfessionLevelPreset = defaultProfessionLevelPreset;
            this.defaultReviveOptionPreset = defaultReviveOptionPreset;
            this.defaultCdPreset = defaultCdPreset;
            this.defaultStartingDifficultyPreset = defaultStartingDifficultyPreset;
            this.defaultStartingLevelPreset = defaultStartingLevelPreset;
            this.defaultMaxLevelPreset = defaultMaxLevelPreset;
            this.defaultEnvironmentPreset = defaultEnvironmentPreset;
            this.defaultRepeatScenarioPreset = defaultRepeatScenarioPreset;
        }

    }
}
