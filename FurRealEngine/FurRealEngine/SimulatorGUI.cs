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

        public void removeFromCharacterList(int i)
        {
            characterList.Items.RemoveAt(i);
        }

        public void removeFromMonsterList(int i)
        {
            monsterList.Items.RemoveAt(i);
        }

        // update character info and attack buttons
        private void characterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            simController.characterIndexChanged(characterList, characterGroup, characterPicture, meleeButton, spellButton, continueButton);
        }

        // update monster info
        private void monsterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            simController.monsterIndexChanged(monsterList, monsterGroup, monsterPicture);
        }
		
        // melee attack
        private void meleeButton_Click(object sender, EventArgs e)
        {
            //simController.selectCharacters(characterList, characterGroup, characterPicture, monsterList, monsterGroup, monsterPicture, meleeButton, spellButton, continueButton);
            simController.meleeAttack(characterList, monsterList, monsterGroup, monsterPicture, playerTurnLabel, enemyTurnLabel);
            simController.selectCharacters(characterList, characterGroup, characterPicture, monsterList, monsterGroup, monsterPicture, meleeButton, spellButton, continueButton);
        }
        
        // spell attack
        private void spellButton_Click(object sender, EventArgs e)
        {
            //simController.selectCharacters(characterList, characterGroup, characterPicture, monsterList, monsterGroup, monsterPicture, meleeButton, spellButton, continueButton);
            simController.spellAttack(characterList, monsterList, monsterGroup, monsterPicture, playerTurnLabel, enemyTurnLabel);
            simController.selectCharacters(characterList, characterGroup, characterPicture, monsterList, monsterGroup, monsterPicture, meleeButton, spellButton, continueButton);
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            //simController.selectCharacters(characterList, characterGroup, characterPicture, monsterList, monsterGroup, monsterPicture, meleeButton, spellButton, continueButton);
            simController.automateMove(characterList, monsterList, monsterGroup, monsterPicture, playerTurnLabel, enemyTurnLabel);
            simController.selectCharacters(characterList, characterGroup, characterPicture, monsterList, monsterGroup, monsterPicture, meleeButton, spellButton, continueButton);
        }

        private void SimulatorGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void setSettings(DIFFICULTY difficulty, int level, int run, int treasure)
        {
            if (difficulty == DIFFICULTY.NOVICE)
            {
                difficultyText.Text = "Novice";
            }
            else if (difficulty == DIFFICULTY.APPRENTICE)
            {
                difficultyText.Text = "Apprentice";
            }
            else
            {
                difficultyText.Text = "Master";
            }
            levelText.Text = level.ToString();
            runText.Text = run.ToString();
            treasureText.Text = treasure.ToString();
        }
    }
}
