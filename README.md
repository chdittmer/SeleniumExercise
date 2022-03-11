# SeleniumExercise

### Here’s what you will need to begin:
-	An internet connection
-	Google Chrome
-	Visual Studio Community Edition (Free) https://visualstudio.microsoft.com/vs/community/
- .Net 5 SDK will need to be installed on your machine
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
Automate some operations on the following Selenium practice website: http://automationpractice.com/index.php as described below. What you need to automate (should be seperate NUnit Test cases) please use an appropriate test name for each test.

### Test Case 1
Automate User Registration Process
Steps to Automate:
1. Open this url  http://automationpractice.com/index.php
2. Click on sign in link.
3. Enter a unique email address in 'Create and account' section.
4. Click on Create an Account button.
5. Enter your Personal Information, Address and Contact info.
6. Click on Register button.
7. Validate that user is created.

### Test Case 2
Verify error messages for mandatory fields.
Steps to Automate:
1. Open this url  http://automationpractice.com/index.php
2. Click on sign in link.
3. Enter email address and click Register button.
4. Leave the mandatory fields (marked with *) blank and click Register button.
5. Verify that error has been displayed for the mandatory fields.

# What to do when you are done
- Push your changes to Github and create a Pull Request for your tests
