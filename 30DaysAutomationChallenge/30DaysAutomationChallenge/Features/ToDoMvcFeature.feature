Feature: ToDoMvcFeature


@All_List
Scenario Outline:Verify All List
Given I am on the ToDoMvc AngularJS Page
When I Click on the All 
Then all<Tasks> are displayed

Examples:
| Tasks      |
| automation |
| US Racing  |
| Specflow   |
| Atlas      | 

@Completed_List
Scenario Outline:Verify Completed List
Given I am on the ToDoMvc AngularJS Page
When I Click on the Completed 
Then completed<Tasks> are displayed

Examples:
| Tasks      |
| US Racing  |
| Specflow   | 

@Active_List
Scenario Outline:Verify Active List
Given I am on the ToDoMvc AngularJS Page
When I Click on the Active 
Then active<Tasks> are displayed

Examples:
| Tasks      |
| US Racing  |
| Specflow   | 


@New_Task
Scenario Outline:Verify New Task
Given I am on the ToDoMvc AngularJS Page
When I Enter a New <Task>
And I press Enter
Then the new <Task> is populated on the List
	
Examples:
| Task             |
| 30days Challenge |

@Complete_Task
Scenario Outline: Verify Complete Task
Given I am on the ToDoMvc AngularJS Page
When I Click on Active
And I click on Acive <Task>
Then the <Task> is dissapeared from the Active List

Examples:
| Task       |
| Unit Tests |

