Feature: Product creation
As a user
I want to create a product with my own values

Scenario: Product creation
	Given I login to "http://localhost:5000/"
	When I click on All Products button
	And I click on Create New button
	And I enter values "Salmon", "Seafood", "Mayumi's", "32", "2", "3", "4", "5"
	And I click on Send button
	Then A product named "Salmon" should appear on the product page