using OpenQA.Selenium;

namespace SeleniumLoginTest.PageObjects
{
    public class YourCartPage
    {
        private readonly IWebDriver _driver;

        private IWebElement BackpackTile => _driver.FindElement(By.XPath("//div[@class='inventory_item_name' and text()='Sauce Labs Backpack']"));
        private IWebElement Checkout => _driver.FindElement(By.Id("checkout"));

        public YourCartPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        // Checks if the backpack tile is visible on the page
        public bool IsBackpackTileVisible()
        {
            return BackpackTile.Displayed;
        }

        // Clicks the checkout button
        public void ClickCheckoutButton()
        {
            Checkout.Click();
        }
    }
}
