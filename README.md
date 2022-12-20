#How to start

Install tools: 
- Visual Studio 2022
- SpecFlow Extension

Start the tests:
1. Open the solution: Selenium-SpecFlow-Demo.sln
2. Build the project
3. Open Test Explorer (menu: Test -> Test Explorer)
4. Right click on the test case in Test Explorer and Click run

#Tools used

Visual Studio 2022.

##Framework

Used: **.NET 6**

At this point I think using the latest LTS .NET framework would make sense when starting a new project

##BDD framework

Used: **SpecFlow**

Install SpecFlow Extension - after that you will have new project template available in VS.

##Test runners

Used: **NUnit**

There are options to chose test executor:
You can use the SpecFlow+ Runner
Or you can choose between the usual test runners: mstest, nunit, xunit
https://specflow.org/tools/runner/

#Steps to create the project
1.  Install Visual Studio 2022 (it should install .NET 6 SDK)
2.  Install SpecFlow extension in VS and restart it
3.  Start new project and search for SpecFlow template
4.  Choose .NET 6.0 and NUnit and tick "Add FluentAssertions library"
5.  Install Selenium.WebDriver Nuget package
6.  Install Selenium.WebDriver.ChromeDriver package
7.  Add new feature file
8.  Type the Gerkhin AC
9.  Right click on them and click Define Steps
10. Add a Hooks.cs file to Support folder for setting up Chrome before Scenario (see code for details)
11. I've using inheritence for my binding from SpecFlow Steps class to access ScenarioContext and webdriver
	There are better (and more complex) solutiouns to do this see official examples
12. Add the implementation to generated steps file

For better and more complex examples: https://github.com/SpecFlowOSS/SpecFlow-Examples
In the repo you can check: ASP.NET-MVC\BookShop
See description about it here: https://docs.specflow.org/projects/specflow/en/latest/Getting-Started/Getting-Started-With-An-Example.html#ui-level-automation-with-selenium

#TODOs

Add Page Object Model and Drivers
	Page Object Model is useful to introduce as it helps you to reuse the locators
	Currently webdriver code is implemented in the steps, SpecFlow suggest to separate that to Drivers folder
Add better handling for webdriver
	Should implement better solution than using Scenario context.

#Links

SpecFlow example repository:
https://github.com/SpecFlowOSS/SpecFlow-Examples.git

Driver pattern:
https://docs.specflow.org/projects/specflow/en/latest/Guides/DriverPattern.html




