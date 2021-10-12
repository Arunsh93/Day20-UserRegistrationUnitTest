using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserResistration;

namespace UserResistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUserFirstName()
        {
            UserResistrationValidation userResistration = new UserResistrationValidation();

            //Arrange
            bool ExpectedName = true;
            string firstName = "Arun";
            bool ActualName;

            //Action
            ActualName = userResistration.ValidateFirstName(firstName);

            //Assertion
            Assert.AreEqual(ExpectedName, ActualName);
        }
        [TestMethod]
        public void TestUserLastName()
        {
            UserResistrationValidation userResistration = new UserResistrationValidation();

            //Arrange
            bool ExpectedName = true;
            string lastName = "Hosur";
            bool ActualName;

            //Action
            ActualName = userResistration.ValidateLastName(lastName);

            //Assertion
            Assert.AreEqual(ExpectedName, ActualName);
        }

    }
}
