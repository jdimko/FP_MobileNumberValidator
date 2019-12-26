using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberValidator;
using static ValidatePhoneNumber.Test.TestData;

namespace ValidatePhoneNumber.Test
{
    [TestClass]
    public class UnitTests
    {
        [DataTestMethod]
        [ValidNumbers]
        public void ValidNumberTests(string input)
        {
            Assert.IsTrue(Validator.Run(input));
        }

        [DataTestMethod]
        [InValidNumbers]
        public void InValidNumberTests(string input)
        {
            Assert.IsFalse(Validator.Run(input));
        }

        [DataTestMethod]
        [ValidNumbers]
        public void FP_ValidNumberTests(string input)
        {
            Assert.IsTrue(FPValidator.Run(input));
        }

        [DataTestMethod]
        [InValidNumbers]
        public void FP_InValidNumberTests(string input)
        {
            Assert.IsFalse(FPValidator.Run(input));
        }
    }
}
