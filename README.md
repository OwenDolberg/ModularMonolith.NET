# ModularMonolith.NET

Welcome to **ModularMonolith.NET**, a clean and modular .NET template designed for building scalable monoliths with support for multiple frontends. This project leverages **Clean Architecture** and **Domain-Driven Design (DDD)** principles to provide a robust starting point for a Web API, Blazor (WASM and Server), and MAUI applications—all within a single, well-organized codebase.

---

## Why This Template?

Monoliths can be elegant and efficient when done right. This template offers:
- **Modularity**: Features are isolated for easy maintenance and future extraction.
- **Clean Separation**: Business logic stays pure, with infrastructure neatly separated.
- **Multi-Frontend Support**: Build for API, Blazor, and MAUI from one repo.
- **Scalability**: Transition to microservices when needed with minimal rework.

## Inspired By

This template is shaped by modern .NET patterns and practices, with inspiration from:

- **Clean Architecture** and **Domain-Driven Design (DDD)** – foundational concepts that guide the modular structure of `ModularMonolith.NET`. (Think books by Robert C. Martin, Eric Evans, and Vaughn Vernon.)
- **YouTube Creators**:
    - [Amichai Mantinband](https://www.youtube.com/@amantinband) – his practical breakdowns of .NET architecture and design patterns were a huge influence.
    - [Nick Chapsas](https://www.youtube.com/@nickchapsas) – his tutorials on dependency injection, modular design, and ASP.NET Core helped shape this approach.
    - [Milan Jovanović](https://www.youtube.com/@MilanJovanovicTech) – his insights on software design, Clean Architecture, and modular monoliths were invaluable in refining this template.

___

## Key Features

- **Core/Presentation Split**: `src/core` holds domain logic; `src/presentation` drives frontends.
- **Hybrid Project Layout**: Separate projects for shared layers (e.g., `Domain`, `Application`), single projects for backend-only features.
- **Frontend Flexibility**: Supports Web API, Blazor WASM, Blazor Server, and MAUI.
- **Dependency Injection**: Feature-specific DI setup via `/DependencyInjection/` folders.
- **Open Source**: MIT-licensed for maximum freedom.

---

## Structure Overview

Here’s how the repo is organized:
```
ModularMonolith.Net.sln/
├── src/
│   ├── core/
│   │   ├── ModularMonolith.Net.Common.[Domain/Application/Infrastructure]/  # Shared logic
│   │   ├── ModularMonolith.Net.FeatureOne.[Domain/Application/Infrastructure]/  # Multi-layer feature
│   │   ├── ModularMonolith.Net.FeatureTwo/  # Backend-only feature
│   ├── presentation/
│   │   ├── ModularMonolith.Net.Api/  # RESTful API
│   │   ├── ModularMonolith.Net.BlazorWasm/  # Blazor WebAssembly
│   │   ├── ModularMonolith.Net.BlazorWebApp/  # Blazor Server
│   │   └── ModularMonolith.Net.Maui/  # Cross-platform MAUI app
```
- **`Common`**: Shared domain, application, and infrastructure code.
- **`FeatureOne`**: Example of a feature with separated layers allowing multiple projects to reference the different layers as needed (e.g., just domain for multi-frontend use).
- **`FeatureTwo`**: Example of a simpler, backend-only feature.

## How to Use

Get started in minutes:

1. **Clone the Repo**:
   ```bash
   git clone https://github.com/OwenDolberg/ModularMonolith.NET.git
   ```

2. Open in Visual Studio (or your IDE of choice).
3. Run the API:
- Set ModularMonolith.Net.Api as the startup project.
- Press F5 or run dotnet run.
4. Customize It:
- Rename FeatureOne and FeatureTwo to fit your domain.
- Add new features by duplicating the structure.

---

This project is a personal endeavor, built from scratch with inspiration from public resources and my own experimentation. It’s all about sharing what I’ve learned along the way!