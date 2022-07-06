using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Framework.Pages
{
    public class Common
    {
       
            public static IWebElement getElement(string locator)
            {
                return Driver.getDriver().FindElement(By.XPath(locator));
            }

             public static void clickElement(string locator)
             {
                getElement(locator).Click();
             }

            public static void sendKeysToElement(string locator, string keys)
            {
            getElement(locator).SendKeys(keys);
            }

            public static string getElementText(string locator)
            {
            return getElement(locator).Text;
            }

            public static void login()
            {
            string expectedEmail = "dovile.skujiene@gmail.com";
            string expectedPassword = "Skujiene";

            InvalidLoginDataPage.enterEmail(expectedEmail);
            InvalidLoginDataPage.enterPassword(expectedPassword);
            InvalidLoginDataPage.ClickPrisijungtiButton();
            }

            public static void alertAccept()
            {
            Driver.getDriver().SwitchTo().Alert().Accept();
            }

        internal static void switchToNewWindowFromParentWindowByHandle(string parentWindowHandle)
        {
            throw new NotImplementedException();
        }

        public static void waitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        public static void switchToWindowByHandle(string handle)
        {
            Driver.getDriver().SwitchTo().Window(handle);
        }

        internal static string getCurrentWindowHandle()
        {
            return Driver.getDriver().CurrentWindowHandle;
        }



        /* public static void selectOptionByValue(string locator, string value)
         {
             IWebElement element = getElement(locator);
             SelectElement selectElement = new SelectElement(element);
             selectElement.SelectByValue(value);
         }

         internal static void performRightClick(string locator)
         {
             IWebElement element = getElement(locator);
             Actions actions = new Actions(Driver.getDriver());

             actions.ContextClick(element);
             actions.Perform();
         }



        internal static void performDoubleClick(string locator)
        {
            IWebElement element = getElement(locator);
            Actions actions = new Actions(Driver.getDriver());

            actions.DoubleClick(element);
            actions.Perform();
         }

    

            public static void waitForElementToBeVisible(string locator)
            {
                WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            }

            public static void waitForElementToBeInvisible(string locator)
            {
                WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
            }*/


    }
}
