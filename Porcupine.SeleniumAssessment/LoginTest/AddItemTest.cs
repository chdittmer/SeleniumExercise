using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumLoginTest.PageObjects;
using System;

namespace SeleniumLoginTest
{
    public class AddItem
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private ItemPage itemPage;
        private YourCartPage yourCartPage;
        private YourInformationPage yourInformationPage;
        private OverviewAndFinishPage overviewAndFinishPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            loginPage = new LoginPage(driver);
            itemPage = new ItemPage(driver);
            yourCartPage = new YourCartPage(driver);
            yourInformationPage = new YourInformationPage(driver);
            overviewAndFinishPage = new OverviewAndFinishPage(driver);
        }

        [Test]

        public void AddItemTest()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            
            loginPage.Login("standard_user", "secret_sauce");

            // Add the backpack item to the cart and open the shopping cart
            itemPage.ClickAddBackpackButton();
            itemPage.ClickShoppingCartButton();

            // Verify the backpack item is visible in the cart
            Assert.That(yourCartPage.IsBackpackTileVisible(), Is.True);

            // Proceed to checkout
            yourCartPage.ClickCheckoutButton();

            // Fill in the user details and proceed
            yourInformationPage.FillDetails("Natania", "Damons", "0022");

            // Verify the backpack item is still visible in the cart after checkout
            Assert.That(yourCartPage.IsBackpackTileVisible(), Is.True);

            // Complete the purchase
            overviewAndFinishPage.ClickFinishButton();

            // Verify the confirmation message is visible
            Assert.That(overviewAndFinishPage.IsComfirmationMessageVisible(), Is.True);

        } 

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
