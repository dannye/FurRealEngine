using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FurRealEngine
{
    [TestClass]
    public class LoginGUITest : LoginGUI
    {

        [TestMethod]
        public void emptyusernameFieldTest()
        {
            // arrange
            //string errorMessage = "Username field has been left blank.";
            string blank = "";


            // act
            if (String.Equals(username, blank))
            {
                ///Error Message
                //LoginGUI.errorLabel.Text = errorMessage;

            }

            // assert
            //Assert.AreEqual(LoginGUI.errorLabel.Text, blank);
        }

        [TestMethod]
        public void emptyPasswordFieldTest()
        {
            // arrange
            //string errorMessage = "Password field has been left blank.";
            string blank = "";


            // act
            if (String.Equals(password, blank))
            {
                //Error Message
                //LoginGUI.errorLabel.Text = errorMessage;

            }

            // assert
            //Assert.AreEqual(LoginGUI.errorLabel.Text, blank);
        }
    }
}
