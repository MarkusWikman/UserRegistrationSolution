using System.ComponentModel.DataAnnotations;
using UserRegistrationService;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateEmail_ShouldFailWhenEmailIsNotInValidFormat()
        {
            var u = new UserRegistration();
            Assert.IsFalse(u.ValidateEmail("hej"));
        }
        [TestMethod]
        public void ValidateEmail_ShouldSucceedWhenEmailIsInValidFormat()
        {
            var u = new UserRegistration();
            Assert.IsTrue(u.ValidateEmail("hej@gmail.com"));
        }
        [TestMethod]
        public void ValidatePassword_ShouldFailWhenPasswordIsNotInValidFormat()
        {
            var u = new UserRegistration();
            Assert.IsFalse(u.ValidatePassword("hej"));
        }
        [TestMethod]
        public void ValidatePassword_ShouldSucceedWhenPasswordIsInValidFormat()
        {
            var u = new UserRegistration();
            Assert.IsTrue(u.ValidatePassword("hejsan123!"));
        }
        [TestMethod]
        public void ValidateUsername_ShouldSucceedWhenUsernameIsInValidFormat()
        {
            var u = new UserRegistration();
            Assert.IsTrue(u.ValidateUserName("hejsan123"));
        }
        [TestMethod]
        public void ValidateUsername_ShouldFailWhenUsernameIsNotInValidFormat()
        {
            var u = new UserRegistration();
            Assert.IsFalse(u.ValidateUserName("hej"));
        }
        [TestMethod]
        public void ValidateUsername_ShouldFailIfUsernameAlreadyExists()
        {
            var userRegistration = new UserRegistration();
        }
    }
}