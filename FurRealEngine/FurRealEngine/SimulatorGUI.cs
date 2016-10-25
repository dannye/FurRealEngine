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
        CombatRoundController turnController;

        public SimulatorGUI(ScenarioSettings scenario, SceneSettings scene, List<Character> characters, List<Monster> monsters)
        {
            InitializeComponent();
            simController = new SimulatorController(scenario, scene, characters, monsters);
            turnController = new CombatRoundController(scenario, scene, characters, monsters);
            simController.fillCharacterList(characterList);
            simController.fillCharacterGroup(characterGroup);
            simController.fillMonsterList(monsterList);
            simController.fillMonsterGroup(monsterGroup);
            Show();
        }

        private void meleeButton_Click(object sender, EventArgs e)
        {
            int character = characterList.SelectedIndex;
            int monster = monsterList.SelectedIndex;
            if (monsterList.Items.Count > 0)
            {
                turnController.meleeAttack(character, monster);
            }
        }

        private void spellButton_Click(object sender, EventArgs e)
        {
            int character = characterList.SelectedIndex;
            int monster = monsterList.SelectedIndex;
            if(monsterList.Items.Count > 0 && characterList.Items.Count > 0)
            {
                turnController.spellAttack(character, monster);
            }
        }
    }
}
