using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserResistration;

namespace UserResistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
    }
}
