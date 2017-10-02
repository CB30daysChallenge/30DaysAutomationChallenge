Feature: ToDoMvcFeature
	In order to create and view Active/Completed/All tasks in the ToDoMvc AngularJSpage
	As a user
	I want to ensure the ToDOMVc page elements and task lists are displayed correctly

@Browser_Chrome
@Browser_Firefox
Scenario:Verify Completed Lists
Given I am on the ToDoMvc AngularJS Page
When I Enter New tasks
| Tasks      |
| US Racing  |
| Specflow   | 
And I click on the checkbox of one of the tasks
And I Click on the Complete 
Then all entered tasks are displayed

@Browser_Chrome
@Browser_Firefox
Scenario:Verify Active Lists
Given I am on the ToDoMvc AngularJS Page
When I Enter New tasks
| Tasks              |
| 30 days Challenge  |
| Unit Tests         | 
And I Click on the Active 
Then all entered tasks are displayed

@Browser_Chrome
@Browser_Firefox
Scenario:Verify New Tasks
Given I am on the ToDoMvc AngularJS Page
When I Enter New tasks
| Tasks             |
| SIS Greyhounds    |
| SIS Throughbreds  | 
Then all entered tasks are displayed

@Browser_Chrome
@Browser_Firefox
Scenario:Verify All Lists
Given I am on the ToDoMvc AngularJS Page
When I Enter New tasks
| Tasks      |
| Automation |
| Atlas      |
And I click on the checkbox of one of the tasks
And I Click on the All 
Then all entered tasks are displayed

@Browser_Chrome
@Browser_Firefox
Scenario:Verify Clearing Completed Tasks
Given I am on the ToDoMvc AngularJS Page
When I Enter New tasks
| Tasks              |
| Betradar           |
| Sporting Solutions |
And I Click on Checkbox of 'Betradar' one of Active tasks
And I Click on the Complete
And I click on the checkbox 'Betradar' one of the Completed tasks
And I Click on the ClearCompleted
And I Click on the All
Then only 'Sporting Solutions' is displayed in


#@Browser_Chrome
#@Browser_Firefox
##@New_Task
#Scenario:Verify New Tasks
#Given I am on the ToDoMvc AngularJS Page
#When I Enter New tasks
#| Tasks             |
#| SIS Greyhounds    |
#| SIS Throughbreds  | 
#Then all entered tasks are displayed
#| Tasks             |
#| SIS Greyhounds    |
#| SIS Throughbreds  |


#@Completed_List
#Scenario Outline:Verify Completed List
#Given I am on the ToDoMvc AngularJS Page
#When I Enter a New <Task>
#And I press Enter
#And I click on Checkbox of Acive <Task>
#And I Click on the Complete 
#Then the <Task> is displayed on the Completed List
#
#Examples:
#| Task       |
#| US Racing  |
#| Specflow   | 
#
#@Active_List
#Scenario Outline:Verify Active List
#Given I am on the ToDoMvc AngularJS Page
#When I Enter a New <Task>
#And I press Enter
#And I Click on the Active 
#Then active<Task> are displayed
#
#Examples:
#| Task               |
#| 30 days Challenge  |
#| Unit Tests         | 
#
#
#@New_Task
#Scenario Outline:Verify New Task
#Given I am on the ToDoMvc AngularJS Page
#When I Enter a New <Task>
#And I press Enter
#Then the new <Task> is populated on the List
#	
#Examples:
#| Task              |
#| 30 days Challenge |
#
#@Complete_Task
#Scenario Outline: Verify Complete Task
#Given I am on the ToDoMvc AngularJS Page
#When I Enter a New <Task>
#And I press Enter
#And I click on Checkbox of Acive <Task>
#And I Click on the Complete 
#Then the <Task> is displayed on the Completed List
#
#Examples:
#| Task       |
#| Unit Tests |
#
#@Clear_Completed_Task
#Scenario Outline:Verify Clear Complete Task
#Given I am on the ToDoMvc AngularJS Page
#When I Enter a New <Task1>
#And I press Enter
#And I Enter a New <Task2>
#And I press Enter
#And I click on Checkbox of Acive <Task1>
#And I Click on the Complete 
#And click on Completed <Task1>
#Then only <Task2> is Displayed
#And <Task1> is not Displayed
#
#Examples:
#| Task1   | Task2     |
#| Meetups | Challenge |
