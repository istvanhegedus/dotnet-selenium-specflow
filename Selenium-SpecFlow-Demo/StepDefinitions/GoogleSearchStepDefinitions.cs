using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumSpecFlowDemo.StepDefinitions
{
    [Binding]
    public class GoogleSearchStepDefinitions : Steps
    {
        [Given(@"that I am on Google Search page")]
        public void GivenThatIAmOnGoogleSearchPage()
        {
            var webDriver = ScenarioContext.Get<IWebDriver>("webdriver");
            WebDriverWait wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 5));

            //Open the page
            webDriver.Navigate().GoToUrl("https://google.com");

            //Wait for the Accept all button
            wait.Until(drv => drv.FindElement(By.Id("L2AGLb")));
            //Click the Accept all button
            webDriver.FindElement(By.Id("L2AGLb")).Click();

            //Wait until the Search Input is visible to the user (=displayed)
            wait.Until(drv => drv.FindElement(By.CssSelector("input.gLFyf")).Displayed);
        }

        [When(@"I search for the word ""([^""]*)""")]
        public void WhenISearchForTheWord(string word)
        {
            var webDriver = ScenarioContext.Get<IWebDriver>("webdriver");
            WebDriverWait wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 5));

            //Type the word in search input
            var input = webDriver.FindElement(By.CssSelector("input.gLFyf"));
            input.SendKeys(word);

            //Click on Google Search
            input.Submit();
        }

        [Then(@"I can see results")]
        public void ThenICanSeeResults()
        {
            var webDriver = ScenarioContext.Get<IWebDriver>("webdriver");
            WebDriverWait wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 5));

            //Wait until result statistics are displayed 
            wait.Until(drv => drv.FindElement(By.Id("result-stats")).Displayed);
            var resultStats = webDriver.FindElement(By.Id("result-stats"));

            //Result statistics should be displayed
            resultStats.Displayed.Should().BeTrue();
        }
    }
}
