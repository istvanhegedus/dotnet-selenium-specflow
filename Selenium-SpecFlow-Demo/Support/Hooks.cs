
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace SeleniumSpecFlowDemo.Support
{
    [Binding]
    public class Hooks : Steps
    {
        [BeforeScenario(Order = 1)]
        public void BeforeScenario()
        {
            var driver = new ChromeDriver();
            ScenarioContext.Add("webdriver", driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = ScenarioContext.Get<IWebDriver>("webdriver");
            driver.Quit();
        }
    }
}