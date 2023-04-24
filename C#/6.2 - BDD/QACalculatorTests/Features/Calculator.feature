Feature:
	Various scenarios to test the calculator

Scenario: Add two numbers
	Given a calculator
	When I add 2 and 9
	Then the outcome should be 11