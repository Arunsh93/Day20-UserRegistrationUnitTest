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
            string password = "Arunsh@123";
            bool ActualName;

            //Action
            ActualName = userResistration.ValidatePassword(password);

            //Assertion
            Assert.AreEqual(ExpectedName, ActualName);
        }
        [TestMethod]
        public void TestSampleEmailIds()
        {
            UserResistrationValidation userResistration = new UserResistrationValidation();

            //Arrange
            string Email1 = "arun@yahoo.com";
            string Email2 = "arun-100@yahoo.com";
            string Email3 = "abc.100@yahoo.com";
            string Email4 = "abc111@abc.com";
            string Email5 = "abc-100@abc.com.ac";

            bool ExpectedData = true;

            //Action
            bool ActualData1 = userResistration.ValidateSampleEmailIds(Email1);
            bool ActualData2 = userResistration.ValidateSampleEmailIds(Email2);
            bool ActualData3 = userResistration.ValidateSampleEmailIds(Email3);
            bool ActualData4 = userResistration.ValidateSampleEmailIds(Email4);
            bool ActualData5 = userResistration.ValidateSampleEmailIds(Email5);

            //Assert
            Assert.AreEqual(ExpectedData, ActualData1);
            Assert.AreEqual(ExpectedData, ActualData2);
            Assert.AreEqual(ExpectedData, ActualData3);
            Assert.AreEqual(ExpectedData, ActualData4);
            Assert.AreEqual(ExpectedData, ActualData5);
        }
    }
}
