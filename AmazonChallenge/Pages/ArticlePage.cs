using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonChallenge.Pages
{
    public class ArticlePage:BasePage
    {
        public ArticlePage(IWebDriver driver) : base(driver){}

        By searchInput = By.Id("twotabsearchtextbox");

        By searchButton = By.XPath("//input[@type='submit' and @value='Go']");

        public string getBaseURL() { return baseURL; }

        public void goToHome() { goTo(baseURL); }


    }
}
