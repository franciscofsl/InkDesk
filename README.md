# InkDesk

> ⚠️ **Warning**:  
> **InkDesk** is a **demo application** created exclusively for developing and testing the **Raftel** framework.  
> It is **not intended for production use**. The purpose of this project is to validate features, experiment with architectural patterns, and serve as a live reference for Raftel-based applications.

**InkDesk** is a demo application for developing and testing the **Raftel** framework.  
It provides a practical environment to validate features, experiment with architectural patterns, and serve as a reference implementation for projects built using Raftel.

## 🎯 Project Goals

- Serve as a real-world playground for applying and testing Raftel's architecture and features.
- Validate development workflows, such as local package generation and multi-repository integration.
- Demonstrate how to build scalable and maintainable applications based on the Raftel framework.
- Offer a starting point for future Raftel-based solutions.

## ✨ Features

- **Real application prototype**: not just theoretical — InkDesk exercises Raftel in practical scenarios.
- **Local NuGet packages integration**: Raftel is referenced via generated `.nupkg` files for seamless multi-repo development.
- **Quick setup for development**: with local Docker environments and continuous integration support.
- **Best practices applied**: clean architecture, TDD, Object Calisthenics, and more — all demonstrated in a live system.

## ⚙️ Requirements

- [.NET SDK 9.0 or higher](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/) (optional, but recommended for a full development experience)

## 📦 Cloning Instructions

Since InkDesk and Raftel live in **separate repositories**, to develop locally without issues, you must clone them following this structure:

```bash
/YourWorkingDirectory
│
├── InkDesk
│   └── (This repository)
│
└── Raftel
    └── (Raftel repository)
```

**Important:**  
- Both `InkDesk` and `Raftel` folders must be **siblings** at the same directory level.
- The solution expects **Raftel** to be available relative to InkDesk for local development using project references in `Debug` mode.

If you don't respect this structure, the build may fail due to missing project references.

## 📚 How Local NuGet Packages Work

InkDesk uses **Raftel** in two ways:

- In **Debug** mode: Raftel is referenced directly as project references.
- In **Release** mode: Raftel is consumed as **local NuGet packages** generated during the build process.

**How it works:**
- When compiling InkDesk in `Release`, it automatically **packs** the Raftel solution into `.nupkg` files.
- These packages are stored in the `local-packages/` folder inside InkDesk.
- A `nuget.config` file ensures that the `local-packages` folder is used as a valid source when restoring dependencies.

**In short:**  
You work with project references during development, and InkDesk switches to local NuGets automatically when building for production or CI/CD.  
This provides the best of both worlds: **fast iteration** locally and **reliable builds** remotely.

## 🚀 Quick Start

After cloning both **InkDesk** and **Raftel** following the structure described above:

1. Install the required workloads and tools:
   ```bash
   dotnet workload install aspire
   dotnet tool install -g dotnet-reportgenerator-globaltool
   ```

2. Start the development dependencies:
   ```bash
   docker compose -f ./docker-compose.yml up -d
   ```

3. Run the application in development mode:
   ```bash
   dotnet run --project InkDesk.Api
   ```

**Note:**  
- Make sure Docker is running before starting the containers.
- In `Debug` mode, the solution uses direct project references to Raftel.
- In `Release` mode, the solution builds using locally generated NuGet packages.

---
