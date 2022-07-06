using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Driver
    {
      public static IWebDriver driver;

        public static void setDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }

        public static void open(string url)
        {
            driver.Url = url;
        }

        public static object SwitchTo()
        {
            throw new NotImplementedException();
        }

        public static void closeDriver()
        {
            driver.Quit();
        }

      
    }
}
