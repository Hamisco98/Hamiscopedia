# 🧩 Hamiscopedia — Demos

Welcome to the **Hamiscopedia Demos** section — a collection of practical, hands-on projects built to demonstrate how different technologies, architectures, and design patterns come together in real applications.

Each demo is a **mini project** — larger than a snippet but smaller than a full-scale system — focused on showing real-world implementation and integration.

> “Learn by building — because experience is the best teacher.” — *Hemisco*

---

## 💡 What Are Demos?

**Demos** are functional, multi-file examples designed to teach through doing.  
They explore how to build specific features, integrate systems, or apply clean architecture principles in working code.

Examples include:
- Web APIs built with **ASP.NET Core**  
- Authentication and JWT setups  
- Database CRUD operations with EF Core  
- Logging, error handling, and middleware pipelines  
- Integration between frontend and backend apps  

Each demo connects theoretical topics with real, runnable projects — ideal for learning by experimentation.

---

## 🧠 Purpose

The **Demos** section bridges the gap between theory and practice:  
- Turning **concepts** into **working prototypes**.  
- Showcasing **best practices** in architecture and organization.  
- Demonstrating **scalable patterns** for real projects.  
- Providing reference implementations for Hamiscopedia posts and lessons.

---

## 🗂️ Structure Overview

```
/demos/
  /api-clean-architecture/
    README.md
    src/
    tests/
  /jwt-authentication/
  /file-upload-service/
  /dockerized-microservice/
```

### 🔹 Folder Convention

| Folder | Description |
|---------|-------------|
| **demo-folder** | The demo project name written in lowercase and hyphen-separated (e.g., `api-clean-architecture`) |
| **src/** | Source code for the main application |
| **tests/** | Unit or integration tests |
| **README.md** | Description, setup guide, and purpose of the demo |

---

## 📘 Demo README Template

Each demo includes a README file structured like this:

```markdown
# API Clean Architecture Demo

**Tech Stack:** ASP.NET Core, EF Core, PostgreSQL  
**Focus:** Clean Architecture & Domain-Driven Design Principles  
**Created:** 2025-10-26  

---

### 🧩 Overview
This demo shows how to structure a .NET API using Clean Architecture, separating concerns into layers like Domain, Application, Infrastructure, and Presentation.

### ⚙️ Setup
1. Clone this folder.  
2. Run `dotnet restore && dotnet run`.  
3. API will start on `https://localhost:5001`.

### 🧠 Concepts Covered
- Layered structure & separation of concerns.  
- Dependency Injection & Inversion of Control.  
- Entity Framework Core integration.  
- Unit Testing & Validation.

### 📦 Output
Ready-to-use REST API following clean architecture standards.
```

---

## 📚 Relation to Hamiscopedia

Demos complement other parts of Hamiscopedia:

| Section | Purpose |
|----------|----------|
| **Posts** | Explain the theory and logic. |
| **Snippets** | Show the core idea in a few lines of code. |
| **Problem-Solving** | Strengthen logic through challenges. |
| **Demos** | Combine everything into a runnable mini project. |

Together, they form a complete learning path — from understanding a concept to seeing it applied in a real-world scenario.

---

## 📜 License

All demo projects are released under the **MIT License**.  
You’re free to use, modify, and learn from them.  
Attribution to **Hamiscopedia** is appreciated when sharing publicly.

---

**Created and maintained by [Hemisco](https://github.com/hemisco)**  
> *“Learn faster. Build smarter.”*
