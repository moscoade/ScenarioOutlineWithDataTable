using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace FormAutomation.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(80);

        }

       

        [AfterScenario]
        public void AfterScenario()
        {
          //driver.Quit();
          //driver.Dispose();
        }
    }
}