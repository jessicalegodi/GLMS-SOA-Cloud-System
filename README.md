# GLMS.MVC
# GLMS SOA Cloud-Native System
 Overview

This project is a Service-Oriented Architecture (SOA) system built using ASP.NET Core. It consists of an MVC frontend, a Web API backend, and a SQL Server database containerised using Docker.

---

Architecture

* MVC Frontend (Presentation Layer)
* Web API Backend (Business Logic Layer)
* SQL Server Database (Data Layer)
* Docker Compose for orchestration
* xUnit Integration Tests

---

 Technologies Used

* ASP.NET Core MVC
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* Docker & Docker Compose
* xUnit Testing
* Swagger / OpenAPI

---

 How to Run the Project

1. Clone Repository

```bash
git clone https://github.com/jesiccalegodi/GLMS-SOA-Project.git
```

### 2. Run with Docker

```bash
docker-compose up --build
```

### 3. Access Applications

MVC Frontend: http://localhost:5000
API: http://localhost:5001
Swagger: http://localhost:5001/swagger
  

## API Endpoints

* GET /api/contracts
* POST /api/contracts
* PATCH /api/contracts/{id}/status

---

## Testing

Integration tests were implemented using xUnit. These tests validate API responses automatically.

Run tests:

```bash
dotnet test
```

---

## Features

* Fully decoupled architecture (MVC + API)
* RESTful API design
* Docker containerisation
* Automated integration testing
* Swagger API documentation

---

## Author

Student Project – Academic Submission
