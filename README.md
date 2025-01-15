# Product Management System (PMS)
# Author : Satyam 
**Product Management System (PMS)**!
Sir, This is a simple system that allows users to perform basic CRUD (Create, Read, Update, Delete) operations on products. Below are the main functionalities and how they work.

## Features
- **Add new items**: Users can add new products to the system.
- **Edit and update existing items**: Users can modify and update product details.
- **Delete items**: Users can remove products from the system.

## Operations

![image](https://github.com/user-attachments/assets/f950c25c-387d-422f-b825-5d85f448d793)

### 1. **GET - Get All Products**

This operation fetches a list of all products in the system.

![image](https://github.com/user-attachments/assets/fa426c6f-97e3-43dd-a4a0-9694f56657f7)


- **Request**: `GET /api/products`
- **Response**: A list of all products.

### 2. **GET - Get Single Product**

This operation fetches the details of a single product.
![image](https://github.com/user-attachments/assets/7c8f4c90-b423-49d6-8b77-d0fbe9c49789)




- **Request**: `GET /api/products/{id}`
- **Response**: Details of a product with the specified ID.

### 3. **POST - Add New Product**

This operation allows users to create and add new products to the system.

![image](https://github.com/user-attachments/assets/9a579ef8-7f54-4cc4-b2c9-31b51dbfe271)

![image](https://github.com/user-attachments/assets/d1f2b06f-a3bd-4a52-a09f-2016fdd9d2f2)
![image](https://github.com/user-attachments/assets/0e613397-ca41-4d78-8650-59b7d6127c35)


- **Request**: `POST /api/products`
- **Body**: A JSON object with the product details (name, description, price, etc.).
- **Response**: A confirmation of the new product added.

### 4. **PUT - Update Existing Product**

This operation updates the details of an existing product.

![image](https://github.com/user-attachments/assets/c706ca42-b360-4d3a-ae38-ae2e4f5de844)
![image](https://github.com/user-attachments/assets/1cc816c3-0a6b-41f1-b62a-23e7510fa2d3)
![image](https://github.com/user-attachments/assets/0a283b4f-6c38-4d8e-a81a-02b8c067cf9c)


- **Request**: `PUT /api/products/{id}`
- **Body**: A JSON object with updated product details.
- **Response**: A confirmation that the product was updated successfully.

### 5. **DELETE - Delete Product**

This operation removes a product from the system.

![image](https://github.com/user-attachments/assets/123bc7a8-613b-41b6-9143-cbcf2a1e28a9)
![image](https://github.com/user-attachments/assets/92ec3452-34a7-4921-9474-58f1da239313)
![image](https://github.com/user-attachments/assets/0becab52-aa11-41ba-b011-11e3d37d2ab9)


- **Request**: `DELETE /api/products/{id}`
- **Response**: A confirmation that the product has been deleted.

## Database

The system uses a **local SQL Server database** to store and retrieve product information.

## Code Quality and Design

- The code is designed to be **readable**, **maintainable**, and **easy to extend** for future requirements.
- **SOLID principles** are followed to ensure clean and modular design.
- **HTTP verbs** (GET, POST, PUT, DELETE) are used correctly to perform CRUD operations.

## Installation

To run the project locally, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/ProductManagementSystem.git
   git install
   
