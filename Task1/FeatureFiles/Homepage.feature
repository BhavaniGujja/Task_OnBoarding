Feature: Homepage with Login-Testcases
         In order, user login to my account with credentials
         To register new account, user joinin.

@Login 
Scenario: User want to Login with credentials
   Given User is in home page and want to login
   When user enter the valid credentials with user name and password
   Then user will be successfully Logged into the website

Scenario: User want to Login with credentails but failure
   Given User is in home page and want to login
   When user enter the invalid credentials with user name and password
   Then user will be unsuccessfully Logged into the website and appropriate error message will be displayed

@Joinin 
Scenario: User want to create a new account to access website
   Given User is in home page and  want to create account
   When click on joiin , user enter First name, Last name, email, password and confirm password
   Then user will be creating a account successfully.

  





