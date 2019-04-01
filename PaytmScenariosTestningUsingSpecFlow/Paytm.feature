Feature: Paytm
	
@mytag
Scenario: validate Web elements of Paytm Home Page and Do Mobile Recharge
	Given I am at the Paytm Home Page
	And I Validate Mobile
	And I Validate Electicity
	And I validate DTH 
	And I validate Metro
	And I click on mobile Link
	And I have Entered <Mobile number> and <Amount>
	When I click Proceed to recharge
	Then Web elements should be validated and It should navigate to 'https://paytm.com/coupons' page

	

