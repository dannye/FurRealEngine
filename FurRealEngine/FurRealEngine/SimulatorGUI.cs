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

        public SimulatorGUI(SimulatorController simController, CombatRoundController turnController)
        {
            InitializeComponent();
            this.simController = simController;
            this.turnController = turnController;
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
            Show();
        }

        public void removeFromMonsterList(int i)
        {
            int index = monsterList.SelectedIndex;
            monsterList.Items.RemoveAt(i);
            index = monsterList.SelectedIndex;
        }

        private void characterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            simController.fillCharacterGroup(characterGroup, characterList.SelectedIndex);
        }

        private void monsterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monsterList.SelectedIndex < 0 && monsterList.Items.Count > 0)
            {
                monsterList.SelectedIndex = 0;
            }
            simController.fillMonsterGroup(monsterGroup, monsterList.SelectedIndex);
        }
		
        private void meleeButton_Click(object sender, EventArgs e)
        {
            int character = characterList.SelectedIndex;
            int monster = monsterList.SelectedIndex;
            if (monsterList.Items.Count > 0 && characterList.Items.Count > 0)
            {
                if (character >= 0 && monster >= 0)
                {
                    turnController.meleeAttack(character, monster);
                    simController.checkForDeath();
                    simController.fillMonsterGroup(monsterGroup, monsterList.SelectedIndex);
                }
            }
            if (monsterList.Items.Count == 0 && characterList.Items.Count > 0) 
            {
                simController.fillMonsterList(monsterList);
                monsterList.SelectedIndex = 0;
            }
        }

        private void spellButton_Click(object sender, EventArgs e)
        {
            int character = characterList.SelectedIndex;
            int monster = monsterList.SelectedIndex;
            if(monsterList.Items.Count > 0 && characterList.Items.Count > 0)
            {
                if (character >= 0 && monster >= 0)
                {
                    turnController.spellAttack(character, monster);
                    simController.checkForDeath();
                    simController.fillMonsterGroup(monsterGroup, monsterList.SelectedIndex);
                }
            }
            if (monsterList.Items.Count == 0 && characterList.Items.Count > 0)
            {
                simController.fillMonsterList(monsterList);
                monsterList.SelectedIndex = 0;
            }
        }

        private void SimulatorGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            simController.close();
        }
    }
}
