# Ivy Hello World Application

A simple "Hello World" example demonstrating the Ivy framework capabilities.

## About Ivy

Ivy is a new open-source framework for creating internal web applications using pure C#. It takes inspiration from frameworks such as React and Streamlit, allowing developers to build interactive web applications with familiar C# syntax.

## Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- Ivy CLI (install with `dotnet tool install -g Ivy.Console`)

### Installation

1. Clone this repository
2. Navigate to the project directory
3. Restore packages: `dotnet restore`
4. Run the application: `dotnet run`
5. Open your browser to `http://localhost:5010`

### Features Demonstrated

This Hello World application showcases:

- ✨ Basic Ivy component structure with `ViewBase`
- 🎨 Layout management with cards and spacing
- 🔄 State management with reactive updates
- 📝 User input handling with text inputs
- 🎯 Event handling with button clicks
- 📢 Toast notifications using client services
- 🎨 UI styling with built-in components

### Project Structure

```
Ivy-helloworld/
├── Apps/
│   └── HelloWorldApp.cs    # Main application component
├── Program.cs              # Application entry point
├── GlobalUsings.cs         # Global using statements
├── HelloWorldApp.csproj    # Project file
└── README.md              # This file
```

## About the Framework

This project serves as a practical example for developers interested in:

- Learning the Ivy framework syntax and patterns
- Understanding component-based architecture in C#
- Exploring reactive state management
- Building internal tools and admin interfaces

## Resources

- 🌐 [Ivy Framework](https://ivy.app)
- 📚 [Documentation](https://docs.ivy.app)
- 🎯 [Examples](https://samples.ivy.app)
- 💻 [GitHub Repository](https://github.com/Ivy-Interactive/Ivy-Framework)
- 💬 [Discord Community](https://discord.gg/sSwGzZAYb6)

## Contributing

This is a simple demonstration project. For contributing to the main Ivy framework, please visit the [official repository](https://github.com/Ivy-Interactive/Ivy-Framework).
