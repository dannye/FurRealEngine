using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    class ConfigController
    {

        private SceneSettings scene;
        private ScenarioSettings scenario;
        
        public ConfigController()
        {

        }

        public void setScene(SceneSettings scene)
        {
            this.scene = scene;
        }

        public void setScenario(ScenarioSettings scenario)
        {
            this.scenario = scenario;
        }

        public bool areSettingsValid()
        {
            return false;
        }
    }
}
