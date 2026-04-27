# Lecture 04: Introduction

## Introduction

> This summary explores the fundamentals of writing simple C# programs, focusing on core concepts such as syntax, variables, control structures, and methods. These elements form the foundation of all C# applications and are essential for writing functional, reusable code.

### Program Structure

A C# program starts with a class definition and a Main method that serves as the program’s entry point. For example:

class Program
```csharp
{

    static void Main(string[] args)

    {
        Console.WriteLine("Hello, World!");
    }
}
```

The `Console.WriteLine()` method outputs text to the console, illustrating basic syntax.

### Variables and Data Types

Variables in C# hold data and are declared with specific types. Examples include:


```csharp
int age = 25;
string name = "John";
var count = 10;
```

The `var` keyword allows for type inference, where the compiler determines the variable's type based on its assigned value.

### Control Structures

Control structures manage the flow of a program:

#### If-Else Statements

Execute code based on conditions:

```csharp
if (age >= 18) 
{
    Console.WriteLine("You're an adult.");
}
else 
{
    Console.WriteLine("You're a minor.");
}
```

#### Loops

Repeat actions, such as printing numbers:

```csharp

for (int i = 0; i < 5; i++) 
{
    Console.WriteLine(i);
}
```

#### Methods

Methods allow for reusable blocks of code. For example, an addition method can take two inputs and return their sum:

```csharp
public static int Add(int a, int b)
{
    return a + b;
}
```

Incorporating methods into classes organizes functionality and enhances code reusability.

### Practical Example: Simple Calculator

A basic calculator program might look like this:

public class Calculator

```csharp
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;
        int result = Add(num1, num2);
        Console.WriteLine("The sum is: " + result);
    }
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
```

This program sums two integers and prints the result to the console.

#### Handling User Input

C# can also handle user input via the Console.ReadLine() method. For example:

```csharp
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");
```

This allows programs to interact with users dynamically.

## Conclusion

You can build simple but effective C# programs, such as calculators and interactive user applications by mastering these core concepts- syntax, variables, control structures, and methods. These basics lay the groundwork for more advanced programming in C#.

# Lecture 05: Object and Classes

## Introduction

> This content explores the fundamental concepts of object-oriented programming (OOP), focusing on how objects, classes, encapsulation, and abstraction provide a structured and maintainable approach to coding in C#. Understanding these concepts is crucial for developing secure and efficient software.

### Objects and Classes in OOP

In OOP, objects and classes serve as the primary building blocks. A class is a blueprint or template that defines a set of shared characteristics and behaviors for a group of entities. For example, in a library system, a book class could define properties like title, author, and ISBN, along with methods such as borrowing and returning. Each book in the library represents an object, an instance of the Book class.

