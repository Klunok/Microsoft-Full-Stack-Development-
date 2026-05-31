Designing Reusable Components Using Advanced Blazor Features

## Prepare for the application

## Step 1: Prepare for the Application

#### Instructions:

1. Open **Visual Studio Code** and ensure you have the **.NET SDK** (version 6.0 or later) installed on your system.
2. Open the terminal in Visual Studio Code by navigating to View > Terminal or pressing Ctrl + ~.
3. In the terminal, use the following command to create a new Blazor WebAssembly project: dotnet new blazorwasm -o AdvancedBlazorComponents
4. Navigate into the project folder by running: cd AdvancedBlazorComponents
5. Open the project in Visual Studio Code: code. This will open a new Visual Studio Code window. You will need to open the Terminal in Visual Studio Code for the next step.
6. Build and run the project to ensure it is working correctly by using: dotnet run
7. You should see **Now listening on: http://localhost:5000** (your port number may be different)
8. Navigate to the **Pages** folder and create a new Razor file named Index.razor.
9. Add a routing directive to Index.razor to make it loadable.
10. Ensure that all default content is removed and add two instances of a component called **ReusableComponent**


## Step 2: Implementing Dependency Injection

You will implement Dependency Injection to fetch data from a service and use it in a reusable component.

#### Instructions

1. Create a Services folder in the project.
2. Add a service file called **DataService.cs** to fetch mock data.
3. In DataService.cs, create a function called GetData to return a list of strings.
4. Register the service in Program.cs.
5. Create a new Razor component named ReusableComponent.razor in the Pages folder.
6. Inject the service and use its data in ReusableComponent.razor.
7. Test the reusable component by using **dotnet run** and browse to **http://localhost:5000/index** to see the reusable component in index.razor.


## Step 3: Utilizing Cascading Parameters

You will enhance the ReusableComponent by utilizing Cascading Parameters to share data.

#### Instructions

1. Open the MainLayout.razor file in the Layout folder.
2. Wrap the layout content in a CascadingValue to define a cascading parameter called **ThemeColor**.
3. Open ReusableComponent.razor and use the cascading parameter to receive the **ThemeColor** value.
4. Create a **<p>** element with the style color set to the **ThemeColor** value.
5. Stop and restart your application and test index.razor with the updated reusable component.

## Step 4: Leveraging Component References

You will add a child component and establish communication between parent and child using component references.

#### Instructions

1. Create a new Razor file named ChildComponent.razor in the Pages folder.
2. Include the ChildComponent in ReusableComponent.razor and use a @ref directive to interact with it.
3. Test index.razor once more with the changes to reusable component.



# Check again

## Step 1: Prepare for the Application

**Command to create the project:**

dotnet new blazorwasm -o AdvancedBlazorComponents

**Index.razor file:**

@page "/index"

## Step 2: Implementing Dependency Injection

**DataService.cs:**

```csharp
using System.Collections.Generic;

public class DataService
{
    public List<string> GetData()
    {
        return new List<string> { "Item 1", "Item 2", "Item 3" };
    }
}
```

Pressing Tab in the current editor will insert the tab character. Toggle this behavior by pressing Control+Shift+M.

**Program.cs:**

builder.Services.AddSingleton<DataService>();

**ReusableComponent.razor:**
```csharp
@inject DataService DataService

<ul>
    @foreach (var item in DataService.GetData())
    {
        <li>@item</li>
    }
</ul>
```

Pressing Tab in the current editor will insert the tab character. Toggle this behavior by pressing Control+Shift+M.

## Step 3: Utilizing Cascading Parameters

**MainLayout.razor:**
```csharp
@inherits LayoutComponentBase

<CascadingValue Value="ThemeColor">
    <div class="page">
        <div class="sidebar">
            <NavMenu />
        </div>

        <main>
            <div class="top-row px-4">
                <a href="https://learn.microsoft.com/aspnet/core/" target="_blank">About</a>
            </div>

            <article class="content px-4">
                @Body
            </article>
        </main>
    </div>
</CascadingValue>

@code {
    private string ThemeColor = "lightblue";
}
```

Pressing Tab in the current editor will insert the tab character. Toggle this behavior by pressing Control+Shift+M.

**ReusableComponent.razor (updated):**

```csharp
@using Microsoft.AspNetCore.Components

@code {
    [CascadingParameter]
    public string ThemeColor { get; set; }
}

<div style="padding:10px; border:1px solid black;">
    <p style="color:@ThemeColor;">Reusable Component Content</p>
</div>
```

Pressing Tab in the current editor will insert the tab character. Toggle this behavior by pressing Control+Shift+M.

## Step 4: Leveraging Component References

**ChildComponent.razor:**

```csharp
<button @onclick="NotifyParent">Notify Parent</button>

@code {
    [Parameter]
    public EventCallback OnNotifyParent { get; set; }

    private async Task NotifyParent()
    {
        if (OnNotifyParent.HasDelegate)
        {
            await OnNotifyParent.InvokeAsync();
        }
    }
}
```

Pressing Tab in the current editor will insert the tab character. Toggle this behavior by pressing Control+Shift+M.

**ReusableComponent.razor (updated):**

```csharp
@using AdvancedBlazorComponents.Pages

<ChildComponent @ref="childComponent" OnNotifyParent="HandleNotification" />

@code {
    private ChildComponent childComponent;

    private void HandleNotification()
    {
        // Logic to handle notifications from the child component
 	 Console.WriteLine("Notification received from child component");
    }
}
```

Pressing Tab in the current editor will insert the tab character. Toggle this behavior by pressing Control+Shift+M.

## Step 5: Testing the Reusability

**Index.razor:**

@page "/index"

<ReusableComponent /> <ReusableComponent />

## Expected Output

1. ReusableComponent displays data fetched from DataService.
2. ThemeColor cascades to all child components and affects their appearance.
3. Parent-child communication works using ChildComponent and ReusableComponent.
4. Multiple instances of ReusableComponent function independently.
