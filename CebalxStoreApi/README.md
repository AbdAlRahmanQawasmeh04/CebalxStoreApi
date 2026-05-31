# 🛒 CebalxStore API

A robust and scalable RESTful API built with **ASP.NET Core** and **Entity Framework Core**, designed to manage product data efficiently. This project demonstrates core backend development skills, including full CRUD operations, database integration, and strict data validation.

## 🚀 Features

* **Full CRUD Operations:** Create, Read, Update, and Delete products seamlessly.
* **Database Integration:** Connected to **Microsoft SQL Server** using Entity Framework Core (Code-First approach).
* **Data Validation:** Implemented robust Data Annotations (`[Required]`, `[Range]`) to ensure data integrity and prevent invalid entries (QA mindset).
* **Interactive Documentation:** Integrated with **Swagger UI** for easy API testing and visualization.
* **Dependency Injection:** Properly structured architecture for injecting database contexts into controllers.

## 🛠️ Tech Stack

* **Language:** C#
* **Framework:** ASP.NET Core Web API (.NET 8/7)
* **ORM:** Entity Framework Core
* **Database:** SQL Server
* **Tools:** Visual Studio, Swagger

## 📡 API Endpoints

| HTTP Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/products` | Retrieve a list of all products. |
| `POST` | `/api/products` | Add a new product to the database. |
| `PUT` | `/api/products/{id}` | Update an existing product by its ID. |
| `DELETE` | `/api/products/{id}` | Remove a product from the database by its ID. |

## 🛡️ Validation Rules
To ensure data quality, the API enforces the following rules upon product creation or update:
1. **Name:** Cannot be null or empty.
2. **Price:** Must be a valid decimal number between `1` and `10,000`. Invalid requests return a `400 Bad Request` with detailed error messages.

---
*Developed as part of an advanced backend engineering roadmap to build scalable web services.*