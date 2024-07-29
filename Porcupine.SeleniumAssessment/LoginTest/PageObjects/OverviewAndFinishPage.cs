using OpenQA.Selenium;

namespace SeleniumLoginTest.PageObjects
{
    public class OverviewAndFinishPage
    {
        private readonly IWebDriver _driver;

        private IWebElement FinishButton => _driver.FindElement(By.Id("finish"));
        private IWebElement ConfirmationMessage => _driver.FindElement(By.ClassName("complete-text"));

        public OverviewAndFinishPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Clicks the finish button to complete the checkout process
        public void ClickFinishButton()
        {
            FinishButton.Click();
        }

        // Checks if the confirmation message is visible on the page
        public bool IsComfirmationMessageVisible()
        {
            return ConfirmationMessage.Displayed;
        }
    }
}
