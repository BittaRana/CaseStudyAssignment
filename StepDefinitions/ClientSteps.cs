// Note: This is based on my assumption and the code is not executable
// All the selectors and url do not exist

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CaseStudy.StepDefinitions
{
	[Binding]
	public sealed class ClientSteps
	{
		private IWebDriver driver;
		[Given(@"I open the login form")]
		public void GivenIOpenTheLoginForm()
		{
			driver.url("Form Url")
		}

		[And(@"I enter a valid username")]
		public void GivenIEnterAValidUsername()
		{
			// find the selector
			driver.find_element(By.ID, "id_of_element").sendkeys("username")
		}

		[And(@"I enter a valid password")]
		public void GivenIEntersAValidPassword()
		{
			// find the selector
			// and type password
			driver.find_element(By.ID, "id_of_element").sendkeys("password")
		}

		[And(@"I click on the Login button")]
		public void WhenIClickOnTheLoginButton()
		{
			//find the selector for login button
			// and click the button 
			driver.find_element(By.ID, "id_of_element").click()
		}

		[When(@"I click the ClientPage button")]
		public void clickClientLink()
		{
            //find the selector for Leads button
            // and click the link
            driver.find_element(By.Link, "link_of_element").click()

        }
        [Then(@"Name of the Client and purchased products are displayed")]
        public void LeadNameisDisplayed()
		{ 
			// Find the selecter of Lead name and compare the expected result with actual result
            WebElement ClientName = driver.find_element(By.xpath("Selector")); // this is only for sample as the xpath does not exist
			ClientName.isDisplayed();

            }

        }
    }

    
