using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Porcupine.SeleniumAssessment
{
    public class AutomationPracticeTests
    {
        [TestCase]
        public void CreateAccountTestcase()
        {
            // Open Browser - Chrome Driver
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            // Navigate to URL - test site
            webDriver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            // Sign in - Btn element
            IWebElement clickLogin = webDriver.FindElement(By.LinkText("Sign in"));
            clickLogin.Click();

            // Verify page change
            var txtCreateAnAccount = webDriver.FindElement(By.Id("create-account_form"));
            Assert.That(txtCreateAnAccount.Displayed);

            // Create new Account
            var mailAddress = "MaryAPedrosa@teleworm.us";
            webDriver.FindElement(By.Id("email_create")).SendKeys(mailAddress);

            // Click btn Create an Account
            IWebElement clickCreate = webDriver.FindElement(By.Name("SubmitCreate"));
            clickCreate.Click();

            // Select title
            IWebElement titleSelect = webDriver.FindElement(By.Id("id_gender1"));
            titleSelect.Click();

            // Capture first name
            webDriver.FindElement(By.Id("customer_firstname")).SendKeys("Lachlan");

            // Capture last name
            webDriver.FindElement(By.Id("customer_lastname")).SendKeys("Taylor");

            // Verify email address
            var vertifyEmail = webDriver.FindElement(By.Id("email"));
            vertifyEmail.Click();

            // Capture Password
            webDriver.FindElement(By.Id("passwd")).SendKeys("QWERTY123");

            //Select dropdownlist for Date of Birth - Days
            var dobDate = webDriver.FindElement(By.Id("days"));
            var selectElementD = new SelectElement(dobDate);

            selectElementD.SelectByValue("1");

            //Select dropdownlist for Date of Birth - Month
            var dobMonth = webDriver.FindElement(By.Id("months"));
            var selectElementM = new SelectElement(dobMonth);

            selectElementM.SelectByValue("12");

            //Select dropdownlist for Date of Birth - Year
            var dobYear = webDriver.FindElement(By.Id("years"));
            var selectElementY = new SelectElement(dobYear);

            selectElementY.SelectByValue("1990");

            // Select "Sign up for our Newsletter!
            var chckboxNews = webDriver.FindElement(By.Id("newsletter"));
            chckboxNews.Click();

            // Select "Receive special offers from our partners!"
            var chckboxSpecial = webDriver.FindElement(By.Id("optin"));
            chckboxSpecial.Click();

            // Capture Company details
            webDriver.FindElement(By.Id("company")).SendKeys("Harold's");

            // Capture Personal address
            webDriver.FindElement(By.Id("address1")).SendKeys("4514 Jones Street");
            webDriver.FindElement(By.Id("address2")).SendKeys("N/A");
            webDriver.FindElement(By.Id("city")).SendKeys("Fort Worth");
            var stateSelect = webDriver.FindElement(By.Id("id_state"));
            var selectElementState = new SelectElement(stateSelect);

            selectElementState.SelectByText("Texas");

            webDriver.FindElement(By.Id("postcode")).SendKeys("76107");
            webDriver.FindElement(By.Id("other")).SendKeys("Oh wow this is my very first C# test case, I wonder how the suite management will work?");
            webDriver.FindElement(By.Id("phone")).SendKeys("085 188 5777");
            webDriver.FindElement(By.Id("phone_mobile")).SendKeys("085 188 5773");

            // Click Register account BTN
            var registerbtn = webDriver.FindElement(By.Id("submitAccount"));
            registerbtn.Click();

            // Click Signout btn
            var signoutBtn = webDriver.FindElement(By.LinkText("Sign out"));
            signoutBtn.Click();

            // Create new Account again with same credentials
            webDriver.FindElement(By.Id("email_create")).SendKeys(mailAddress);

            // Click btn Create an Account
            IWebElement clickCreateAgain = webDriver.FindElement(By.Name("SubmitCreate"));
            clickCreateAgain.Click();

            // Account Already Exist
            var txtAlreadyExist = webDriver.FindElement(By.Id("create_account_error"));
            Assert.IsFalse(txtAlreadyExist.Displayed);

            // Close browser
            webDriver.Quit();

        }
    }
}
