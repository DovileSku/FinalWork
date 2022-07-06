using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.EditSurvey
{
    public class AlertInSurveyEditPage
    {
        public static void ClickManoApklausos()
        {
            string locator = "//*[@name='close_submit']";
            Common.clickElement(locator);
        }
      
        public static void clickOkInAlertBox()
        {
            Common.alertAccept();
        }

        public static void clickTaisyti()
        {
            string locator = "//*[@onclick]";
            Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }

        public static string getTexteAfterIssaugotiPakeitimus()
        {
            string locator = "//*[@id='inside_surveys']/h2";
            return Common.getElementText(locator);
        }


        public static void clickIssaugotiPakeitimus()
        {
            string locator = "//*[@name='close_submit2']";
            Common.clickElement(locator);
        }



    }
}
