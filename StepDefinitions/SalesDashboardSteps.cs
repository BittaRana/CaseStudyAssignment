// Note: This is based on my assumption and the code is not executable
// All the selectors and url do not exist

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CaseStudy.StepDefinitions
{
	[Binding]
	public sealed class SalesDashboardSteps
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
			// find the css selector
			driver.find_element(By.ID, "id_of_element").sendkeys("username")
		}

		[And(@"I enter a valid password")]
		public void GivenIEntersAValidPassword()
		{
			// find the css selector
			// and type password
			driver.find_element(By.ID, "id_of_element").sendkeys("password")
		}

		[When(@"I click on the Login button")]
		public void WhenIClickOnTheLoginButton()
		{
			//find the css selector for login button
			// and click the button 
			driver.find_element(By.ID, "id_of_element").click()
		}

		[Then(@"I successfully login as a Sales Manager")]
		public void ThenIAmSuccessfullyLoginAsASalesManager()
		{
			// Find the css selecter of Dashboard Page and compare the expected result with actual result
			WebElement DashboardTitle = driver.find_element(By.xpath("//a[contains(text(), 'Dashboard')]")); // this is only for sample as the xpath does not exist
			Assert.assertEquals(expected, actual);

		}

	}
}