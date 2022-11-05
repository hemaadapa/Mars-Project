Feature: SkillFeature

I want the feature to add my skills details

@Addskill
Scenario:1-1 add Skill on my profile
	Given I logged into the Mars Portal 
	When I add Skill on my profile page
	Then The skill record should be added successfully



@EditSkill
Scenario Outline: 1-2 Edit Skill On profile
Given I logged into the Mars Portal 
When I edit '<Skill>' and '<SkillLevel>' on an existing skill record
Then The record should have the updated '<Skill>' and '<Skilllevel>'

Examples: 
| Skill | SkillLevel |
| SQL   | Expert     |



@DeleteSkill
Scenario Outline: 1-3 Delete Skill record on profile
Given I logged into the Mars Portal 
When I delete a skill from an existing skill record
Then The Skill Record should be deleted successfully
