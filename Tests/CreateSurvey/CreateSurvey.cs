using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using Framework.Pages;
using Framework.Pages.CreateSurveyPage;
using Framework.Pages.EditSurvey;
using NUnit.Framework;

namespace Tests.CreateSurvey
{
    public class CreateSurvey
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://www.manoapklausa.lt/login/");
        }

        [Test]
        public static void CreateNewSurvey()
        {
            Common.login();

            CreateSurveyPage.ClickSukurtiButton();
            CreateSurveyPage.ClickSukurtiNaujaApklausa();
            
            string expectedApklausosPavadinimas = "Vasara";
            string expectedApklausosAprasymas = "Trumpas klausimynas apie vasarą";

            CreateSurveyPage.enterPavadinimas(expectedApklausosPavadinimas);
            CreateSurveyPage.enterAprasymas(expectedApklausosAprasymas);
            CreateSurveyPage.clickTestiButton();
            CreateSurveyPage.clickPridetiKlausima();
            CreateSurveyPage.ClickVienasAtsakymas();

            string klausimas = "Kiek mėnesių turi vasara?";
            CreateSurveyPage.IrasykiteKlausima(klausimas);

            string atsakymas1 = "Vienas";
            string atsakymas2 = "Du";
            string atsakymas3 = "Trys";
            CreateSurveyPage.IrasykiteVarianta1(atsakymas1);
            CreateSurveyPage.IrasykiteVarianta2(atsakymas2);
            CreateSurveyPage.IrasykiteVarianta3(atsakymas3);

            CreateSurveyPage.ClickSaugoti();
            CreateSurveyPage.ClickBaigtiApklausa();

            string expectedText = "Mano apklausos";
            string actualText = CreateSurveyPage.getTexteAfterBaigtiApklausa();
            Assert.IsTrue(actualText.Contains(expectedText));

        }
        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }


    }
}
