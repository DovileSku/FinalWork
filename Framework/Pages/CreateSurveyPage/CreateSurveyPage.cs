using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.CreateSurveyPage
{
    public class CreateSurveyPage
    {
        public static void ClickSukurtiButton()
        {
            string locator = "//*[@href='/create/']";
            Common.clickElement(locator);
        }

        public static void ClickSukurtiNaujaApklausa()
        {
            string locator = "//*[@href='/create/new/']";
            Common.clickElement(locator);
        }

        public static void enterPavadinimas(string pavadinimas)
        {
            string locator = "//*[@name='survey_title']";
            Common.sendKeysToElement(locator, pavadinimas);
        }

        public static void enterAprasymas(string aprasymas)
        {
            string locator = "//*[@name='survey_info']";
            Common.sendKeysToElement(locator, aprasymas);
        }

        public static void clickTestiButton()
        {
            string locator = "//*[@name='reg_submit']";
            Common.clickElement(locator);
        }

        public static void clickPridetiKlausima()
        {
            string locator = "//*[@class='add_q']/a";
            Common.clickElement(locator);
        }

        public static void IrasykiteKlausima(string klausimas)
        {
            string locator = "//*[@name='sur_question']";
            Common.sendKeysToElement(locator, klausimas);
        }

        public static void ClickVienasAtsakymas()
        {
            string locator = "//*[@id='in_form']/select/option[1]";
            Common.clickElement(locator);
        }

        public static void IrasykiteVarianta1(string atsakymas1)
        {
            string locator = "//*[@name='sur_answers[1]']";
            Common.sendKeysToElement(locator, atsakymas1);
        }

        public static void IrasykiteVarianta2(string atsakymas2)
        {
            string locator = "//*[@name='sur_answers[2]']";
            Common.sendKeysToElement(locator, atsakymas2);
        }

        public static void IrasykiteVarianta3(string atsakymas3)
        {
            string locator = "//*[@name='sur_answers[3]']";
            Common.sendKeysToElement(locator, atsakymas3);
        }

        public static void ClickSaugoti()
        {
            string locator = "//*[@name='reg_submit']";
            Common.clickElement(locator);
        }

        public static void ClickBaigtiApklausa()
        {
            string locator = "//*[@name='close_submit']";
            Common.clickElement(locator);
        }

        public static string getTexteAfterBaigtiApklausa()
        {
            string locator = "//*[@id='inside_surveys']/h2";
            return Common.getElementText(locator);
        }

    }
}
