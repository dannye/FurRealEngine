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
        SimulatorController simController = new SimulatorController();

        public SimulatorGUI()
        {
            InitializeComponent();
            simController.fillCharacterList(characterList);
            simController.fillCharacterGroup(characterGroup);
            simController.fillMonsterList(monsterList);
            simController.fillMonsterGroup(monsterGroup);
        }
    }
}
