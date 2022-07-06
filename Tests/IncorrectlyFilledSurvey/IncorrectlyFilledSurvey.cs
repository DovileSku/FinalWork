using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Framework.Pages;
using Framework.Pages.FillSurveyPage;
using NUnit.Framework;

namespace Tests.FillSurvey
{
    public class IncorrectlyFilledSurvey
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://www.manoapklausa.lt/login/");
        }

        [Test]
        public static void FillCreatedSurvey()
        {
            Common.login();

            IncorrectlyFilledSurveyPage.clickApklausaVasara();

            

            string parentWindowHandle;
            parentWindowHandle = IncorrectlyFilledSurveyPage.getCurrentWindowHandle();
            IncorrectlyFilledSurveyPage.switchToApklausaVasaraFromManoApklausos(parentWindowHandle);



            IncorrectlyFilledSurveyPage.clickPradeti();
            IncorrectlyFilledSurveyPage.fillLytis();
            IncorrectlyFilledSurveyPage.fillAmzius();
            IncorrectlyFilledSurveyPage.fillGyvenamojiVieta();
            IncorrectlyFilledSurveyPage.clickTesti();

            string expectedMessage = "Prašome užpildyti visus laukelius!";
            string actualMessage = IncorrectlyFilledSurveyPage.getMesaggeAfterTesti();
            Assert.IsTrue(actualMessage.Contains(expectedMessage));

        }


    }
}
