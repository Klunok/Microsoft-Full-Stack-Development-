# Fundamentals of Control Structures

## Introduction to Control Structures

 Control structures like if-else statements and switch cases are vital tools in programming.  
 They allow developers to make decisions within their code.  
 These structures control the flow of execution based on specific conditions, making programs more dynamic and responsive.  
 This reading explores the purpose, syntax, and practical applications of if-else statements and switch cases, helping you understand how to use them effectively.

### The Purpose of If-Else Statements

 An if-else statement is a conditional construct that allows a program to decide whether a specific condition is true or false.  
 When a condition is met (true), the program executes a block of code; if it is not met (false), it executes an alternative block.  
 This structure is essential for scenarios where a binary choice must be made.

 #### Example Use Case

 Imagine writing a program that checks if a user is old enough to access a restricted section of a website.  
 The program can grant or deny access based on the user's age.  
 Access is granted if the user is aged 18 or above; otherwise, access is denied.

#### Syntax of If-Else Statements

 In C#, the syntax for an if-else statement looks like this:
```csharp
if (condition) {
    // Code to execute if the condition is true
} else {
    // Code to execute if the condition is false

}
```

 For example:
```csharp
int age = 18;
if (age >= 18) {
    Console.WriteLine("Access granted.");
} else {
    Console.WriteLine("Access denied.");
}
```

 In this example, the program checks whether the age variable is 18 or older.  
 If it is, the program prints "Access granted." 
 If not, it prints "Access denied." This approach provides a simple way to handle decision-making based on a single condition.

### The Purpose of Switch Cases

 While if-else statements are effective for binary decisions, switch cases provide a more organized and readable way to handle multiple conditions.  
 A switch statement evaluates a variable and executes different actions depending on its value.  
 This is particularly useful when there are several possible outcomes.

#### Example Use Case

 Consider a vending machine program that dispenses different drinks based on the button pressed by the user.  
 Instead of using multiple if-else statements, a switch case can handle each button's action more efficiently.

#### Syntax of Switch Cases

 The syntax for a switch case in C# is as follows:

```csharp
switch (variable) {
    case value1:
        // Code to execute if variable == value1
        break;
    case value2:
        // Code to execute if variable == value2
        break;
    default:
        // Code to execute if variable matches none of the cases
        break;
}
```

For example:
```csharp
string button = "Water";
switch (button) {
    case "Water":
        Console.WriteLine("Dispensing water");
        break;
    case "Soda":
        Console.WriteLine("Dispensing soda");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}
```

 In this example, the program checks the value of the button variable.  
 If it matches "Water," the program prints "Dispensing water." If it matches "Soda," it prints "Dispensing soda." If the value does not match any case, the default case is executed, printing "Invalid option." This structure makes the code more readable and organized compared to using multiple if-else statements.

## Applying If-Else Statements and Switch Cases to Solve Problems

#### Using If-Else Statements for Binary Decisions

 If-else statements are best suited for scenarios where there are only two possible outcomes.  
 For example, a program might check if a student's grade is above or below a passing mark.  
 Here’s how an if-else statement can be used to determine and print whether a student has passed:

```csharp
int grade = 55;
if (grade >= 50) {
    Console.WriteLine("Passed");
} else {
    Console.WriteLine("Failed");
}
```

 In this code, the program evaluates whether the grade variable is 50 or higher.  
 If it is, "Passed" is printed; otherwise, "Failed" is printed.  
 This approach provides a straightforward method for managing decisions that hinge on a single condition.

#### Using Switch Cases for Multiple Conditions

 Switch cases are ideal for handling situations where a variable has several possible values, and each value requires a different response.  
 For example, in a grading system that assigns a letter grade based on a student’s score, a switch case simplifies the decision-making process:

