# *Farmer Tracker*


![Home](https://github.com/HumanClone/Prog3APart2/assets/74468682/5f51bf04-5996-4edc-9eec-58f46a8c09a7)

This Website allows Employees to add farmers to the database as well as view products withthe ability to search and filter the list based on various criteria


## Login

![Login 1](https://github.com/HumanClone/Prog3APart2/assets/74468682/423fb4f6-47e6-4ed0-bbcf-e173e079b65d)

the user click the login and must enter the credentials

![Login 2](https://github.com/HumanClone/Prog3APart2/assets/74468682/96156df5-74b4-4fa3-ac02-2f6fbf748f63)


## Employee

### if the user is an employee they will be directed to the employee home page in which they can choose what to do 
![Employee](https://github.com/HumanClone/Prog3APart2/assets/74468682/19558361-7129-48c6-b614-01f9bbe826b6)

### View Users 
Here the employee can view all the users in the system except thier passwords for security reasons, they are able to add new farmers as well
![View User](https://github.com/HumanClone/Prog3APart2/assets/74468682/00e9bc9c-e74f-48b7-b466-6495689f7d7b)

#### Add User
![New User](https://github.com/HumanClone/Prog3APart2/assets/74468682/7ed2f22f-9fb4-46de-94e8-4c7ca1f9d300)

the user will assign a password to the farmer which will then be encrypted and stored in the database

### View Products
Here the employee will be able to see al products in the system and search and filter as they deem 
![View product](https://github.com/HumanClone/Prog3APart2/assets/74468682/2a94660b-74f2-4660-95aa-c15a5cb91618)

#### filtered by product type eg dairy
![Filter 1](https://github.com/HumanClone/Prog3APart2/assets/74468682/e29ed578-6219-4337-88f6-dd33d48d4ed3)
#### Filtered by famrer: Alex Johnson or 1 as it works with either name or user id
![FIlter 2](https://github.com/HumanClone/Prog3APart2/assets/74468682/6417d272-77aa-4419-9149-d030d15a6903)
#### Filtered By date May 2023
![Filter 3](https://github.com/HumanClone/Prog3APart2/assets/74468682/83124465-906e-4931-bbfa-ce4b76336382)
#### Combonation of all : Jen Brown ,Grain in August
![Filter 4](https://github.com/HumanClone/Prog3APart2/assets/74468682/def3541e-640f-45db-b9f5-e3627e89ef91)
this is the end of the employees use cases 

## Farmer
### Profile
Here the farmer will be able to see all the product they have under their profile as well as add to it 
![Profile](https://github.com/HumanClone/Prog3APart2/assets/74468682/593e97c3-efa4-4f99-8dc1-71be1fa49f47)

### Adding a Product
![Add PRoduct](https://github.com/HumanClone/Prog3APart2/assets/74468682/1f16b443-3907-41aa-b82a-fbe2753db209)
That is the end case of the farmers

## How to Compile
**Connection string for the database is in the application JSon**

Open the folder in Vs code<br> 
RUn buid tasks<br>
in the Termnal run: dotnet run<br>
from there you will be given a local host port <br>
use  that port to access the  web application <br>
When it comes to connecting to a datbase, change the connection string in the application json settings to the string of the database

## Requirement
EntityFrameworkCore V5<br>
.Net V6<br>
asp.Core .Net<br>






