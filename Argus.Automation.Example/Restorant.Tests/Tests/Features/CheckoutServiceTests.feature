Feature: CheckoutServiceTests

Background: 
	Given Restaurant opens with menu by set cost
		| Starters | Mains | Drinks | Service Charge | Drinks Discount | Drinks Discount Time |
		| £4.00    | £7.00 | £2.50  | 10%            | 30%             | 19:00 - 23:00        |

@TEST-1 @checkout
Scenario: Checkout Service - Standard Order - Check bill calculated correctly
	When Clients make an order
		| TableNumber | StartersCount | MainsCount | DrinksCount | OrderTime |
		| 1           | 4             | 4          | 4           | 16:00     |
		* Clients requested a bill
	Then Clients assert bill amount equals to 56.10 pounds sterling

@TEST-2 @checkout
Scenario: Checkout Service - Extended Order - Check bill calculated correctly
	When Clients make an order
		| TableNumber | StartersCount | MainsCount | DrinksCount | OrderTime |
		| 1           | 1             | 2          | 2           | 18:59     |
		* Clients requested a bill
	Then Clients assert bill amount equals to 23.65 pounds sterling
	When Clients extend an order
		| TableNumber | MainsCount | DrinksCount | OrderTime |
		| 1           | 2          | 2           | 20:00     |
		* Clients requested a bill
	Then Clients assert bill amount equals to 44.55 pounds sterling

@TEST-3 @checkout
Scenario: Checkout Service - Partially Canceled Order - Check bill calculated correctly
	When Clients make an order
		| TableNumber | StartersCount | MainsCount | DrinksCount | OrderTime |
		| 1           | 1             | 1          | 4           | 19:00     |
		* Clients requested a bill
	Then Clients assert bill amount equals to 23.10 pounds sterling
	When Clients partially cancel an order
		| TableNumber | DrinksCount | OrderTime |
		| 1           | 1           | 19:01     |
		* Clients requested a bill
	Then Clients assert bill amount equals to 20.35 pounds sterling