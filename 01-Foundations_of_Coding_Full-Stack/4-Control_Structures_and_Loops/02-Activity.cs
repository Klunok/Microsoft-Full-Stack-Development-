
// Step 1: If-Else Statement for Ticket Pricing

using System;

public class Program
{

    public static void Main()
    {
        int age;
        Console.WriteLine("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("Half price ticket.");
        }
        else if (age <= 65)
        {
            Console.WriteLine("Full price ticket.");
        }
        else
        {
            Console.WriteLine("Senior discount ticket.");
        }
    }
}

// Step 2: Switch Statement for Travel Mode Selection 

using System;

public class Program
{

    public static void Main()
    {
        string mode;
        Console.WriteLine("Select a travel mode: Bus, Train, Flight");
        mode = Console.ReadLine();

        switch (mode)
        {
            case "Bus":
                Console.WriteLine("Booking a bus ticket.");
                break;
            case "Train":
                Console.WriteLine("Booking a train ticket.");
                break;
            case "Flight":
                Console.WriteLine("Booking a flight ticket.");
                break;
            default:
                Console.WriteLine("Invalid selection. Please choose Bus, Train, or Flight.");
                break;
        }

    }
}

// Problem 1: Membership Fee Calculation System

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the type of membership (basic/premium):");
        string membershipType = Console.ReadLine().ToLower();

        int fee = 0;


        if (age < 18)
        {
            if (membershipType == "basic")
            {
                fee = 15;
            }
            else if (membershipType == "premium")
            {
                fee = 25;
            }
        }
        else if (age >= 18 && age <= 60)
        {
            if (membershipType == "basic")
            {
                fee = 30;
            }
            else if (membershipType == "premium")
            {
                fee = 50;
            }
        }
        else if (age > 60)
        {
            if (membershipType == "basic")
            {
                fee = 20;
            }
            else if (membershipType == "premium")
            {
                fee = 35;
            }
        }

        Console.WriteLine("Your membership fee is: $" + fee);
    }
}

// Problem 2: Bank Account Management System

using System;

public class Program
{
    public static void Main()
    {
        // Step 1: Prompt the user to enter the account type
        Console.WriteLine("What type of account are you opening? (savings/checking/business):");
        string accountType = Console.ReadLine().ToLower();

        // Step 2: Declare variables for interest rate and monthly fee
        double interestRate = 0;
        int monthlyFee = 0;

        // Step 3: Use switch statement to determine account details based on account type
        switch (accountType)
        {
            case "savings":
                // Handle savings account: Apply 2% interest rate
                interestRate = 0.02;
                Console.WriteLine("Interest rate is 2%");
                break;

            case "checking":
                // Handle checking account: Apply $10 monthly fee
                monthlyFee = 10;
                Console.WriteLine("Monthly fee is $10");
                break;

            case "business":
                // Handle business account: Apply 1% interest rate and $20 monthly fee
                interestRate = 0.01;
                monthlyFee = 20;
                Console.WriteLine("Interest rate is 1% and monthly fee is $20");
                break;

            default:
                // Handle invalid account type
                Console.WriteLine("Invalid account type");
                break;
        }
    }
}

// Step 1: Using a For Loop to Calculate Total Scores

using System;
					
public class Program
{
    public static void Main()
    {
        int[] scores = { 85, 90, 78, 92, 88 };
        int total = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            total += scores[i];
        }

        Console.WriteLine("Total score: " + total);

    }
}

// Step 2: Using a While Loop to Calculate Factorials

using System;
					
public class Program
{
    public static void Main()
    {
        int number = 5;
        int factorial = 1;

        while (number > 0)
        {
            factorial *= number;
            number--;
        }

        Console.WriteLine("Factorial: " + factorial);
    }
}

// Step 3: Combining Loops and If-Else to Determine Pass or Fail

using System;
					
public class Program
{
    public static void Main()
    {
        int[] studentScores = { 45, 60, 72, 38, 55 };

        for (int i = 0; i < studentScores.Length; i++)
        {
            if (studentScores[i] >= 50)
            {
                Console.WriteLine(studentScores[i] + " - Pass");
            }
            else
            {
                Console.WriteLine(studentScores[i] + " - Fail");
            }
        }
    }
}

// Step 4: Combining Loops and Switch Statements for Task Scheduling

using System;
					
public class Program
{
    public static void Main()
    {
        string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        for (int i = 0; i < weekDays.Length; i++)
        {
            switch (weekDays[i])
            {
                case "Monday":
                    Console.WriteLine("Team Meeting");
                    break;
                case "Tuesday":
                    Console.WriteLine("Code Review");
                    break;
                case "Wednesday":
                    Console.WriteLine("Development");
                    break;
                case "Thursday":
                    Console.WriteLine("Testing");
                    break;
                case "Friday":
                    Console.WriteLine("Deployment");
                    break;
                default:
                    Console.WriteLine("No task assigned.");
                    break;
            }
        }
    }
}

// Step 1: Integrating If-Else with Loops

using System;
					
public class Program
{
    public static void Main()
    {
        int input;
        do
        {
            Console.WriteLine("Enter an even number between 1 and 10:");
            input = int.Parse(Console.ReadLine());
            if (input >= 1 && input <= 10 && input % 2 == 0)
            {
                Console.WriteLine("Valid input: " + input);
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (true);
    }
}

// Step 2: Using If-Else to Evaluate Grades

int[] grades = { 85, 92, 78, 64, 89 };

for (int i = 0; i < grades.Length; i++)
{
    int grade = grades[i];
    string result;
    if (grade >= 65)
    {
        result = "Pass";
    }
    else
    {
        result = "Fail";
    }
    Console.WriteLine($"Score: {grade} Result: {result}");
}

// Step 3: Integrating Switch Statements with Loops

using System;
					
public class Program
{
    public static void Main()
    {
        string[] orderStatuses = { "Pending", "Shipped", "Delivered", "Cancelled" };

		for (int i = 0; i < orderStatuses.Length; i++) {
			string status = orderStatuses[i];
			switch (status) {
				case "Pending":
					Console.WriteLine("Order is pending.");
					break;
				case "Shipped":
					Console.WriteLine("Order has been shipped.");
					break;
				case "Delivered":
					Console.WriteLine("Order has been delivered.");
					break;
				case "Cancelled":
					Console.WriteLine("Order has been cancelled.");
					break;
				default:
					Console.WriteLine("Unknown status.");
					break;
			}
		}
    }
}

// Step 4: Evaluating Student Grades with Switch and Loops

using System;
					
public class Program
{
    public static void Main()
    {
        int[] scores = { 95, 82, 75, 63, 58 };

		for (int i = 0; i < scores.Length; i++) {
			int score = scores[i];
			switch (score) {
				case int n when (n >= 90):
					Console.WriteLine("Grade A: Excellent!");
					break;
				case int n when (n >= 80):
					Console.WriteLine("Grade B: Good job!");
					break;
				case int n when (n >= 70):
					Console.WriteLine("Grade C: Fair.");
					break;
				case int n when (n >= 60):
					Console.WriteLine("Grade D: Needs improvement.");
					break;
				default:
					Console.WriteLine("Grade F: Fail.");
					break;
			}
		}
    }
}

