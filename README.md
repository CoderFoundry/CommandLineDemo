# dotet run app.cs Demo

**dotnet run app.cs Demo** demonstrates the use of C# scripts and command-line interaction made possible by the introduction of [dotnet run app.cs](https://devblogs.microsoft.com/dotnet/announcing-dotnet-run-app/). This repository serves as an educational and reference resource for running `.cs` files directly from the command line—no explicit `Main` method or project file required.

> **Note:** You must be running [.NET 10 Preview 4](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) or later to use this feature.

---

## 📺 Demo Video

Watch a complete walkthrough of dotnet run app.cs Demo on YouTube:  
[![Watch on YouTube](https://img.shields.io/badge/Watch-YouTube-red?logo=youtube)](https://www.youtube.com/watch?v=RqdboCFIqp0)



---

## Features

- **dotnet run app.cs:** Run `.cs` files as scripts directly from the command line, leveraging C#.
- **Command-Line Demos:** Sample files (`hello.cs`, `CodingChallenge.cs`) demonstrates how C# handles string manipulation (reversing a string, case conversion), input handling (args.FirstOrDefault()), LINQ usage (Reverse()), array and string  conversion, conditional logic, and console output—all common features for basic C# scripting and utility programs.
 
- **Mock Data & JSON Processing:** MockData.cs  C# script uses the # :package Bogus directive to download the Bogus library at execution, generates a specified number of fake people with random names, emails, and addresses, and saves them as a JSON file named people.json.

- **Mock Server & JSON Processing:** MockServer.cs  This C# script sets up a minimal web API using ASP.NET Core, serves OpenAPI docs, and provides a /people endpoint that returns fake people data from people.json with optional search filtering by full name.
- **No Project File Required:** Scripts run standalone, showcasing the new simplified development workflow.

---

## Prerequisites

- **.NET 10 Preview 4** or later must be installed.  
  [Download the latest preview here](https://dotnet.microsoft.com/en-us/download/dotnet/10.0).

- Add `.NET 10` preview to your PATH if you have multiple SDKs installed.

---

## Getting Started

1. **Clone the Repository**
    - Open a terminal and run:
      ```bash
      git clone https://github.com/CoderFoundry/dotnetRunDemo.git
      cd dotnetRunDemo
      ```

2. **Recommended: Install VS Code & C# Dev Kit Extension**
    - [Download Visual Studio Code](https://code.visualstudio.com/)
    - Open the repo folder in VS Code.
    - Install the **C# Dev Kit** extension for best language support and IntelliSense:  
      [C# Dev Kit in the VS Code Marketplace](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)

3. **Run a Script**
    - To run a demo script (for example, `hello.cs`), use:
      ```bash
      dotnet run hello.cs
      ```
    - To run any other script in the repo (for example):
      ```bash
      dotnet run CodingChallenge.cs
      dotnet run MockServer.cs
      ```
    - > **Note:** You do **not** need a project file or solution file to run these scripts.  
      Just pass the script filename as an argument to `dotnet run`.

