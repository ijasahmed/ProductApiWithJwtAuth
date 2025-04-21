
## 🚀 Features

- 🔐 JWT Token Authentication
- 🔒 Role-Based Authorization (`Admin`, `Manager`, `User`)
- 📦 CRUD operations for products
- 🧱 Repository & Service Layers
- 📊 AutoMapper DTO Mapping
- 🧪 Entity Framework Core with MSSQL
- 📃 Logging with ILogger
- 🔁 Dependency Injection
- 🎯 Follows Clean Code and Naming Conventions

---

## 🧰 Tech Stack

- ASP.NET Core Web API
- Entity Framework Core
- AutoMapper
- JWT Token
- MSSQL Database
- ILogger (Built-in)
- C#

---

## 🗂️ Project Structure

ApiSampleCrud/ │ 
├── Controllers/ │ ├── AuthController.cs │ └── ProductController.cs │ 
├── Data/ │ └── AppDbContext.cs │ 
├── DTOs/ │ ├── LoginDto.cs │ ├── CreateProductDto.cs │ └── ProductDto.cs │ 
├── Models/ │ ├── Product.cs │ └── Login.cs │ 
├── Repositories/ │ ├── IProductRepository.cs │ └── ProductRepository.cs │ 
├── Services/ │ ├── IProductService.cs │ ├── ProductService.cs │ └── JwtService.cs │ 
├── Mapping/ │ └── AutoMapperProfile.cs │ 
├── Program.cs └── appsettings.json


---

## 🔐 Authentication Flow

1. User logs in with username and password using `/api/auth/login`.
2. JWT token is generated and returned.
3. Token must be passed in `Authorization: Bearer <token>` header for protected endpoints.
4. Role-Based Authorization is applied (e.g., only Admin/Manager can delete a product).

---

## 📦 Product Endpoints

| Method | Route              | Description           | Authorization |
|--------|-------------------|-----------------------|---------------|
| GET    | /api/product       | Get all products      | ✅ Required   |
| GET    | /api/product/{id}  | Get product by ID     | ✅ Required   |
| POST   | /api/product       | Add a product         | ✅ Required   |
| PUT    | /api/product/{id}  | Update a product      | ✅ Required   |
| DELETE | /api/product/{id}  | Delete a product      | ✅ Admin/Manager |

---

Clone the repo

```bash
git clone https://github.com/ijasahmed/ProductApiWithJwtAuth.git
cd ProductApiWithJwtAuth
