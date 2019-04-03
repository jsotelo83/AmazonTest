using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonChallenge.Tests
{
    public class BaseTest
    {
        public static IWebDriver driver;

        [SetUp]
        public static void Initialize() { driver = new ChromeDriver(); }

        [TearDown]
        public static void EndTest() { driver.Quit(); }
 
    }
}
