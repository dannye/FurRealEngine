using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FurRealEngine
{
    [TestClass]
    public class CombatRoundControllerTests
    {

        [TestMethod]
        public void meleeAttack()
        {
            //Arrange
            List<Character> characters = new List<Character>();
            List<Monster> monsters = new List<Monster>();
            Monster mon = new Monster(VARIANT.KOBOLD);
            monsters[0] = mon;
            Character charc = new Character(PROFESSION.SOLDIER, HEAL_OPTION.NEVER, false);
            characters[0] = charc;
            CombatRoundController crControl = new CombatRoundController(new ScenarioSettings(), new SceneSettings(), characters, monsters);
            int expectedValue = (int)mon.getCurHealth();

            //Act
            crControl.meleeAttack(0, 0);

            //Arrange
            Assert.IsTrue(expectedValue > mon.getCurHealth(), "The monster's health did not go down.");
        }

        [TestMethod]
        public void spellAttack()
        {

            //Arrange
            List<Character> characters = new List<Character>();
            List<Monster> monsters = new List<Monster>();
            Monster mon = new Monster(VARIANT.KOBOLD);
            monsters[0] = mon;
            Character charc = new Character(PROFESSION.MAGE, HEAL_OPTION.NEVER, false);
            characters[0] = charc;
            CombatRoundController crControl = new CombatRoundController(new ScenarioSettings(), new SceneSettings(), characters, monsters);
            int expectedValue = (int)mon.getCurHealth();

            //Act
            crControl.spellAttack(0, 0);

            //Arrange
            Assert.IsTrue(expectedValue > mon.getCurHealth(), "The monster's health did not go down.");
        }

    }
}
