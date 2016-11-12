using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FurRealEngine.TestClasses
{
    [TestClass]
    class ModifyAccountsTest : ModifyAccountsGUI
    {


        //Test is the suername fields are left blank or not.
        [TestMethod]
        public void emptyusernameFieldTest()
        {
            // arrange
           string blank = "";


            // act
            if (String.Equals(ModifyAccountsGUI.currUname, blank))
            {
                ///Error Message
                //MessageBox.Show("Username field has been left blank!");

            }

            // assert
            //Assert.AreEqual(username, blank);
        }

        //Test if the password fields are left blank or not.
        [TestMethod]
        public void emptyPasswordFieldTest()
        {
            // arrange
            string blank = "";


            // act
            if (String.Equals(ModifyAccountsGUI.currPass, blank))
            {
                //Error Message
                //MessageBox.Show("Password field has been left blank!");

            }

            // assert
            //Assert.AreEqual(password, blank);
        }
    }
}
