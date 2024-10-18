# Table of Contents
1. [Project Overview](#project-overview)

2. [Features](#features)
  
3. [Database Schema](#database-schema)

4. [Contact Information](#contact-information)

# E-commerce ASP.NET MVC Project
##  Project Overview
**Description**: This is an e-commerce web application built using ASP.NET MVC. It allows users to view products, add them to the cart, and make purchases.

## Features
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

## Database Schema
- **Database**: The project uses SQL Server as the database.
- **Approach**: The project is developed using the **Database First** approach, where the database schema is used to generate the data models.
- **Fluent API**: The database configurations and relationships are managed using the Fluent API, located in the `./src/Data/Configuration` directory. This allows precise control over how the entities and their relationships are mapped to the database schema.
- **Description**: The main tables include entities such as `Users`, `Products`, `Orders`, and `OrderDetails`. Relationships between these entities are defined using Fluent API configurations.
- **Migrations**: Although the project uses the Database First approach, any updates to the database schema should be followed by updating the models and Fluent API configurations.
  ![database relationships](https://github.com/leh23211213/docker-dotnet-ecommerce-mvc/blob/main/src/Data/sql/DatabaseRelationShips.png)

##Screen Shot
 ### Product
 ![Product](https://github.com/leh23211213/docker-dotnet-ecommerce-mvc/blob/main/src/wwwroot/lib/image/product.png)
### Product Details
 ![Product Details](https://github.com/leh23211213/docker-dotnet-ecommerce-mvc/blob/main/src/wwwroot/lib/image/productDetails.png)
 ### Cart
 ![Cart](https://github.com/leh23211213/docker-dotnet-ecommerce-mvc/blob/main/src/wwwroot/lib/image/Cart.png)
### Order
 ![Order](https://github.com/leh23211213/docker-dotnet-ecommerce-mvc/blob/main/src/wwwroot/lib/image/Order.png)
### Order Details
 ![Order Details](https://github.com/leh23211213/docker-dotnet-ecommerce-mvc/blob/main/src/wwwroot/lib/image/OrderDetail.png)



## Contact Information
## 🔗 Links

[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/le-hiep-1809b4184/)
[![email](https://img.shields.io/badge/email-D14836?style=for-the-badge&logo=gmail&logoColor=white)](mailto:leh23211213@gmail.com)


