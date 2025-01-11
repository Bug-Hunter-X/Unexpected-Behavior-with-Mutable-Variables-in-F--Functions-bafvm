# F# Mutable Variable Behavior in Functions

This repository demonstrates a common misconception in F# regarding the behavior of mutable variables passed to functions. In F#, values are typically immutable, but mutable variables can be declared using the `mutable` keyword.  However, passing a mutable variable to a function doesn't create a reference in most cases; instead, the value is copied.

The `bug.fs` file shows the issue where changing a mutable variable after it's passed to a function doesn't affect the function's output. The `bugSolution.fs` file presents a solution using byref parameters or ref cells to achieve the desired behavior.

## How to Run

1.  Ensure you have the .NET SDK installed.
2.  Clone this repository.
3.  Open a terminal or command prompt and navigate to the repository's directory.
4.  Use the `dotnet run` command to compile and run the F# code.