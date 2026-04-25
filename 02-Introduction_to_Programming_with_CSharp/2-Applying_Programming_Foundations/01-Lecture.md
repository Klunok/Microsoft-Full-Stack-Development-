# Applying Programming Foundations in C#

> Module focus: review core programming concepts and apply them in simple C# programs using variables, data types, control flow, loops, methods, pseudocode, and debugging.

## Module Overview

This module connects general programming logic with practical C# syntax. The goal is to move from understanding basic concepts to writing small programs that solve clear problems.

| Topic | Why It Matters |
| --- | --- |
| Variables and data types | Store and organize information in a program. |
| Control structures | Make decisions based on conditions. |
| Loops | Repeat tasks without duplicating code. |
| Methods | Split code into reusable blocks. |
| Pseudocode | Plan logic before writing code. |
| Debugging | Find and fix problems in a program. |

---

## Learning Objectives

By the end of this lecture, you should be able to:

- Review key programming concepts from the first course.
- Use variables and data types in C#.
- Write conditional logic with `if`, `else if`, and `else`.
- Use loops to repeat instructions.
- Create and call simple methods.
- Write pseudocode before implementing a solution.
- Apply basic debugging techniques.

---

## 1. Programming Foundations Review

Programming is the process of giving precise instructions to a computer. A program usually follows a logical flow:

```text
Input -> Process -> Output
```

Example:

| Step | Meaning | Example |
| --- | --- | --- |
| Input | Data received by the program | User enters a number. |
| Process | Logic applied to the data | Program checks if the number is positive. |
| Output | Result shown to the user | Program prints a message. |

### Key Idea

> Strong programming starts with clear thinking. Code is easier to write when the problem is already broken into logical steps.

---

## 2. Variables and Data Types

A variable stores a value that a program can use later.

### Common C# Data Types

| Type | Stores | Example |
| --- | --- | --- |
| `int` | Whole numbers | `25` |
| `double` | Decimal numbers | `19.99` |
| `char` | A single character | `'A'` |
| `string` | Text | `"Hello"` |
| `bool` | `true` or `false` values | `true` |

### Example

```csharp
string studentName = "Alex";
int score = 92;
bool passed = true;

Console.WriteLine(studentName);
Console.WriteLine(score);
Console.WriteLine(passed);
```

### Naming Guidelines

- Use descriptive names.
- Start local variable names with a lowercase letter.
- Use camelCase for multi-word names.
- Avoid unclear names like `x`, `data`, or `thing` unless the context is obvious.

Good examples:

```csharp
int totalScore = 95;
string userName = "Jordan";
bool isLoggedIn = false;
```

---

## 3. Control Structures

Control structures let a program make decisions.

### `if`, `else if`, and `else`

```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("Excellent");
}
else if (score >= 70)
{
    Console.WriteLine("Passed");
}
else
{
    Console.WriteLine("Try again");
}
```

### Comparison Operators

| Operator | Meaning |
| --- | --- |
| `==` | Equal to |
| `!=` | Not equal to |
| `>` | Greater than |
| `<` | Less than |
| `>=` | Greater than or equal to |
| `<=` | Less than or equal to |

### Logical Operators

| Operator | Meaning | Example |
| --- | --- | --- |
| `&&` | AND | Both conditions must be true. |
| `||` | OR | At least one condition must be true. |
| `!` | NOT | Reverses a Boolean value. |

Example:

```csharp
int age = 20;
bool hasTicket = true;

if (age >= 18 && hasTicket)
{
    Console.WriteLine("Entry allowed");
}
```

---

## 4. Loops

Loops repeat instructions while a condition is true or for a specific number of times.

### `for` Loop

Use a `for` loop when the number of repetitions is known.

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

### `while` Loop

Use a `while` loop when repetition depends on a condition.

```csharp
int count = 1;

while (count <= 5)
{
    Console.WriteLine(count);
    count++;
}
```

### Loop Comparison

| Loop | Best Used When |
| --- | --- |
| `for` | You know how many times the code should run. |
| `while` | The loop depends on a condition that may change. |
| `do while` | The code must run at least once before checking the condition. |

---

## 5. Methods

A method is a reusable block of code that performs a specific task.

### Basic Method Example

```csharp
static void GreetUser(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

GreetUser("Alex");
```

### Method With a Return Value

```csharp
static int AddNumbers(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

int total = AddNumbers(5, 7);
Console.WriteLine(total);
```

### Why Methods Are Useful

- They make code easier to read.
- They reduce repeated code.
- They make programs easier to test.
- They separate one task from another.

---

## 6. Pseudocode

Pseudocode is a plain-language plan for a program. It helps organize logic before writing real code.

### Example Problem

Check whether a student passed based on a score.

```text
Start
Set score
If score is greater than or equal to 70
    Display "Passed"
Otherwise
    Display "Failed"
End
```

### C# Version

```csharp
int score = 75;

if (score >= 70)
{
    Console.WriteLine("Passed");
}
else
{
    Console.WriteLine("Failed");
}
```

---

## 7. Basic Debugging Techniques

Debugging is the process of finding and fixing errors in a program.

### Common Error Types

| Error Type | Meaning | Example |
| --- | --- | --- |
| Syntax error | The code breaks language rules. | Missing semicolon. |
| Runtime error | The program fails while running. | Dividing by zero. |
| Logic error | The program runs but gives the wrong result. | Incorrect condition. |

### Useful Debugging Habits

- Read error messages carefully.
- Check variable values.
- Use `Console.WriteLine()` to inspect program flow.
- Test one small part of the program at a time.
- Use breakpoints in VS Code when needed.

### Debugging Example

```csharp
int firstNumber = 10;
int secondNumber = 5;

Console.WriteLine($"First: {firstNumber}");
Console.WriteLine($"Second: {secondNumber}");

int result = firstNumber + secondNumber;
Console.WriteLine($"Result: {result}");
```

---

## Integrated Example

This example combines variables, conditions, loops, and methods.

```csharp
static string GetGradeMessage(int score)
{
    if (score >= 90)
    {
        return "Excellent";
    }
    else if (score >= 70)
    {
        return "Passed";
    }
    else
    {
        return "Needs improvement";
    }
}

int[] scores = { 95, 82, 68 };

for (int i = 0; i < scores.Length; i++)
{
    string message = GetGradeMessage(scores[i]);
    Console.WriteLine($"Score: {scores[i]} - {message}");
}
```

---

## Practice Task

Create a small C# console program that evaluates student scores.

Requirements:

1. Create a variable for a student name.
2. Create a variable for a score.
3. Use an `if` statement to check whether the student passed.
4. Create a method that returns a message based on the score.
5. Print the final result to the console.

Starter idea:

```text
Student: Maya
Score: 84
Result: Passed
```

---

## Check Your Understanding

Answer these questions after the lecture:

1. What is the difference between an `int` and a `double`?
2. When should you use an `if` statement?
3. What is the difference between a `for` loop and a `while` loop?
4. Why are methods useful?
5. How can pseudocode help before writing C# code?
6. What is one way to debug a logic error?

---

## Summary

This lecture reviewed the core building blocks of programming and showed how they appear in C#:

```text
Variables -> Conditions -> Loops -> Methods -> Debugging
```

These foundations are used in almost every C# program, from small console applications to larger full-stack systems.
