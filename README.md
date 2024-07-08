# SeleniumExercise

### Here’s what you will need to begin:
-	An internet connection
-	Google Chrome
-	Visual Studio Community Edition (Free) https://visualstudio.microsoft.com/vs/community/
- .Net 6 SDK will need to be installed on your machine
- A Github account
- Git client (feel free to use your favourite)

### Your Project setup:
-	The project needs to be completed using the prescribed tools and coding language C#.
-	You will need to clone the repository to your local machine.
-	Create a new branch with an appropriate name to develop your tests
-	Open the project using Visual Studio and ensure the below are installed to the project
     -	[ ] Selenium WebDriver (installed via Nuget package manager into your project)
     -	[ ] Selenium WebDriver ChromeDriver (installed via Nuget package manager into your project)
     -	[ ] NUnit test framework (installed via Nuget package manager into your project)
     -	[ ] NUnit3TestAdapter (installed via Nuget package manager into your project)
     -	[ ] Set your driver instances implicit wait to 15 seconds; example: yourDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15); (This is required for the test to run smoothly)
######
> - Hint: Add comments in your code to justify your thinking.
> - Hint: You can use any method to identify the elements you interact with.

## Your mission:
Automate some operations on the following Selenium practice website: https://www.saucedemo.com/ as described below. You have two objectives, please create a seperate test for each and use an appropriate test name for each test.

### Test Case 1
Log In
Steps to Automate:
1. Open this url https://www.saucedemo.com/
2. Select a username from the list of accepted usernames
3. Enter that into the Username field
4. Enter the password in the Password field
5. Click the login button
6. Verify that the user has been logged in successfully

### Test Case 2
Purchase a product
Steps to Automate:
1. Open this url https://www.saucedemo.com/
2. Sign into the web site
3. Select any product and click the "Add to cart" button for that product
4. Click the shopping cart button
5. Verify the product you selected has been added to the cart
6. Checkout
7. Enter a Firstname, Lastname and Zip Code into the fields
8. Click Continue
9. Verify that the correct product is still in the cart
10. Click Finish
11. Verify that the confirmation message is displayed


# What to do when you are done
- Push your changes to Github and create a Pull Request for your tests
