using CleanCodeWorkshop.Task_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskVerify
{
    [TestClass]
    public class Task1
    {
        private ValidatePasswordDirty DirtyValidator = new ValidatePasswordDirty();
        private ValidatePasswordClean CleanValidator = new ValidatePasswordClean();

        [TestMethod]
        public void Validate_CorrectPassword()
        {
            var password = "Password123.";
            Assert.AreEqual(DirtyValidator.ValidateStrength(password), CleanValidator.ValidateStrength(password));
        }

        [TestMethod]
        public void Validate_EmptyPassword()
        {
            var password = string.Empty;
            Assert.AreEqual(DirtyValidator.ValidateStrength(password), CleanValidator.ValidateStrength(password));
        }

        [TestMethod]
        public void Validate_NullPassword()
        {
            string password = null;
            Assert.AreEqual(DirtyValidator.ValidateStrength(password), CleanValidator.ValidateStrength(password));
        }

        [TestMethod]
        public void Validate_ShortPassword()
        {
            var password = "Int3.";
            Assert.AreEqual(DirtyValidator.ValidateStrength(password), CleanValidator.ValidateStrength(password));
        }

        [TestMethod]
        public void Validate_NoDigitPassword()
        {
            var password = "PasswordOneTwoThree.";
            Assert.AreEqual(DirtyValidator.ValidateStrength(password), CleanValidator.ValidateStrength(password));
        }

        [TestMethod]
        public void Validate_NoSpecialCharacterPassword()
        {
            var password = "Password123";
            Assert.AreEqual(DirtyValidator.ValidateStrength(password), CleanValidator.ValidateStrength(password));
        }
    }
}
