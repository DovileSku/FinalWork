
using Framework;
using NUnit.Framework;

namespace Tests
{
    public class InvalidLoginData
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://www.manoapklausa.lt/login/");
        }

        [Test]
        public static void IncorrectlyFilledLoginFields()
        {
            string expectedEmail = "dovile.skujiene@gmail.com";
            string expectedPassword = "Skujien";
            string expectedMessage = "El. paštas arba slaptažodis yra neteisingi!";

            InvalidLoginDataPage.enterEmail(expectedEmail);
            InvalidLoginDataPage.enterPassword(expectedPassword);
            InvalidLoginDataPage.ClickPrisijungtiButton();
            string actualMessage = InvalidLoginDataPage.getMessageAfterSubmit();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));
            
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
