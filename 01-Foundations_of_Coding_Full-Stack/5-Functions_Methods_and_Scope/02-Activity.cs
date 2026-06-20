
// Problem 1: Creating a Function for Circle Area Calculation

using System;

public class Program
{
    // Function to calculate the area of a circle
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static void Main()
    {
        // Prompt the user to input the radius
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area
        double area = CalculateCircleArea(radius);

        // Output the result
        Console.WriteLine("The area of the circle is: " + area);
    }
}

// Problem 2: Trapezoid Area Calculation

using System;

public class Program
{
    // Function to calculate the area of a trapezoid
    static double CalculateTrapezoidArea(double a, double b, double height)
    {
        return (a + b) / 2 * height;
    }

    public static void Main()
    {
        // Prompt the user to input the length of the first parallel side (a)
        Console.WriteLine("Enter the length of the first parallel side (a):");
        double a = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to input the length of the second parallel side (b)
        Console.WriteLine("Enter the length of the second parallel side (b):");
        double b = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to input the height of the trapezoid
        Console.WriteLine("Enter the height of the trapezoid:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area
        double area = CalculateTrapezoidArea(a, b, height);

        // Output the result
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}

// Problem 1: Creating a Function for Circle Area Calculation

using System;
class Program
{
    static void Main()
    {
        // Prompt the user for the radius of the circle
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Call the function to calculate the area and store the result in 'area'
        double area = CalculateCircleArea(radius);

        // Output the result
        Console.WriteLine("The area of the circle is: " + area);
    }

    // Define the method to calculate the circle's area
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}

// Problem 2: Trapezoid Area Calculation

using System;

public class Program
{
    public static void Main()
    {
        // Prompt the user for the lengths of the two parallel sides and the height
        Console.WriteLine("Enter the length of the first parallel side (a):");
        decimal a = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the length of the second parallel side (b):");
        decimal b = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the height of the trapezoid:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Call the function to calculate the area and store the result in 'area'
        decimal area = CalculateTrapezoidArea(a, b, height);

        // Output the result
        Console.WriteLine("The area of the trapezoid is: " + area);
    }

    // Define the method to calculate the trapezoid's area
    static decimal CalculateTrapezoidArea(decimal a, decimal b, decimal height)
    {
        return (a + b) / 2 * height;
    }
}

// Step 1: Defining and Calling a Simple Method

using System;

public class Program
{

    public static void Main()
    {
        // Method Definition
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to our Program!");
        }

        // Call the method
        DisplayWelcomeMessage();
    }
}

// Step 2: Creating a Method with Parameters

using System;

public class Program
{

    public static void Main()
    {
        // Method Definition
        static void GreetUser(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }

        // Call the method
        GreetUser("Alice");

    }
}

// Step 3: Using Methods with Return Values

using System;

public class Program
{

    public static void Main()
    {
        // Method Definition
        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        // Call the method and store the result
        int sum = CalculateSum(5, 7);
        Console.WriteLine("The sum is: " + sum);

    }
}


// Step 4: Combining Methods and Conditional Logic

using System;

public class Program
{

    public static void Main()
    {
        // Call the method
        int number = -3;
        bool result = IsPositive(number);
        if (result)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is not positive.");
        }


    }
    static bool IsPositive(int number)
    {
        if (number > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

// Step 5: Practical Application – User Age Validation

using System;

public class Program
{

    public static void Main()
    {
        // Call the method
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        bool canDrive = IsOldEnoughToDrive(age);
        if (canDrive)
        {
            Console.WriteLine("You are old enough to drive.");
        }
        else
        {
            Console.WriteLine("You are not old enough to drive.");
        }
    }
    // Method Definition
    static bool IsOldEnoughToDrive(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

// Problem 1: Calculate the Volume of a Rectangular Box

using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the length of the box:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the box:");
        int width = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter the height of the box:");
        int height = int.Parse(Console.ReadLine());

        int volume = CalculateVolume(length, width, height);
        Console.WriteLine("The volume of the rectangular box is: " + volume);
    }
    public static int CalculateVolume(int length, int width, int height)
    {
        int volume = length * width * height;
        return volume;
    }
}

// Problem 2: Calculate the Average of Three Numbers

using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter third number:");
        int num3 = int.Parse(Console.ReadLine());

        int average = CalculateAverage(num1, num2, num3);
        Console.WriteLine("The average is: " + average);
    }
    public static int CalculateAverage(int num1, int num2, int num3)
    {
        int average = (num1 + num2 + num3) / 3;
        return average;
    }
}

// Step 1: Defining and Calling a Simple Method

using System;
					
public class Program
{
    // Define the method
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Call the method inside Main
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
    }

}