```csharp
int score = 85;
switch (score / 10) {
    case 10:
    case 9:
        Console.WriteLine("A");
        break;
    case 8:
        Console.WriteLine("B");
        break;
    case 7:
        Console.WriteLine("C");
        break;
    default:
        Console.WriteLine("F");
        break;
}
```

 Here, the program evaluates the result of dividing the score by 10.  
 This helps determine which range the score falls into, assigning the appropriate grade from "A" to "F."  
 The use of break statements ensures that once the correct case is matched, no other cases are checked.  
 This method is efficient and clear, making it easier to manage multiple possible outcomes.

# Conclusion

 If-else statements and switch cases are essential tools for controlling program flow based on conditions.  
 If-else statements are ideal for binary decisions, providing a simple way to execute code blocks based on true or false conditions.  
 Switch cases, on the other hand, are powerful for managing multiple potential values, offering clarity and efficiency.  
 By mastering these control structures, developers can enhance their problem-solving abilities and write more effective, readable code.

# Practical Implementation of Control Structures

 This reading covers advanced uses of nested and chained `if-else` statements, complex `switch` statements, and their applications in real-world scenarios.

## Nested If-Else Statements

 Nested `if-else` statements handle complex decisions by placing one `if-else` inside another.  
 This approach is useful when actions depend on multiple conditions.  
 For example, a store may offer discounts based on the total purchase amount and customer membership.  
 The program first checks the purchase amount; if it meets a threshold, it checks membership to apply an additional discount.  
 
 However, overusing nested if-else statements can create difficult-to-maintain "spaghetti code." Use them only when necessary to manage dependent conditions.

## Chained If-Else Statements

 Chained `if-else` statements are better suited for multiple mutually exclusive conditions.  
 They check each condition sequentially, keeping the code readable and organized.  
 For instance, a program that calculates shipping costs based on location first checks if the location is "local," then "domestic," and so on.  
 This method is efficient when conditions are independent.

### Tips to Avoid Spaghetti Code:
 - Simplify conditions into smaller parts.
 - Encapsulate logic in functions.
 - Add comments to explain the purpose of each condition.

## Complex Switch Statements

 Switch statements handle multiple conditions efficiently based on a single variable’s value, making them ideal for cases with many possible outcomes.

### Combining Multiple Cases

When different cases require the same action, such as "Monday" and "Wednesday" sharing a food recommendation, they can be combined in a `switch` statement to avoid redundancy:

```csharp
switch (day) {
    case "Monday":
    case "Wednesday":
        Console.WriteLine("Eat cereal");
        break;
}
```
### Pattern Matching

 Switch statements can use pattern matching to handle inputs that meet specific criteria, such as checking if a string contains "jazz" or "rock" and responding accordingly.

### Default Case

 The default case manages any input that doesn’t match specified cases, ensuring the program handles unexpected values gracefully, such as applying standard shipping when no location matches predefined cases.

## Applications in Real-World Scenarios

 Control structures like `if-else` statements and `switch` cases are crucial for practical programming tasks:

### Inventory Management 

 Use `if-else` to decide whether to reorder a product based on stock levels:

```csharp
if (stockLevel < reorderThreshold) {    
    reorderProduct();
} else {
    maintainCurrentStock();
}
```

### Order Processing 
 Use `switch` to determine the shipping method based on customer location:

```csharp
switch (location) {
    case "local": 
        applyLocalShipping(); 
        break;
    case "domestic": 
        applyDomesticShipping(); 
        break;
    case "international": 
        applyInternationalShipping(); 
        break;
    default: 
        applyStandardShipping(); 
        break;
}
```

### Discount Application
 Use nested `if-else` to apply discounts based on purchase amount and membership:
```csharp
if (totalAmount > 100) {
    if (isMember) applyMemberDiscount();
    else applyRegularDiscount();
} else {
    applyNoDiscount();
}
```

# Conclusion

 Advanced conditional statements, such as nested and chained if-else and complex switch statements, are essential for managing complex programming logic.  
 By applying these structures effectively, developers ensure code remains efficient, readable, and easy to maintain.  

