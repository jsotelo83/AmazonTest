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

        By signInButton = By.XPath("//a[@class='nav-a nav-a-2' and @id='nav-link-accountList']");

        public string getBaseURL() { return baseURL; }

        public void goToHome() { goTo(baseURL); }

        public ArticlePage searchArticle(String searchString)
        {
            IWebElement articleToBeSearch = driver.FindElement(searchInput);
            articleToBeSearch.SendKeys(searchString);
            click(searchButton);
            return new ArticlePage(driver);

        }

        public void validateCurrentURL(String URL) { Assert.AreEqual(driver.Url, URL); }
    }
}
