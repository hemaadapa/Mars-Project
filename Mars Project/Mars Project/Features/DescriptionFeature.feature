Feature: DescriptionFeature

I want the feature to add my description details

@AddDescription
Scenario: Add Description to profile page
	Given I logged into the Mars Portal 
	When I Add Description to the Profile page
    Then Description should be added successfully.
