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

        By leftRefinement = By.Id("s-refinements");

        By searchResultsFor = By.XPath("//span[@class='a-color-state a-text-bold']");

        public string getPageTitle() { return driver.Title; }

        public string getSearchResultsFor()
        {
            IWebElement element = driver.FindElement(searchResultsFor);
            return element.Text;
        }

        public void validateSearchResultsFor(String searchString)
        {
            string actualSearchResultsFor = this.getSearchResultsFor();

            Assert.True(actualSearchResultsFor.Contains(searchString), "The search text for is different than expected");
        }

        public void validateLeftRefinement()
        {
            IWebElement element = driver.FindElement(leftRefinement);

            Assert.True(element.Displayed, "The left refinement is not displayed");
        }



    }
}
