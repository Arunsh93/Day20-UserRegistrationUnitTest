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
        [TestMethod]
        public void TestUserEmailId()
        {
            UserResistrationValidation userResistration = new UserResistrationValidation();

            //Arrange
            bool ExpectedName = true;
            string emailId = "abc.arun@bl.co.in";
            bool ActualName;

            //Action
            ActualName = userResistration.ValidateEmailId(emailId);

            //Assertion
            Assert.AreEqual(ExpectedName, ActualName);
        }
        [TestMethod]
        public void TestUserMobileNumber()
        {
            UserResistrationValidation userResistration = new UserResistrationValidation();

            //Arrange
            bool ExpectedName = true;
            string phoneNumber = "91 9620692457";
            bool ActualName;

            //Action
            ActualName = userResistration.ValidatePhoneNumber(phoneNumber);

            //Assertion
            Assert.AreEqual(ExpectedName, ActualName);
        }
        [TestMethod]
        public void TestUserPassword()
        {
            UserResistrationValidation userResistration = new UserResistrationValidation();

            //Arrange
            bool ExpectedName = true;
            string password = "Arun!123";
            bool ActualName;

            //Action
            ActualName = userResistration.ValidatePassword(password);

            //Assertion
            Assert.AreEqual(ExpectedName, ActualName);
        }
    }
}
