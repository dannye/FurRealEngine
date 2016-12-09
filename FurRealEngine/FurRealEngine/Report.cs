using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    // Class that represents Report Stats for a single ran simulation
    // (This includes levels completed and times repeated)
    //    -If a Sim is repeated, stats should be rolled over into the same Report Object
    public class Report
    {
        ScenarioSettings scenario;
        SceneSettings scene;
        List<Character> characters;
        int totalNumOfChars;
        int totalNumOfMonsters;
        int totalCD;
        int numOfCharDefeated;
        int numOfMonstersDefeated;
        int totalDamageTaken;
        int totalDamageGiven;
        int numOfLevelsProgressed;
        int numOfTimesSimRan;
        int index;
        string simulationDifficulty;
        string envionrmentOfBattle;
        int treasure;

        public Report()
        {

        }

       public Report(ScenarioSettings scenario, SceneSettings scene, List<Character> characters, int treasure)
        {
            // Are scenario and scene needed in Report?
            this.scenario = scenario;
            this.scene = scene;
            this.characters = characters;
            this.treasure = treasure;
        }

        public int getTotalNumOfChars()
        {
            return this.totalNumOfChars;
        }

        public void setTotalNumOfChars(int totalNumOfChars)
        {
            this.totalNumOfChars = totalNumOfChars;
        }

        public int getTotalNumOfMonsters()
        {
            return this.totalNumOfMonsters;
        }

        public void setTotalNumOfMonsters(int totalNumOfMonsters)
        {
            this.totalNumOfMonsters = totalNumOfMonsters;
        }

        public int getTotalCD()
        {
            return this.totalCD;
        }

        public void setTotalCD(int totalCD)
        {
            this.totalCD = totalCD;
        }

        public int getNumOfCharDefeated()
        {
            return this.numOfCharDefeated;
        }

        public void setNumOfCharDefeated(int numOfCharDefeated)
        {
            this.numOfCharDefeated = numOfCharDefeated;
        }

        public int getNumOfMonstersDefeated()
        {
            return this.numOfMonstersDefeated;
        }

        public void setNumOfMonstersDefeated(int numOfMonstersDefeated)
        {
            this.numOfMonstersDefeated = numOfMonstersDefeated;
        }

        public int getTotalDamageTaken()
        {
            return this.totalDamageTaken;
        }

        public void setTotalDamageTaken(int totalDamageTaken)
        {
            this.totalDamageTaken = totalDamageTaken;
        }

        public int getTotalDamageGiven()
        {
            return this.totalDamageGiven;
        }

        public void setTotalDamageGiven(int totalDamageGiven)
        {
            this.totalDamageGiven = totalDamageGiven;
        }

        public int getNumOfLevelsProgressed()
        {
            return this.numOfLevelsProgressed;
        }

        public void setNumOfLevelsProgressed(int numOfLevelsProgressed)
        {
            this.numOfLevelsProgressed = numOfLevelsProgressed;
        }

        public int getIndex()
        {
            return this.index;
        }

        public void setIndex(int index)
        {
            this.index = index;
        }

        public int getNumOfTimesSimRan()
        {
            return this.numOfTimesSimRan;
        }

        public void setNumOfTimesSimRan(int numOfTimesSimRan)
        {
            this.numOfTimesSimRan = numOfTimesSimRan;
        }

        public string getSimulationDifficulty()
        {
            return this.simulationDifficulty;
        }

        public void setSimulationDifficulty(string simulationDifficulty)
        {
            this.simulationDifficulty = simulationDifficulty;
        }

        public string getEnvionrmentOfBattle()
        {
            return this.envionrmentOfBattle;
        }

        public void setEnvionrmentOfBattle(string envionrmentOfBattle)
        {
            this.envionrmentOfBattle = envionrmentOfBattle.ToUpper();
        }

        public int getTreasure()
        {
            return this.treasure;
        }

        public void setTreasure(int treasure)
        {
            this.treasure = treasure;
        }

        public override string ToString()
        {
            return "Report " + index;
        }
    }
}
