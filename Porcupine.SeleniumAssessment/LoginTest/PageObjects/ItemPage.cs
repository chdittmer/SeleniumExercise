using OpenQA.Selenium;

namespace SeleniumLoginTest.PageObjects
{
    public class ItemPage
    {
        private readonly IWebDriver _driver;

        private IWebElement backpack => _driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement shoppingCart => _driver.FindElement(By.Id("shopping_cart_container"));

        public ItemPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Clicks the "Add to Cart" button for the backpack
        public void ClickAddBackpackButton()
        {
            backpack.Click();
        }

        // Clicks the shopping cart icon
        public void ClickShoppingCartButton()
        {
            shoppingCart.Click();
        }
    }
}
