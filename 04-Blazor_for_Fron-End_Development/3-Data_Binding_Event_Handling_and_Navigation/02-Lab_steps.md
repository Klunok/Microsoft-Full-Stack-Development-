# Implementing Data Binding, Event Handling, and Navigation in a Blazor Application

## Step 1: Prepare for the Application

You’ll create a Blazor WebAssembly application to manage recipes. Users will view a list of recipes, add new recipes, and see detailed instructions for each recipe.

Instructions:

1. Open **Visual Studio Code**.
2. Open the terminal (`Ctrl+\` or `View > Terminal`) and create a new Blazor WebAssembly project: `dotnet new blazorwasm -o RecipeManagerApp`
3. Navigate to the project directory: `cd RecipeManagerApp`
4. Open the project in Visual Studio Code: `code.`
5. Run the application: `dotnet run`

Create a folder called `Data` in the root directory of the project.

## Step 2: Modify the Existing Home Component

The `Home` page will display the list of recipes and allow users to view details or navigate to the "Add Recipe" page.

Instructions:

1. Create a `Recipe` class in the `Data` folder with properties:
	1. `Id`: Unique identifier.
		2. `Name`: Recipe name.
		3. `Description`: Short description.
2. Open `Home.razor` in the `Pages` folder.
3. Add a `List<Recipe>` property to hold recipes.
4. Bind the recipe list to the UI to display the name and description of each recipe.
5. Add links to:
	1. View the details of a recipe.
		2. Navigate to the **Add Recipe** page.

## Step 3: Create the Add Recipe Page

The **Add Recipe** page allows users to add a new recipe.

Instructions:

1. Create a new Razor component in the `Pages` folder named `AddRecipe.razor`.
2. Add a route directive (`@page "/addrecipe"`) at the top.
3. Include:
	1. Input fields for recipe name and description.
		2. A submit button to add the recipe.
4. Use the `NavigationManager` service to navigate back to the **Home** page after adding a recipe.

## Step 4: Add Dynamic Routing for Recipe Details

Enable users to navigate to a dynamically routed **Recipe Details** page.

Instructions:

1. Create a new Razor component named `RecipeDetails.razor` in the `Pages` folder.
2. Add a route directive like `@page "/recipe/{id:int}"` to accept recipe IDs.
3. Fetch the recipe details based on the provided ID and display them on the page.
4. Update the `Home` component to include clickable links for navigating to recipe details.

## Step 5: Add Navigation Links

Add navigation links to switch between pages.

Instructions:

1. Open `NavMenu.razor` in the `Layout` folder.
2. Add a link to the Add Recipe page (`/addrecipe`).


# Check again

## Step 1: Prepare for the Application

Open **Visual Studio Code**.

Open the terminal (Ctrl+\` or View > Terminal) and create a new Blazor WebAssembly project:

```bash
dotnet new blazorwasm -o RecipeManagerApp
```
Navigate to the project directory:

```bash
cd RecipeManagerApp
```

Open the project in Visual Studio Code:

```bash
code .
```

Run the application:

```bash
dotnet run
```

Create a folder called `Data` in the root directory of the project.

## Step 2: Home.razor

```csharp
@page "/home"
@code {
    private List<Recipe> recipes = new()
    {
        new Recipe { Id = 1, Name = "Spaghetti Bolognese", Description = "A classic Italian pasta dish." },
        new Recipe { Id = 2, Name = "Chicken Curry", Description = "A flavorful Indian curry." }
    };
}
<h3>Recipe List</h3>
<ul>
    @foreach (var recipe in recipes)
    {
        <li>
            <strong>@recipe.Name</strong> - @recipe.Description
            <br />
            <NavLink href="@($"/recipe/{recipe.Id}")"   Match="NavLinkMatch.Prefix">View Details</NavLink>

        </li>
    }
</ul>
<NavLink href="/addrecipe">Add Recipe</NavLink>
```

## Step 2: Recipe.cs (in the Data folder)

```csharp
public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
```

## Step 3: AddRecipe.razor

```csharp
@page "/addrecipe"
@inject NavigationManager NavManager
@code {
    private string recipeName;
    private string recipeDescription;

    private void SubmitRecipe()
    {
        // Logic to save the recipe (e.g., add it to a shared list)
        NavManager.NavigateTo("/home");
    }
}
<h3>Add Recipe</h3>
<input @bind="recipeName" placeholder="Recipe Name" />
<br />
<textarea @bind="recipeDescription" placeholder="Recipe Description"></textarea>
<br />
<button @onclick="SubmitRecipe">Submit</button>
```

## Step 4: RecipeDetails.razor

```csharp
@page "/recipe/{id:int}"
@code {
    [Parameter]
    public int Id { get; set; }

    private Recipe recipe;

    protected override void OnParametersSet()
    {
        // Fetch the recipe (simulate fetching with a hardcoded list)
        var recipes = new List<Recipe>
        {
            new Recipe { Id = 1, Name = "Spaghetti Bolognese", Description = "A classic Italian pasta dish." },
            new Recipe { Id = 2, Name = "Chicken Curry", Description = "A flavorful Indian curry." }
        };
        recipe = recipes.FirstOrDefault(r => r.Id == Id);
    }
}

<h3>@recipe?.Name</h3>
<p>@recipe?.Description</p>
```

## Step 5: NavMenu.razor

```csharp
<NavLink href="/addrecipe">Add Recipe</NavLink>
```

## Expected Output

1. The **Home** page displays the recipe list with links to view details.
2. The **Add Recipe** page allows adding new recipes.
3. The **Recipe Details** page dynamically displays information about a specific recipe.
