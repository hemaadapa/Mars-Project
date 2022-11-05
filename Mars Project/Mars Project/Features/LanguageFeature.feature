Feature: LanguageFeature

I want the feature to add my language details

@AddLanguage
Scenario: 1-1 Add language on profile.
	Given I logged into the Mars Portal 
	When I add Language to the profile page
    Then The Language Record should be added successfully

@Editlanguage
Scenario Outline:1-2 Edit language on profile
Given I logged into the Mars Portal 
When I edit '<Language>' and '<LanguageLevel>' on an existing language record.
Then The record should have the edited '<Language>' and '<LanguageLevel>'

Examples: 
| Language | LanguageLevel |
| Telugu   | Fluent        |

 

@Deletelanguage
Scenario Outline:1-3 Delete language on profile
Given I logged into the Mars Portal 
When I delete a language record on my profile
Then The record should be deleted successfully




