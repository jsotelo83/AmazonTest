using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonChallenge.Pages
{
    public class HomePage:BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        By searchInput = By.Id("twotabsearchtextbox");

        By searchButton = By.XPath("//input[@type='submit' and @value='Go']");

        public string getBaseURL() { return baseURL; }

        public void goToHome() { goTo(baseURL); }

        public void searchArticle(String searchString)
        {



        }

        public void validateCurrentURL(String URL) { Assert.AreEqual(driver.Url, URL); }
    }
}
