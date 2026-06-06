# Step 1: Prepare for the Application

Set up a server-side Blazor application using the updated **blazor** template.

**Instructions:**

1. Open Visual Studio Code and launch the terminal.
2. Use the Blazor template to create a server-side Blazor application: `dotnet new blazor -o BlazorServerApp`
3. Change to the newly created application directory: `cd BlazorServerApp`
4. Open the folder in Visual Studio Code: `code`.
5. Restore dependencies: `dotnet restore`
6. Install the SignalR client package: `dotnet add package Microsoft.AspNetCore.SignalR.Client --version 8.*`
7. Run the application: `dotnet run`
8. Open your browser at the location indicated in the terminal to confirm the app runs correctly.

# Step 2: Configure Real-Time Features with SignalR

Implement a real-time chat feature using SignalR.

**Server-Side Setup**

1. In the `Program.cs` file, configure the SignalR services: `builder.Services.AddSignalR(); app.MapHub<NotificationHub>("/notificationHub");`
2. Create a folder named Hubs in the root directory.
3. Inside the `Hubs` folder, create a new file named `NotificationHub.cs` and add code to define a SignalR hub that broadcasts messages from a user to all connected clients in real time.

**Client-Side Integration**

1. Navigate to the `Components/Pages` folder.
2. Create a new Razor component named `SignalRChat.razor` in the `Components/Pages` folder.
3. Add code to `SignalRChat.razor` that implements a real-time chat component in Blazor Server using SignalR to enable users to send and receive messages dynamically without page refresh.

# Step 3: Demonstrate State Management

Add a page to demonstrate server-side state management.

**Instructions:**

1. Create a new Razor component named `StateManagement.razor` in the `Components/Pages` folder.
2. Add code to `StateManagement.razor` to increment a counter.

# Step 4: Update Navigation

Modify the navigation menu to include links to the new pages.

**Instructions:**

1. Open the `Components/Layout/NavMenu.razor` file.
2. Add links to the `SignalRChat` and `StateManagement` pages.

# Step 5: Test the Application

**Instructions:**

1. Run the application: dotnet run
2. Navigate to:
	- `/signalrchat`: Test the real-time chat functionality.
	- `/state:` Test the state management functionality by clicking the button and observing the counter.


# Check Again!

NotificationHub.cs

```csharp
using Microsoft.AspNetCore.SignalR;

public class NotificationHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
```

SignalRChat.razor
```csharp
@page "/signalrchat"
@rendermode InteractiveServer
@using Microsoft.AspNetCore.SignalR.Client
@inject NavigationManager Navigation

<h3>SignalR Chat</h3>

<input @bind="userName" placeholder="Enter your name" />
<input @bind="message" placeholder="Enter a message" />
<button @onclick="SendMessage">Send</button>

<ul>
    @foreach (var msg in messages)
    {
        <li>@msg</li>
    }
</ul>
@code {
    private string userName;
    private string message;
    private List<string> messages = new();
    private HubConnection? hubConnection;
    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(Navigation.ToAbsoluteUri("/notificationHub"))
            .Build();
        hubConnection.On<string, string>("ReceiveMessage", (user, msg) =>
        {
            var encodedMsg = $"{user}: {msg}";
            messages.Add(encodedMsg);
            InvokeAsync(StateHasChanged);
        });
        await hubConnection.StartAsync();
    }
    private async Task SendMessage()
    {
        if (hubConnection is not null)
        {
            await hubConnection.SendAsync("SendMessage", userName, message);
        }
    }
    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }
}
```

StateManagement.razor
```csharp
@page "/state"
@rendermode InteractiveServer
<h3>State Management</h3>
<p>Click count: @clickCount</p>
<button @onclick="IncrementClickCount">Click me</button>
@code {
    private int clickCount;
    private void IncrementClickCount()
    {
        clickCount++;
    }
}
```

NavMenu.razor
```html
<nav>
   <ul>
       <li><a href="/">Home</a></li>
       <li><a href="/counter">Counter</a></li>
       <li><a href="/fetchdata">Fetch Data</a></li>
       <li><a href="/signalrchat">SignalR Chat</a></li>
       <li><a href="/state">State Management</a></li>
   </ul>
</nav>
```

