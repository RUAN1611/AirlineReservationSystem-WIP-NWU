# AirlineReservationSystem-WIP-NWU Development
This is one of my initial projects, developed using the ASP.NET Core framework and implementing the Model-View-Controller (MVC) pattern. 
A lot of editing is required and there is much work to do. The purpose for this application was to create an airline reservation system 
where customers can order flight tickets based on domestic flights (South Africa).

## Why Did I Choose This Project For Homework Exercise 1
"_The context of the repository is that you will be use it to source control the code of a solution that had the most impact on your 
software development career up until now._"

The reason I uploaded this "Work-In-Progress" solution is because it had a significant impact on my perception of software development. 
This project allowed me to leverage and reinforce the skills that I had acquired over the past year, particularly in database design. 
However, one of the biggest takeaways was the importance of thoroughly studying business rules before starting a project. 
To thrive in my software development career, I need to possess the necessary skills to analyze specific business situations, 
communicate with business users, and plan the solution effectively.

Unfortunately, while developing the solution, I realized that I initially overlooked certain key attributes in the database design. 
Important attributes such as _economy class_, _one-way flights_, _round-trip flights_, and the _list of available tickets per flight_ were not 
included in the initial database design. These were basic attributes that I missed out on by not first studying the business rules 
required in a system that this solution tried to create.

It is for this very reason that I learned just how important it will be in my career to not only be an effective coder, but also a
good systems analyst. These are skills that I have indeed acquired the past year, and now I need to apply them in my upcoming projects.

## Problem That My Code Solves
As shown earlier in the project description, this solution is to create an airline reservation system for a business where customers
can order domestic flight tickets in South Africa on an effective web application.

## Problem Solving Approach

**"Rapid Application Development" (RAD)**

To initially plan this solution, I opened draw.io and started thinking about how the system would work. I started
drawing an Entity-Relationship Diagram for the database. After creating all the entities and relationships, I started creating the solution.

To do this, I made use of the Code-First approach using Entity Framework Core.
I created a model, added a migration while seeding the table, updated the database, added the controller, added the views, 
and then I repeated this same process. Using EF Core, I did not have to directly access the database and this made 
my problem-solving approach more effective and easier.