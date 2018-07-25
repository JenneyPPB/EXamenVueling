Feature: StudentRepositoryInsert
Insert Student in Student Repositoryj
	

@mytag
Scenario: Add two numbers
	Given I have a new student without Id
	When I run the method Insert of student Repository
	Then the Student Repository should return an student with Id
