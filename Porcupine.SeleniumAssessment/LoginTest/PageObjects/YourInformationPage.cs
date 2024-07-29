using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V125.DOM;

namespace SeleniumLoginTest.PageObjects
{
    public class YourInformationPage
    {
        private readonly IWebDriver _driver;

        private IWebElement FirstName => _driver.FindElement(By.Id("first-name"));
        private IWebElement LastName => _driver.FindElement(By.Id("last-name"));
        private IWebElement ZipCode => _driver.FindElement(By.Id("postal-code"));
        private IWebElement ContinueButton => _driver.FindElement(By.Id("continue"));

        public YourInformationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterFirstName(string firstName)
        {
            FirstName.SendKeys(firstName);
        }

        // Enters the provided last name into the last name field
        public void EnterLastName(string lastName)
        {
            LastName.SendKeys(lastName);
        }

        // Enters the provided zip code into the zip code field
        public void EnterZipCode(string zipCode)
        {
            ZipCode.SendKeys(zipCode);
        }

        // Clicks the continue button to proceed
        public void ClickContinueButton()
        {
            ContinueButton.Click();
        }

        // Fills in the provided details and clicks the continue button
        public void FillDetails(string firstname, string lastname, string zipcode)
        {
            EnterFirstName(firstname);
            EnterLastName(lastname);
            EnterZipCode(zipcode);
            ClickContinueButton();
        }
    }
}
