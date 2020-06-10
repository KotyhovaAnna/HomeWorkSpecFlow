Feature:Login and create new product
As a user
	I want to login and create product to the app
	So i can create a new product

Scenario: Login and create new product

Given I open "http://localhost:5000/" url
When I type the word "user" in the Name field
When I type the word "user" in the Password field
And I click the login button 
And I click the All products button in section Home page
And I click the create new button
And I type the word "mors" in the in section ProductName
And I select "Produce" in the in section Category
And I select "Mayumi's" in the in section Supplier
And I type the value "30" in the in section UnitPrice
And I type the value "95" in the in section QuantityPerUnit
And I type the value "9" in the in section UnitsInStock
And I type the value "74" in the in section UnitsOnOrder
And I type the value "8" in the in section ReorderLevel
When I click the send button
Then I check that product "mors" has been created

