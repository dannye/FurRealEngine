using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FurRealEngine
{
    [TestClass]
    public class ConfigControllerTests
    {

        [TestMethod]
        public void getProfessionGivenSoldierReturnsSoldierEnum()
        {
            // arrange
            string selectedProfession = "Soldier";
            PROFESSION expectedRetVal = PROFESSION.SOLDIER;
            ConfigController controller = new ConfigController();

            // act
            PROFESSION actual = controller.getProfessionIdentifier(selectedProfession);

            // assert
            Assert.AreEqual(expectedRetVal, actual);
        }

        [TestMethod]
        public void getProfessionGivenCombatMageReturnsCombatMageEnum()
        {
            // arrange
            string selectedProfession = "Combat Mage";
            PROFESSION expectedRetVal = PROFESSION.MAGE;
            ConfigController controller = new ConfigController();

            // act
            PROFESSION actual = controller.getProfessionIdentifier(selectedProfession);

            // assert
            Assert.AreEqual(expectedRetVal, actual);
        }

        [TestMethod]
        public void getProfessionGivenPriestReturnsPriestEnum()
        {
            // arrange
            string selectedProfession = "Priest";
            PROFESSION expectedRetVal = PROFESSION.PRIEST;
            ConfigController controller = new ConfigController();

            // act
            PROFESSION actual = controller.getProfessionIdentifier(selectedProfession);

            // assert
            Assert.AreEqual(expectedRetVal, actual);
        }

        [TestMethod]
        public void addingCharacterAssignsProffesionCorrectly()
        {
            // arrange
            ConfigController controller = new ConfigController();
            List<Character> characters;
            int soldier = 1;
            int mage = 2;
            int priest = 3;

            // act
            controller.addCharacter(1);
            controller.addCharacter(2);
            controller.addCharacter(3);
            characters = controller.getCharacters();

            // assert
            for (int i = 0; i < characters.Count; i++)
            {
                if (i+1 == soldier)
                {
                    Assert.AreEqual(soldier, controller.getCharacters().ElementAt(i).getIdentifier());
                }

                if (i+1 == mage)
                {
                    Assert.AreEqual(mage, controller.getCharacters().ElementAt(i).getIdentifier());
                }

                if (i+1 == priest)
                {
                    Assert.AreEqual(priest, controller.getCharacters().ElementAt(i).getIdentifier());
                }
            }
        }

    }
}
