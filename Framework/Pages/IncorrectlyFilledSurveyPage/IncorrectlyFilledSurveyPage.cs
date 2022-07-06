using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.FillSurveyPage
{
    public class IncorrectlyFilledSurveyPage
    {
        public static void clickApklausaVasara()
        {
            string locator = "//*[@class='title']/a";
            Common.clickElement(locator);
        }

        public static void switchToWindowByHandle(string handle)
        {
            Common.switchToWindowByHandle(handle);
        }

        

        public static string getCurrentWindowHandle()
        {
            return Common.getCurrentWindowHandle();
        }

       
        public static void clickPradeti()
        {
            string locator = "//*[@name='reg_start']";
            Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }


        public static void fillLytis()
        {
            string locator = "//*[@value='female']";
            Common.clickElement(locator);

        }

        public static void fillAmzius()
        {
            string locator = "//*[@value='30']";
            Common.clickElement(locator);
        }

        public static void switchToApklausaVasaraFromManoApklausos(string parentWindowHandle)
        {
            Common.switchToNewWindowFromParentWindowByHandle(parentWindowHandle);
        }

       

        public static void fillGyvenamojiVieta()
        {
            string locator = "//*[@value='----']";
            Common.clickElement(locator);
        }

        public static void clickTesti()
        {
            string locator = "//*[@type='submit']";
            Common.clickElement(locator);
        }

        public static string getMesaggeAfterTesti()
        {
            string locator = "//*[@class='err_msg2_info']";
            return Common.getElementText(locator);
        }
    }
}
