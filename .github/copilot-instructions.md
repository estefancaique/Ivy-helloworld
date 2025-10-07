# Copilot Instructions for Ivy-helloworld

## Overview
This project demonstrates the Ivy framework through a simple "Hello World" application. Ivy is an open-source framework for building internal web applications using pure C#, inspired by React and Streamlit.

## Project Structure
```
Ivy-helloworld/
├── Apps/
│   └── HelloWorldApp.cs    # Main Ivy component
├── Program.cs              # Server configuration and startup
├── GlobalUsings.cs         # Framework namespaces
├── HelloWorldApp.csproj    # .NET project with Ivy package
└── README.md              # Documentation
```

## Key Ivy Patterns
- **Apps**: Inherit from `ViewBase` and use `[App]` attribute with icon and title
- **Build Method**: Override `Build()` to return the component tree using fluent syntax
- **State Management**: Use `UseState<T>()` hook for reactive state variables
- **Layouts**: Chain components with `|` operator (e.g., `Layout.Vertical() | Text.H1("Title")`)
- **Services**: Access framework services via `UseService<T>()` (e.g., `IClientProvider` for toasts)

## Developer Workflow
- **Run**: `dotnet run` then visit `http://localhost:5010`
- **Hot Reload**: Changes automatically reflect in browser during development
- **Components**: Place new apps in `/Apps` folder following the `HelloWorldApp.cs` pattern

## Ivy-Specific Conventions
- Use fluent API style with method chaining
- Leverage built-in components: `Text`, `Button`, `Card`, `Layout`, `Separator`
- Handle events with lambda expressions: `new Button("Click", _ => action())`
- State updates trigger automatic UI re-renders
- Toast notifications via `client.Toast(message, title)`

## Integration Points
- **Server Setup**: `Program.cs` configures Ivy server with hot reload and chrome UI
- **Global Imports**: `GlobalUsings.cs` imports all necessary Ivy namespaces
- **Package Reference**: Single `Ivy` package provides complete framework

## Component Architecture
- Components are classes that extend `ViewBase`
- Use hooks (`UseState`, `UseService`) for reactive functionality  
- Return UI tree from `Build()` method using Layout builders
- Apply styling through fluent methods (`.Width()`, `.Gap()`, `.Padding()`)

## Example Code Pattern
```csharp
[App(icon: Icons.Star, title: "My App")]
public class MyApp : ViewBase
{
    public override object? Build()
    {
        var state = UseState("");
        return Layout.Vertical()
            | Text.H1("Title")
            | state.ToTextInput()
            | new Button("Action", _ => state.Set("new value"));
    }
}
```
