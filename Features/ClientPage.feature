Feature: ClientPage

Note:: This is based on my assumption 
Discription: The Client Page consist of the Names of Clients and the Purchased Product's Name; 
however the test cannot be executed as the test data does not exist
This covers only some of the features from Client Page.

@Test
Scenario: Sales::ClientPage::SmokeTest::As a user I am able to see all the list of name of the Leads called for inquiry of the product
	Given I open the login form
	And I enter a valid username
	And I enter a valid password
	And I click on the Login button
	When I click the ClientPage button
	Then Name of the Client and purchased products are displayed
