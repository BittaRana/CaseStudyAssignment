Feature: SalesDashboardPage
Note:: This is based on my assumption 
Discription: The Dashboard Page consist of links to navigate to
- LeadPage 
- ClientPage 
- Statistics ;
however the test cannot be executed as the used test data does not exist
This covers only some of the features from Sales Dashboard Page.


@Test
Scenario: Sales:: DashboardsPage:: As a user, I should be able to successfully login as a Sales Manager
	Given I open the login form
	And I enter a valid username
	And I enter a valid password
	When I click on the Login button
	Then I successfully login as a Sales Manager
	