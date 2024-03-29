using System.ComponentModel.DataAnnotations;
using UserRegistrationService;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateEmail_ShouldReturnFalseWhenEmailIsNotInValidFormatAndReturnTrueWhenEmailIsInValidFormat()
        {
            var u = new UserRegistration();

            Assert.IsFalse(u.ValidateEmail("hej"));
            Assert.IsTrue(u.ValidateEmail("hej@gmail.com"));
        }
        [TestMethod]
        public void ValidatePassword_ShouldReturnFalseWhenPasswordIsNotInValidFormatAndReturnTrueWhenPasswordIsInValidFormat()
        {
            var u = new UserRegistration();

            Assert.IsFalse(u.ValidatePassword("hej"));
            Assert.IsTrue(u.ValidatePassword("hejsan123!"));
        }
        [TestMethod]
        public void ValidateUsername_ShouldReturnFalseWhenUsernameIsNotInValidFormatAndReturnTrueWhenUsernameIsInValidFormat()
        {
            var u = new UserRegistration();

            Assert.IsFalse(u.ValidateUserName("hej"));
            Assert.IsTrue(u.ValidateUserName("hejsan123"));
        }
        [TestMethod]
        public void CheckIfUserNameAlreadyExists_ShouldReturnFalseIfUsernameAlreadyExistsAndReturnTrueIfUsernameDoesNotAlreadyExist()
        {
            var userRegistration = new UserRegistration();
            //userRegistration.Users.Add(new User() { Email = "hej@gmail.com", Password = "hejsan123!", UserName = "hejsan123" });
            userRegistration.RegisterNewUser("hejsan123", "hejsan123!", "hej@gmail.com");
            var username2 = "hEjSan123";
            var username3 = "tjenare123";

            Assert.IsFalse(userRegistration.CheckIfUserNameDoesNotAlreadyExists(username2));
            Assert.IsTrue(userRegistration.CheckIfUserNameDoesNotAlreadyExists(username3));

        }
        [TestMethod]
        public void RegisterNewUser_CheckSoThatCountOfListCorrespondsCorrectlyWithNewUsersAdded()
        {
            var userRegistration = new UserRegistration();

            Assert.AreEqual(0, userRegistration.Users.Count);
            userRegistration.RegisterNewUser("hejsan123", "hejsan123!", "hej@gmail.com");
            userRegistration.RegisterNewUser("hejsan12", "hejsan12!", "he@gmail.com");
            userRegistration.RegisterNewUser("tjena123", "tjena123!", "tjena@gmail.com");
            Assert.AreEqual(3, userRegistration.Users.Count());
        }
    }
}