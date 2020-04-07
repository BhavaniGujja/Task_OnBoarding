Feature: 
         In Profile functionality, 
         In order to describe as a person to buyers to know about the current user
         User will update all the Educations details, Language Skills, Other Skills, Certifications and details.

@Description
Scenario: User want to add Description about himself/herself
   Given User is in profile page and want to add description
   When user click on edit to describe in words allowed to write 600 characters word limit
   Then the text will be saved in the description about the user


@languages 
Scenario: User want to click on Languages Icon
   Given User is in profile page and want to click on Languages
   When user click on language icon 
   Then navigated to click on Add new to add Languages upto four.

Scenario: User want to add the number of languages and details of languages he speak
   Given User is in profile page and want to add languages and details
   When user click on add new, enter the name and level of language
   Then click on add button for successful saving of language details.

Scenario: User want to delete the saved language details
   Given User is in profile page and want delete the languages saved
   When user select the which language should be deleted, click on close button to delete
   Then user selected language is successfully deleted.


@Skills
Scenario: User want to click on Skills Icon
   Given User is in profile page and want to click on skills
   When user click on Skills icon 
   Then navigated to click on Add new to add skills with deatails.

 Scenario: User want to add the number of skills
    Given User is in profile page and want to add new number of skills
    When user click on Add new, enter the name and level of skill
    Then click on Add button for successful saving of skill details.

Scenario: User want to delete the saved skill details
   Given User is in profile page and want to delete saved skills
   When user select the which skill should deleted, click on close button to delete in skills
   Then user selected skill is successfully deleted.


@Education
Scenario: User want to click on Education Icon
   Given User is in profile page and want to click on Education icon
   When user click on Education icon 
   Then navigated to click on Add new to add Education with details.

Scenario: User want to add the number of Education qualifications
   Given User is in profile page and want click to add number of Education qualifications
   When user click on Add new, enter the all the details mentioned
   Then click on Add button for successful saving of Education details.

Scenario: User want to delete the saved Education details
   Given User is in profile page and want to delete education details
   When user select the which education should deleted, click on close button to delete in education
   Then user selected education details are successfully deleted.


@Certification
Scenario: User want to click on Certification Icon
   Given User is in profile page and  want to click on Certification icon
   When user click on certification icon 
   Then navigated to click on Add new to add certification with details.

Scenario: User want to add the number of Certifications
   Given User is in profile page and want to click to add number of certifications
   When user click on Add new, enter the all the details mentioned
   Then click on Add button for successful saving of Certification details.

Scenario: User want to delete the saved Certification details
   Given User is in profile page and want to delete saved certification details
   When user select the which certification should deleted, click on close button to delete in certification
   Then user selected certification details are successfully deleted.














