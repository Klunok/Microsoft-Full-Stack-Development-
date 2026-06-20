# Lecture 01: Foundations of .NET Development and VS Code Integration

> Module focus: understand what .NET is, how Visual Studio Code fits into the development workflow, and how a basic .NET project is created and organized.

## Course Context

This course introduces programming with C# through practical work with .NET projects in Visual Studio Code. It starts with environment setup and project structure, then moves into programming fundamentals, object-oriented programming, asynchronous programming, debugging, and Microsoft Copilot-assisted development.

### Course Learning Objectives

By the end of the course, you should be able to:

- Describe the setup, structure, and configuration of .NET projects in Visual Studio Code.
- Implement C# fundamentals, including variables, control structures, loops, and methods.
- Apply object-oriented programming principles such as classes, inheritance, and polymorphism.
- Develop asynchronous programs and use debugging techniques to improve reliability.
- Use Microsoft Copilot to write, debug, and optimize C# code.

### Course Modules

| Module | Focus | Assessment |
| --- | --- | --- |
| 1. Foundations of .NET Development and Visual Studio Code Integration | .NET environment, VS Code setup, project creation, file organization | Graded quiz |
| 2. Applying Programming Foundations | Variables, data types, control structures, loops, methods, pseudocode, debugging | Graded quiz |
| 3. Mastering Object-Oriented Programming in C# | Objects, classes, inheritance, polymorphism, design patterns | Graded quiz |
| 4. Asynchronous Programming in C# | Async concepts, `async`, `await`, debugging asynchronous code | Graded quiz |
| 5. Leveraging Microsoft Copilot for Efficient C# Coding and Debugging | Copilot-assisted coding, debugging, optimization, coding challenges | Final project |

---

## Lecture Roadmap

| Section | Topic | Outcome |
| --- | --- | --- |
| 1 | What .NET is | Understand the purpose of the .NET platform. |
| 2 | VS Code integration | Understand how VS Code supports C# development. |
| 3 | Environment setup | Know which tools are required. |
| 4 | Project creation | Create and run a basic .NET console app. |
| 5 | Project structure | Identify the main files and folders in a .NET project. |

---

## Learning Objectives

By the end of this lecture, you should be able to:

- Describe the purpose of a .NET environment.
- Explain the role of Visual Studio Code in .NET projects.
- Set up a basic .NET development environment.
- Outline the steps for creating a new .NET project.
- Explain project structure and file organization in .NET.

---

## 1. What Is .NET?

.NET is a software development platform created by Microsoft. It provides the tools, libraries, and runtime needed to build different types of applications.

Common application types include:

- Console applications
- Web applications
- Desktop applications
- Mobile applications
- Cloud-based services
- APIs

### Why Developers Use .NET

| Benefit | Explanation |
| --- | --- |
| Cross-platform | Runs on Windows, macOS, and Linux. |
| C# support | Works especially well with C#, a modern object-oriented language. |
| Rich libraries | Includes built-in tools for common development tasks. |
| Strong tooling | Works with editors, debuggers, package managers, and testing tools. |
| Scalable ecosystem | Supports small apps, enterprise systems, cloud services, and APIs. |

### Key Idea

> .NET gives developers a complete environment for writing, building, running, and maintaining applications.

---

## 2. The Role of Visual Studio Code

Visual Studio Code, often called VS Code, is a lightweight code editor. It can be configured for .NET development with extensions, terminal commands, debugging tools, and project navigation.

VS Code helps developers:

- Write and edit C# code.
- Navigate project files.
- Use the integrated terminal.
- Run .NET CLI commands.
- Debug applications.
- Install extensions for C# development.

### Recommended VS Code Extensions

| Extension | Purpose |
| --- | --- |
| C# Dev Kit | Adds C# project support, debugging, and IntelliSense. |
| C# | Provides language support for C# files. |
| .NET Install Tool | Helps manage .NET SDK installation for VS Code tools. |

---

## 3. Setting Up the .NET Development Environment

Before creating a .NET project, the system should have the .NET SDK installed.

### Required Tools

| Tool | Why It Is Needed |
| --- | --- |
| .NET SDK | Creates, builds, and runs .NET applications. |
| Visual Studio Code | Provides the code editor and integrated terminal. |
| C# extension or C# Dev Kit | Adds language support and debugging features. |
| Terminal | Runs .NET CLI commands. |

### Check the Installed .NET Version

Run this command in the terminal:

```bash
dotnet --version
```

If the command returns a version number, the .NET SDK is installed.

Example:

```text
8.0.100
```

---

## 4. Creating a New .NET Project

The .NET CLI is used to create projects from templates.

### Create a Console Application

```bash
dotnet new console -n MyFirstApp
```

Command breakdown:

| Part | Meaning |
| --- | --- |
| `dotnet` | Starts the .NET CLI. |
| `new` | Creates a new project. |
| `console` | Uses the console application template. |
| `-n MyFirstApp` | Names the project `MyFirstApp`. |

### Move Into the Project Folder

```bash
cd MyFirstApp
```

### Run the Application

```bash
dotnet run
```

Expected output:

```text
Hello, World!
```

---

## 5. Basic Project Structure

After creating a console project, the folder usually contains these files:

```text
MyFirstApp/
  MyFirstApp.csproj
  Program.cs
  obj/
  bin/
```

### Main Files and Folders

| Item | Description |
| --- | --- |
| `Program.cs` | Contains the main C# code for the application. |
| `MyFirstApp.csproj` | Stores project configuration and dependencies. |
| `bin/` | Contains compiled output after building the project. |
| `obj/` | Contains temporary build files used by .NET. |

### Example `Program.cs`

```csharp
Console.WriteLine("Hello, World!");
```

This line prints text to the console.

---

## 6. Common .NET CLI Commands

| Command | Purpose |
| --- | --- |
| `dotnet --version` | Shows the installed SDK version. |
| `dotnet new console` | Creates a new console application. |
| `dotnet run` | Builds and runs the project. |
| `dotnet build` | Compiles the project. |
| `dotnet clean` | Removes build output. |
| `dotnet restore` | Restores project dependencies. |

---

## Key Terms

| Term | Meaning |
| --- | --- |
| SDK | A software development kit that includes tools needed to build applications. |
| Runtime | The environment that runs compiled applications. |
| CLI | A command-line interface used to execute commands in the terminal. |
| Project file | A `.csproj` file that stores project settings. |
| Dependency | External code or package used by a project. |

---

## Practice Task

Create and run a basic .NET console application.

1. Open the terminal.
2. Run `dotnet --version`.
3. Create a new console app with `dotnet new console -n PracticeApp`.
4. Move into the folder with `cd PracticeApp`.
5. Run the app with `dotnet run`.
6. Open `Program.cs` and change the printed message.
7. Run the app again.

---

## Check Your Understanding

Answer these questions after the lecture:

1. What is the purpose of the .NET SDK?
2. Why is Visual Studio Code useful for .NET development?
3. Which command creates a new console project?
4. What does the `.csproj` file store?
5. What is the difference between `dotnet build` and `dotnet run`?

---

## Summary

In this lecture, the .NET environment, Visual Studio Code integration, and basic project structure were introduced. The most important workflow is:

```text
Install tools -> Create project -> Write code -> Build -> Run
```

This foundation will be used throughout the C# programming course.
