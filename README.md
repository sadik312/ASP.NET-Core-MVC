### Model-View-Controller Application using ASP.NET Core

### What is an MVC model?
- Design pattern used implement UI, data, controlling logic

### How the MVC Model works:

Model:
- Manages data and business logic
    - busines logic: data validation, error handling, authorisation & security

View:
- Presents data to user and receives user input
- Deals with visual representation and UI components of app

Controller:
- Acts as an intermediary between Model and View
- Controller receives user input from View, processes it, and updats Model
- Responsible for interpreting user actions by invoking methods in Model to update data or trigger business logic
    - handles user interactions, e.g adding item to cart. 
    - It interacts with Model to update data (e.g update cart, record purchase in order history)
    - Ensures View reflects current state of application