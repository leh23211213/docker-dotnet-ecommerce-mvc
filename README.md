
# E-commerce ASP.NET MVC Project
## Table of Contents
1. [Project Overview](#1-project-overview)
2. [Features](#2-features)
3. [Technologies Used](#3-technologies-used)
4. [Setup Instructions](#4-setup-instructions)
5. [Installation](#5-installation)
6. [Usage](#6-usage)
7. [Project Structure](#7-project-structure)
8. [Database Schema](#8-database-schema)
9. [Acknowledgements](#9-acknowledgements)
10. [Contact Information](#10-contact-information)

## 1. Project Overview
**Description**: This is an e-commerce web application built using ASP.NET MVC. It allows users to view products, add them to the cart, and make purchases.

## 2. Features
- **User Features**:
  - **View Products**: Users can browse through the product catalog with enhanced features such as:
    - **Product Search**: Quickly find specific products using the search functionality.
    - **Pagination**: Navigate through products easily with pagination, ensuring better usability and performance.
    - **Caching**: Improve load times by caching product data, reducing the need for repeated database queries.
      
  - **Add Products to the Cart**: Users can add products to their cart with the following capabilities:
    - **Increase/Decrease Quantities**: Adjust the quantity of products directly in the cart, with a maximum of 5 units per product.
    - **Remove Products**: Easily remove products from the cart.
    - **Cart Limitations**: Each cart can contain up to a maximum of 5 different products.
  - Make purchases

## 3. Technologies Used
- **Backend**: ASP.NET MVC, .NET Core 8
- **Frontend**: HTML, CSS, JavaScript, jQuery
- **Database**: SQL Server, configured using the **Database First** approach with Fluent API in the `./src/Data/Configuration` directory.

## 4. Setup Instructions
### Prerequisites
- .NET SDK
- SQL Server

## 5. Installation
1. Clone the repository
2. Set up the environment
3. Configure the database connection
4. Run migrations if needed
5. Run the project

## 6. Usage
- Instructions on how to run the application.
- How to access the main features of the application.
- Developer-specific instructions, if any.

## 7. Project Structure
- **Areas**:
  - The project is organized into different areas to manage specific functionalities. For example, the `Account` area contains all the related functionalities for user authentication and registration.
  - **Singleton Pattern**: In the `Areas/Account` folder, the Singleton pattern is used to ensure that each file is responsible for a single functionality. This structure includes:
    - `LoginController`: Handles user login operations.
    - `RegisterController`: Manages user registration.
    - `ExternalProviderLogin`: Manages third-party logins (ex: Google).
  - Each of these controllers is separated into its own file, ensuring a clear separation of concerns and easier maintainability.

## 8. Database Schema
- **Database**: The project uses SQL Server as the database.
- **Approach**: The project is developed using the **Database First** approach, where the database schema is used to generate the data models.
- **Fluent API**: The database configurations and relationships are managed using the Fluent API, located in the `./src/Data/Configuration` directory. This allows precise control over how the entities and their relationships are mapped to the database schema.
- **Description**: The main tables include entities such as `Users`, `Products`, `Orders`, and `OrderDetails`. Relationships between these entities are defined using Fluent API configurations.
- **Migrations**: Although the project uses the Database First approach, any updates to the database schema should be followed by updating the models and Fluent API configurations.
  ![database relationships](https://github.com/leh23211213/docker-dotnet-ecommerce-mvc/blob/main/src/Data/sql/DatabaseRelationShips.png)

## 9. Acknowledgements
- Recognition of tools, libraries, or individuals who contributed to the project.

## 10. Contact Information
## 🔗 Links

[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/le-hiep-1809b4184/)
[![email](https://img.shields.io/badge/email-D14836?style=for-the-badge&logo=gmail&logoColor=white)](mailto:leh23211213@gmail.com)


