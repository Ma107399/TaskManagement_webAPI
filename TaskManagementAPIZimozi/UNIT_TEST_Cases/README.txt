README: How to Run or Understand the Tests

This folder contains test cases (positive and negative) for TaskService class.

The goal is to test the following:
- GetTask(id) method
- GetAllTasks() method

Although this is not implemented in full C# code due to time constraint, the test logic is explained for each method.

To implement in code:
- Use xUnit or NUnit
- Mock database with Moq or InMemory
- Add test files to a new Test Project in solution
- Run with `dotnet test`