// Step 2: Creating a Method with Parameters

using System;
					
public class Program
{
    // Define the method with a parameter
    public static void GreetUser(string name)
    {
        Console.WriteLine("Hello " + name + "!");
    }

    // Call the method inside Main
    static void Main(string[] args)
    {
        GreetUser("Alice");
    }
}

Step 3: Using Methods with Return Values

using System;
					
public class Program
{
    // Define the method that returns a value
    public static int CalculateSum(int num1, int num2)
    {
        return num1 + num2;
    }

    // Call the method inside Main and store the result
    static void Main(string[] args)
    {
        int sum = CalculateSum(5, 7);
        Console.WriteLine("Sum: " + sum);
    }
}

Step 4: Combining Methods and Conditional Logic

using System;
					
public class Program
{
    // Define the method that returns a boolean
    public static bool IsPositive(int num)
    {
        if (num > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Call the method inside Main and use if-else
    static void Main(string[] args)
    {
        int number = 5;
        bool result = IsPositive(number);
        if (result)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is not positive.");
        }
    }
}

Step 5: Practical Application – User Age Validation

using System;
					
public class Program
{
    // Define the method that checks if the user is old enough to drive
    public static bool IsOldEnoughToDrive(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Call the method inside Main and check if the user is old enough to drive
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        bool canDrive = IsOldEnoughToDrive(age);
        if (canDrive)
        {
            Console.WriteLine("You are old enough to drive.");
        }
        else
        {
            Console.WriteLine("You are not old enough to drive.");
        }
    }
}




// Practical Application of Coding Concepts - Answer Key

using System;

public class TaskManager
{
    public static string task1 = "";
    public static string task2 = "";
    public static string task3 = "";

    public static bool task1Completed = false;
    public static bool task2Completed = false;
    public static bool task3Completed = false;


    public static void Main()
    {

        //we create a loop that runs until user quits
        Console.WriteLine("Choose option - (1)=Add Task, (2)=Mark Complete, (3)=Display Tasks, (4)=Quit: ");
        string option = Console.ReadLine();
        while (option != "4")
        {
            if (option == "1")
                EnterTask();
            else if (option == "2")
                MarkCompleted();
            else if (option == "3")
                DisplayTasks();

            if (option != "4")
            {
                Console.WriteLine("Choose option - (1)=Add Task, (2)=Mark Complete, (3)=Display Tasks, (4)=Quit: ");
                option = Console.ReadLine();
            }
        }
    }

    public static void EnterTask()
    {
        Console.WriteLine("Add your task: ");
        string newTask = Console.ReadLine();

        if (string.IsNullOrEmpty(task1))
        {
            task1 = newTask;
        }
        else if (string.IsNullOrEmpty(task2))
        {
            task2 = newTask;
        }
        else if (string.IsNullOrEmpty(task3))
        {
            task3 = newTask;
        }
        else
        {
            Console.WriteLine("Your task list is full.");
        }
    }

    public static void MarkCompleted()
    {
        Console.WriteLine("Which task would you like to mark as completed (1, 2, or 3)?");
        int taskToComplete = int.Parse(Console.ReadLine());

        if (taskToComplete == 1 && !string.IsNullOrEmpty(task1))
        {
            task1Completed = true;
            Console.WriteLine("Task 1 marked as completed.");
        }
        else if (taskToComplete == 2 && !string.IsNullOrEmpty(task2))
        {
            task2Completed = true;
            Console.WriteLine("Task 2 marked as completed.");
        }
        else if (taskToComplete == 3 && !string.IsNullOrEmpty(task3))
        {
            task3Completed = true;
            Console.WriteLine("Task 3 marked as completed.");
        }
        else
        {
            Console.WriteLine("Invalid task selection.");
        }
    }

    public static void DisplayTasks()
    {
        Console.WriteLine("Your Tasks:");
        if (!string.IsNullOrEmpty(task1))
        {
            Console.WriteLine(task1Completed ? "Task 1: " + task1 + " [Completed]" : "Task 1: " + task1 + " [Pending]");
        }
        if (!string.IsNullOrEmpty(task2))
        {
            Console.WriteLine(task2Completed ? "Task 2: " + task2 + " [Completed]" : "Task 2: " + task2 + " [Pending]");
        }
        if (!string.IsNullOrEmpty(task3))
        {
            Console.WriteLine(task3Completed ? "Task 3: " + task3 + " [Completed]" : "Task 3: " + task3 + " [Pending]");
        }
    }
}





