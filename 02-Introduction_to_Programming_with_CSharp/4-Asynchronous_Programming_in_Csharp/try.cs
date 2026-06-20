// Creating an Asynchronous Methodpublic class Program
{
	public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }
}

// Running Multiple Asynchronous Methods
public class Program
{
	public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }
    public static async Task Main(string[] args)
    {
        Program program = new Program();
        await program.DownloadDataAsync();
        Console.WriteLine("Main method completed.");
    }
}

// Running Multiple Asynchronous Methods
public class Program
{
	public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download started...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }
    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Download 2 started...");
        await Task.Delay(2000);
        Console.WriteLine("Download 2 completed.");
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();
        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("All downloads completed.");
    }
}

// Handling Exceptions in Asynchronous Methods
public class Program
{
	
    public async Task DownloadDataAsync()
    {
        try
        {
            Console.WriteLine("Download started...");
            throw new InvalidOperationException("Simulated download error.");
            await Task.Delay(3000);
            Console.WriteLine("Download completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Download 2 started...");
        await Task.Delay(2000);
        Console.WriteLine("Download 2 completed.");
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();
        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("All downloads completed.");
    }
}

// Implementing an Asynchronous Method
public class Program
{
public static async Task PerformLongOperationAsync()
{
    Console.WriteLine("Operation started...");
    await Task.Delay(3000); // Simulate a delay of 3 seconds
    Console.WriteLine("Operation completed.");
}
}

// Calling the Async Method in Main
public static void Main(string[] args)
{
    // Calling the asynchronous method
    Task.Run(async () => await PerformLongOperationAsync()).Wait();
    Console.WriteLine("Main method completed.");
}

// Simulating Debugging with Console Statements
public static async Task PerformLongOperationAsync()
{
    Console.WriteLine("Operation started..."); // Simulate a breakpoint
    await Task.Delay(3000); // Simulate a delay of 3 seconds
    Console.WriteLine("After await..."); // Simulate a breakpoint
    Console.WriteLine("Operation completed.");
}

// Handling Potential Errors
public static async Task PerformLongOperationAsync()
{
    try
    {
        Console.WriteLine("Operation started...");
        await Task.Delay(3000); // Simulate a delay
        throw new InvalidOperationException("Simulated long operation error.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}
