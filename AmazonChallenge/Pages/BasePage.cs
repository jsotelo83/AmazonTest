using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonChallenge.Pages
{
    public class BasePage
    {
        public IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string baseURL = "https://www.amazon.com/";

        public void goTo(string URL) => driver.Navigate().GoToUrl(URL);

        public void click(By element) { driver.FindElement(element).Click();}

        public void writeText (By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }

        public string readText (By element)
        {
            return driver.FindElement(element).Text;
        }
    }
}
