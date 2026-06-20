# Step 1: Prepare for the Application

Create a new Blazor WebAssembly application using Visual Studio Code. This application will use hybrid rendering techniques and serve as the foundation for applying performance optimization techniques.

### Instructions:

1. **Create a New Project**:
	1. Open a terminal in Visual Studio Code (Ctrl + \`\` or View > Terminal).
	2. Run the following command to create a new Blazor WebAssembly project: 
        `dotnet new blazorwasm -o BlazorPerformanceApp` 
        This will create a new folder named `BlazorPerformanceApp` with the required files.
2. **Open the Project**:
	1. Navigate into the project directory: 
        `cd BlazorPerformanceApp`
	2. Open the project in Visual Studio Code: 
        `code.`
3. **Run the Application**:
	1. In the terminal, run the application: 
        `dotnet run`
	2. Copy the URL displayed in the terminal (e.g., `http://localhost:5000`) and open it in your browser.
	3. Verify that the default Blazor WebAssembly application loads successfully.
4. **Clean Up the Default Code**:
	1. Open the `Pages` folder and review the default Razor components.
	2. Identify the file named `Home.razor` in the `Pages` folder. This is the file you will modify in subsequent steps.


# Step 2: Impelemnt Hybrid Rendering

Add hybrid rendering logic by combining server-side and client-side Blazor features in the `HybridComponent`.

### Instructions:

1. In the `Pages` folder, create a new Razor component named `HybridComponent.razor`.
2. Use mock data to simulate a hybrid rendering scenario.
3. Add the `HybridComponent` to `Home.razor` to verify it renders correctly.
4. Now we’ll need to update the `Program.cs` file:
	1. After the variable `builder` is declared and before the line `await builder.Build().RunAsync()`; 
        add this line: `builder.Services.AddInteractiveServerComponents();`


# Step 3: Monitor and Analyze Performance

Use.NET's built-in diagnostics tools to measure the performance of your Blazor application.

### Instructions:

- **Add Logging**: Inject logging functionality into the `HybridComponent`.
- **Log Key Events**: Modify the OnInitializedAsync method in `HybridComponent.razor` to log key performance events


# Step 4: Apply Optimization Techniques

Optimize the `HybridComponent` for performance by adding lazy loading functionality.

### Instructions:

- **Modify** `Home.razor` **to Include Lazy Loading**: Update `Home.razor` by replacing the direct inclusion of the `HybridComponent` with a lazy loading approach.
- **Test the Optimization**:
	- Rebuild and run the application.
	- Click the "Load Hybrid Component" button to verify the lazy loading functionality.


# Check Again!

## Step 2: HybridComponent.razor

```csharp
<h3>Hybrid Rendering Component</h3>
@if (Data == null || !Data.Any())
{
    <p>No data available.</p>
}
else
{
    <ul>
        @foreach (var item in Data)
        {
            <li>@item</li>
        }
    </ul>
}
@code {
    private List<string>? Data;
    protected override Task OnInitializedAsync()
    {
        // Mocking sample data for testing purposes
        Data = new List<string>
        {
            "Test Data 1",
            "Test Data 2",
            "Test Data 3"
        };
        return Task.CompletedTask;
    }
}
```

## Step 2: Program.cs file

```csharp
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register root components for the application
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register services for the WebAssembly app
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Add interactive server components
builder.Services.AddInteractiveServerComponents();

await builder.Build().RunAsync();
```

## Step 3: Logging Example
Updated `HybridComponent.razor` with logging:

```csharp
@inject ILogger<HybridComponent> Logger

@code {
    private List<string>? Data;
    protected override Task OnInitializedAsync()
    {
        Logger?.LogInformation("Fetching data...");
        Data = new List<string>
        {
            "Test Data 1",
            "Test Data 2",
            "Test Data 3"
        };
        Logger?.LogInformation("Data fetch completed.");
        return Task.CompletedTask;
    }
}
```

# Step 4: Home.razor with Lazy Loading

```csharp
<h1>Welcome to Blazor Performance App</h1>
<button @onclick="LoadComponent">Load Hybrid Component</button>
@if (IsComponentLoaded)
{
    <HybridComponent />
}
@code {
    private bool IsComponentLoaded = false;

    private void LoadComponent()
    {
        IsComponentLoaded = true;
    }
}
```

### Expected Output

    1. On page load, the "Load Hybrid Component" button appears, but the `HybridComponent` is not rendered.
    1. When the button is clicked, the `HybridComponent` renders, showing the mock data (Test Data 1, Test Data 2, Test Data 3).

