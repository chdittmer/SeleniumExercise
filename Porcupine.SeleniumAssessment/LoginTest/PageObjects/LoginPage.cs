using OpenQA.Selenium;

namespace SeleniumLoginTest.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        private IWebElement UsernameField => _driver.FindElement(By.Id("user-name"));
        private IWebElement PasswordField => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.Id("login-button"));

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Enters the provided username into the username field
        public void EnterUsername(string username)
        {
            UsernameField.SendKeys(username);
        }

        // Enters the provided password into the password field
        public void EnterPassword(string password)
        {
            PasswordField.SendKeys(password);
        }

        // Clicks the login button
        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        // Performs the login action with provided username and password
        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLoginButton();
        }
    }
}