Objects have unique properties and behaviors defined by the class they belong to. The properties (like a book's title) and methods (like the ability to borrow a book) define the state and behavior of these objects. By using classes to organize code, developers can create reusable and scalable solutions.

### Encapsulation: Protecting Internal State

Encapsulation is a core principle of OOP that involves bundling data (attributes) and methods within a class and restricting access to some of its components. This principle protects the internal state of an object by managing how data is accessed and modified. Developers achieve encapsulation by using access modifiers, such as private, protected, and public, to control access levels:

- Private: Restricts access to the class, ensuring that data cannot be altered directly from outside the class.

- Protected: Allows access to the class and its subclasses, enabling inherited classes to use and extend the data and methods.

- Public: Exposes data and methods to any application part, allowing wider access.

For example, in a BankAccount class, sensitive data like the account balance might be protected with a private attribute, while public methods like deposit and withdrawal are provided to interact with the account without directly exposing the internal state.

### Abstraction: Simplifying Complexity

Abstraction in OOP is defining what an object does without specifying how it does it. This principle allows developers to create simplified interfaces and hide the underlying complexity. Abstraction is commonly implemented using abstract classes and interfaces:

- Abstract Classes: Define a common code base with some standard methods that include implementation details and some abstract methods without implementation.

- Interfaces: Define a contract specifying what methods a class must implement without providing details.

For example, a banking application might use an abstract class to handle common functionalities like deposit and withdrawal. The CheckingAccount and SavingsAccount classes can then inherit from this abstract class, implementing specific details for each type of account. This approach allows other application parts to use these methods without understanding their internal workings.

## Conclusion

The principles of objects, classes, encapsulation, and abstraction are essential for mastering OOP in C#. Encapsulation protects the integrity of an object's data, while abstraction simplifies the complexity of code interactions. Together, these principles enable developers to write code that is more secure, maintainable, and easier to understand, paving the way for more efficient and effective software development.

# Lecture 06: Inheritance and Polymorphism

## Introduction

This summary explores two fundamental concepts in Object-Oriented Programming (OOP): inheritance and polymorphism. These principles are essential for creating reusable, efficient, and flexible code in C#.

## Understanding Inheritance

Inheritance allows developers to create a new class, known as a derived class, based on an existing class called the base class. The derived class inherits all the properties and methods of the base class, enabling code reuse and reducing redundancy. For example, a base class Bird could have derived classes like Eagle and Parrot in a software application. Both derived classes inherit common attributes (such as the ability to fly) from the base class while introducing their unique methods and properties.

This concept of inheritance helps establish hierarchical relationships between classes, similar to biological classifications. It allows developers to organize and manage code more effectively by reusing existing code and extending it with new functionality.

#### Key Benefits of Inheritance 

- Code reusability: Derived classes can use the existing code of the base class without rewriting it.

- Extended functionality: Developers can add new methods or modify existing ones in the derived classes without affecting the base class.

## Exploring Polymorphism

Polymorphism allows a single method to perform different tasks depending on the object it is acting upon. This flexibility is achieved through method overriding, where a derived class implements a method already defined in the base class.

For example, consider a base-class coffee maker with methods of water and beans. The derived classes drip and superautomatic can override these methods to suit their needs. The drip class may use the methods implemented in the base class, while the superautomatic class might override the beans method to include functionality for grinding beans. This allows each class to perform its tasks in a way that best fits its purpose.

By Using Polymorphism, Developers Can

- Extend the base class by adding methods and attributes.

- Override methods to create specific behaviors for different objects.

- Promote code reuse without sacrificing flexibility.

## Conclusion

Inheritance and polymorphism are foundational principles in OOP that allow developers to build flexible and maintainable applications. By using inheritance, developers can reuse and extend existing code, while polymorphism enables them to define unique behaviors for different objects, leading to more adaptable and organized software development.

# Lecture 07: Practical Implementation of Inherutance and Polyphomrphism

## Introduction

> This reading provides a concise guide to implementing inheritance and polymorphism in C# programming. It focuses on creating base and derived classes and applying method overriding and interfaces.

### Inheritance in C#

- Define a base class
    - Use an access modifier (public, private, protected).
    - Use the class keyword followed by the class name.
    - Define properties to hold data and methods to define actions.

Example:

```csharp
public class Pool
{
    public int chlorineLevel;
    public int waterLevel;
    public Pool(int chlorine, int water)
    {
        chlorineLevel = chlorine;
        waterLevel = water;
    }
    public void PoolInfo()
    {
        Console.WriteLine($"Pool: {chlorineLevel}, {waterLevel}");
    }
}
```

- Create a derived class 
    - Declare like a base class but add a colon (:) followed by the base class name.
    - The derived class inherits properties and methods from the base class.

Example:

```csharp
public class Spa : Pool

{
    public int heatLevel;
    public Spa(int chlorine, int water, int heat)
        : base(chlorine, water)
    {
        heatLevel = heat;
    }
    public void SpaInfo()
    {
        Console.WriteLine($"Spa: {chlorineLevel}, {waterLevel}, {heatLevel}");
    }
}
```

### Polymorphism in C#

- Method Overriding
    - Use the virtual keyword in the base class to declare methods that can be overridden.

- In the derived class, use the override keyword to provide a specific implementation.

Example:

```csharp
public class Instrument
{
    public virtual void Play()
    {
        Console.WriteLine("Playing an instrument");
    }
}


public class Piano : Instrument
{
    public override void Play()
    {
        Console.WriteLine("The piano is playing");
    }
}
```

- Using Interfaces
    - Define an interface with method signatures that derived classes must implement.
    - Implement the interface in derived classes.

Example:

public interface IPlayable

```csharp
{
    void Play();
}


public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("The guitar is playing");
    }
}
```

## Conclusion

Use inheritance to create reusable base classes and extend their functionality with derived classes. Use polymorphism through method overriding and interfaces to allow flexibility in method implementations across different classes.  