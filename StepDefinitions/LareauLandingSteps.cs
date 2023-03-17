// This test is executable
// I have used Lareau website "https://lareau.ca/" and this is the only executable feature as other features are based on my assumption

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CaseStudy.StepDefinitions
{
    [Binding]
    public sealed class LareauLandingSteps
    {
        private IWebDriver driver;

        [Given(@"I open the Browser")]
        public void GivenIOpenTheBrowser()
        {
            driver = new ChromeDriver();
        }

        [When(@"Enter the url")]
        public void WhenEnterTheUrl()
        {
            driver.Url = "https://lareau.ca/";
        }

        [Then(@"Close the Browser")]
        public void CloseBrowser()
        {
            driver.Quit();
        }

    }
}