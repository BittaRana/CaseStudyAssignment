Feature: LeadsPage

Note:: This is based on my assumption 
Discription: The Leads Page consists of 
- Names of Leads 
- Interested Product's Name; 
however the test cannot be executed as the test data does not exist
This covers only some of the features from Leads Page.


@Test
Scenario: Sales:: LeadPage:: SmokeTest:: As a user I am able to see all the list of name of the Leads called for inquiry of the product
	Given I open the login form
	And I enter a valid username
	And I enter a valid password
	And I click on the Login button
	When I click the LeadPage button
	Then List of name of the Leads and products are displayed
