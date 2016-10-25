using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurRealEngine
{
    public partial class SimulatorGUI : Form
    {
        SimulatorController simController;

        public SimulatorGUI(ScenarioSettings scenario, SceneSettings scene, List<Character> characters, List<Monster> monsters)
        {
            InitializeComponent();
            simController = new SimulatorController(scenario, scene, characters, monsters);
            simController.fillCharacterList(characterList);
            if (characterList.Items.Count > 0)
            {
                characterList.SelectedIndex = 0;
            }
            
            simController.fillMonsterList(monsterList);
            if (monsterList.Items.Count > 0)
            {
                monsterList.SelectedIndex = 0;
            }
            
            if (scene.environment == "dungeon")
            {
                BackgroundImage = Properties.Resources.dungeon;
            }
            else if (scene.environment == "cavern")
            {
                BackgroundImage = Properties.Resources.cavern;
            }
            else if (scene.environment == "forest")
            {
                BackgroundImage = Properties.Resources.forest;
            }
            Show();
        }

        private void characterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            simController.fillCharacterGroup(characterGroup, characterList.SelectedIndex);
        }

        private void monsterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            simController.fillMonsterGroup(monsterGroup, monsterList.SelectedIndex);
        }
    }
}
