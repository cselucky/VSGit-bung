Feature: Smarthome Device Management
	As Smarthome User
	I want to manage my Home Devices
	so that I‘m always in control of my home

@mytag
Scenario: Add device
	Given an empty device list
	When I add <HUE Lampe1> to my device list
	Then there should be 1 device in my device list
	And <HUE Lampe1> is in my device list

Scenario: Delete device
	Given 1 device is in my device list
	And the device is <HUE Lampe 1>
	When I delete <HUE Lampe 1> from my device list
	Then there should be 0 device in my device list
	And <HUE Lampe1> is not in my device list