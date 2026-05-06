# Lecture 04: Setting Up the Development Environment

## Introduction

This guide walks you through setting up a development environment to create Blazor applications using Visual Studio Code and.NET SDK. By the end of these steps, you’ll have everything you need to start building interactive web applications with Blazor.

## Steps

1) Install Visual Studio Code and.NET SDK

- Download Visual Studio Code: Go to [code.visualstudio.com](http://code.visualstudio.com/) and install it.
- Download.NET SDK: Go to [dotnet.microsoft.com/download](http://dotnet.microsoft.com/download) and install the latest version.

2) Add C# Extension to Visual Studio Code

- Open Visual Studio Code.
- Select the Extensions icon on the left sidebar.
- In the search bar, type “C#,” find the C# extension by Microsoft, and click Install.

3) Create a New Blazor Project

- Open Visual Studio Code and select Terminal > New Terminal from the top menu.
- In the terminal, enter the command: `dotnet new blazorwasm -o MyBlazorApp`.
	- This command creates a new Blazor WebAssembly project in a folder called *MyBlazorApp*.

4) Open and Explore the Project Structure

- In Visual Studio Code, select File > Open Folder and navigate to *MyBlazorApp* to open it.
- Familiarize yourself with the structure:
	- Pages: Contains.razor files, which are the main components of your app.
		- wwwroot: Stores static files like images, CSS, and JavaScript.
		- Program.cs: Configures services and middleware to start the app.

5) Restore Project Dependencies

- In the terminal, type `dotnet restore` to install any necessary dependencies for the project.

6) Verify.NET SDK Installation

- In the terminal, enter `dotnet --version`. You should see the installed.NET SDK version displayed, confirming the setup.

## Conclusion

With your Blazor development environment, you can start creating and running Blazor applications in Visual Studio Code. This environment allows you to build interactive, C #- -based web apps, leveraging the power of.NET for robust and scalable development. Enjoy coding with Blazor!
