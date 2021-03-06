﻿using AmazonChallenge.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonChallenge.Tests
{
    public class AmazonTests:BaseTest
    {
        [Test]
        public void navigateToHomeTest ()
        {
            HomePage homePage = new HomePage(driver);

            homePage.goToHome();

            homePage.validateCurrentURL(homePage.getBaseURL());
        }

        [Test]
        public void searchResultPage()
        {
            HomePage homePage = new HomePage(driver);

            string searchString = "iphone 8";

            homePage.goToHome();

            ArticlePage resultsPage = homePage.searchArticle(searchString);

            resultsPage.validateSearchResultsFor(searchString);

        }

        [Test]
        public void validateLeftRefinement()
        {
            HomePage homePage = new HomePage(driver);

            string searchString = "iphone 8";

            homePage.goToHome();

            ArticlePage resultsPage = homePage.searchArticle(searchString);

            resultsPage.validateLeftRefinement();

        }



    }
}
