# YieldSample

This is a C# console application that demonstrates the usage of yield return in C#. The project compares two approaches to filter cars from the year 2025: one using yield return and another without it.

## Prerequisites

- .NET 8.0 SDK or later
- An IDE (Visual Studio, VS Code, or Rider)

## Project Structure

- `Program.cs` - Main entry point of the application
- `YieldSamplePratice.cs` - Contains the implementation of car filtering methods
- `CarDto.cs` - Data transfer object for car information

## How to Run

1. Clone the repository
2. Navigate to the project directory:
   ```bash
   cd YieldSample
   ```
3. Build the project:
   ```bash
   dotnet build
   ```
4. Run the application:
   ```bash
   dotnet run
   ```

## Expected Output

The application will display two lists of cars from the year 2025:
1. Cars filtered using yield return
2. Cars filtered without using yield return

Each car entry will show:
- Make
- Model
- Year

## Project Details

This project is built using:
- .NET 8.0
- C# 12.0 features
- Console application template 