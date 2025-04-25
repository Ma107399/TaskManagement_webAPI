# TaskManagementAPI

This is a simple ASP.NET Core Web API project named `TaskManagementAPI` built for skills demonstration purposes. 
It contains the backend logic for managing tasks using a RESTful interface and includes JWT-based authentication and I hope you will appreciate my efforts.

---

##  Project Structure

The project is divided into two main tasks:

###  Task 1 – Web API Setup
- Created a basic **ASP.NET Core Web API** using Entity Framework Core and SQL Server.
- Includes **3 model classes**:
  - `User`
  - `Task`
  - `TaskCategory`
- Models are located inside the `Models` folder.

###  Task 2 – JWT Authentication and Controllers
- Integrated **JWT (JSON Web Token)** authentication.
- Configured `appsettings.json` with secret key, issuer, and audience.
- Added:
  - A **Login** endpoint to generate JWT tokens.
  - A **TaskController** for basic CRUD operations with `[Authorize]` protection.

---

## 🛠️ Technologies Used
- ASP.NET Core 6.0/7.0 Web API
- Entity Framework Core
- SQL Server
- JWT Bearer Authentication
- Swagger (OpenAPI) for testing API endpoints

---

##  How to Run the Project Locally

### Prerequisites
Make sure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or 7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

---

### Steps to Run

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   cd your-repo-name
2.Set up the Database
Update the appsettings.json file with your local SQL Server connection string well you dont have to do that all manually I have done that for you just clone my repo.
3. Run migrations to create db schemas let EF do the job for you .
4.To test the API you can use swagger UI or POSTMAN I have used swagger because It was inbuilt in .Net since i have time boundation.
5. dont forget to download the nuget pacakages fro JWT Bearer and EF CORE for sql as well nothing would work without them.

Below is the Folder Strcture
TaskManagementAPI/
├── Controllers/
│   └── TaskController.cs
├── Models/
│   ├── User.cs
│   ├── Task.cs
│   └── TaskCategory.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Program.cs
├── appsettings.json
└── README.md
