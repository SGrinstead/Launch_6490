# Week 3 Assessment

### Setup
* In Package Manager Console
* `drop-database` and then
* `update-database`

## Exercise

Your goal for this assessment is to have an application that allows a user to do the following:
* Create a State by submitting a Form
* See all the cities for a specific state (city index page)
* Create a City for a State by submitting a form

### Creating a State (3 points)

Update the application so that a user can create a State by submitting a form.
* You will need to thoroughly test this functionality. 
* Do not break any currently passing tests.

### City Index Page (3 points)

Update the application so that a user could visit "/states/1/cities" to view all of the cities for a state (in this case, the state with id 1).
* You will need to thoroughly test this functionality. 
* Do not break any currently passing tests.

### Create a City (9 points)

Update the application so that the pre-existing CityCRUD tests will pass.
* There is some starter code that is not yet working.
* You may change any code in the Controllers, Views, and Models.
* You may NOT change the pre-existing tests.

## Questions (5 points)

Edit this file with your answers.

1. Create a Diagram of the Request/Response cycle that would occur when a user creates a city.  Include as much detail as possible!  **Send and image/screenshot of your diagram to your instructors via slack.** (2 points)

2. How does a form submission know what request should be made? Use examples.

    Inside the form header on the cshtml file you put the method and action. On the new state form, it reads ```<form method="post" action="/states">```,
    so when you click the submit button, it sends a "post" request to "/states".

3. Imagine you are explaining how to create a resource to a co-worker.  How would you describe how the controller action `Create` works?

    The create action takes in an HttpPost request and saves the information in the request body to the database. It
    then returns a redirect to a page relevant to the information that was added, usually an index or show page.

4. In our State creation functionality - what would happen if a user did not enter an Abbreviation before submitting the form?

    When a user submits the form without an abbreviation, We get an error when the program tries to save the state to the database
    in the create action in the states controller. Because the state object doesn't have any information for the Abbreviation
    property, the Abbreviation null when it tries to add it to the database, which is not allowed in this program.


## Rubric

This assessment has a total of 20 points.  A score of 15 or higher is a pass.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
