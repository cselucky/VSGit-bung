Feature: Taschenrechner
	In order to avoid silly mistakes
	As a math idiot
	I want to be able to calculate with two numbers

@mytag
Scenario Outline: Multiply two numbers
	Given the first number is <firstNum>
	And the second number is <secondNum>
	When the two numbers are multiplied
	Then the result should be <result>

Examples: 
	| firstNum | secondNum | result |
	| 3        | 5         | 15     |
	| 0        | 2         | 0      |
	| 7        | 12        | 84     |