using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumLoginTest.PageObjects;

namespace SeleniumLoginTest
{
    public class Login
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            loginPage.Login("standard_user", "secret_sauce");
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
