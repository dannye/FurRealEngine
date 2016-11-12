using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FurRealEngine.TestClasses
{
    [TestClass]
    public class ReportControllerTests
    {

        [TestMethod]
        public void meleeAttackIncrementsTotalDamage()
        {
            //Arrange
            List<Character> characters = new List<Character>();
            List<Monster> monsters = new List<Monster>();
            Monster mon = new Monster(VARIANT.KOBOLD);
            monsters.Add(mon);
            Character charc = new Character(PROFESSION.SOLDIER);
            characters.Add(charc);
            CombatRoundController crControl = new CombatRoundController(new ScenarioSettings(), new SceneSettings(), characters, monsters);
            int expectedValue;

            //Act
            crControl.meleeAttack(0, 0);
            expectedValue = SimulatorController.totalDamageGiven;

            //Assert
            Assert.IsTrue(expectedValue > 0);
        }

        [TestMethod]
        public void spellAttackIncrementsTotalDamage()
        {
            //Arrange
            List<Character> characters = new List<Character>();
            List<Monster> monsters = new List<Monster>();
            Monster mon = new Monster(VARIANT.KOBOLD);
            monsters.Add(mon);
            Character charc = new Character(PROFESSION.MAGE);
            characters.Add(charc);
            CombatRoundController crControl = new CombatRoundController(new ScenarioSettings(), new SceneSettings(), characters, monsters);
            int expectedValue;

            //Act
            crControl.spellAttack(0, 0);
            expectedValue = SimulatorController.totalDamageGiven;

            //Arrange
            Assert.IsTrue(expectedValue > 0);
        }
    }
}
