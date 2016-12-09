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
        public PROFESSION defaultProfessionPreset;
        public int defaultProfessionLevelPreset;
        public HEAL_OPTION defaultReviveOptionPreset;
        public int defaultCdPreset;
        public DIFFICULTY defaultStartingDifficultyPreset;
        public int defaultStartingLevelPreset;
        public int defaultMaxLevelPreset;
        public ENVIRONMENT defaultEnvironmentPreset;
        public int defaultRepeatScenarioPreset;

        public Preset(int numberOfCharacters, bool areCharsPlayablePreset,
           PROFESSION defaultProfessionPreset,
           int defaultProfessionLevelPreset,
           HEAL_OPTION defaultReviveOptionPreset,
           int defaultCdPreset,
           DIFFICULTY defaultStartingDifficultyPreset,
           int defaultStartingLevelPreset,
           int defaultMaxLevelPreset,
           ENVIRONMENT defaultEnvironmentPreset,
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
