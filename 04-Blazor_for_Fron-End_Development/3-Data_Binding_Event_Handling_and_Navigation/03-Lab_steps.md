

## Step 1: Prepare for the Application

You’ll create a new Blazor WebAssembly project to manage user feedback. The application will allow users to submit feedback via a form, leveraging Blazor's state management and validation capabilities.

1. Open Visual Studio Code.
2. Create a new Blazor WebAssembly project:
	1. Navigate to the project directory: `dotnet new blazorwasm -o FeedbackApp`
		2. Open the terminal and run: `cd FeedbackApp`
3. Open the project in Visual Studio Code.

## Step 2: Set Up the Data Model

Define a data model to store feedback details, including validation attributes.

**Instructions:**

1. Create a folder named **Models** in the project root.
2. Inside the **Models** folder, create a file named Feedback.cs.
3. Define a class **Feedback** with the following properties:
	1. **Name**: A required string property for the user's name.
	2. **Email**: A string property with an email format validation.

## Step 3: Build the Feedback Form

Create a form to capture user feedback.

**Instructions:**

1. Open the Pages folder and create a new Razor component file named FeedbackForm.razor.
2. Use Blazor components `<EditForm>`, `<InputText>`, `<InputTextArea>`, and `<ValidationSummary>` to create the form.
3. Bind the form inputs to the properties in the Feedback model.
4. Use `<DataAnnotationsValidator>` to enable validation.

## Step 4: Implement State Management

Store and manage the submitted feedback in the application state.

**Instructions:**

1. Create a new folder named **Services**.
2. Add a file named **FeedbackService.cs** in the **Services** folder.
3. Define a service to manage a list of feedback entries:
	1. Provide methods to add and retrieve feedback.
4. Register the service in **Program.cs** using dependency injection.


## Step 5: Handle Form Submission

Process and validate the submitted feedback.

**Instructions:**

1. Add a method to the **FeedbackForm.razor** component to handle the form submission event.
2. Use dependency injection to access the **FeedbackService** and add the submitted feedback.
3. Clear the form after successful submission and display a confirmation message.

## Step 6: Display Submitted Feedback

Create a component to display the list of feedback.

**Instructions:**

1. Create a new Razor component named **FeedbackList.razor**.
2. Use a Blazor `<table>` to display feedback stored in the service.
3. Retrieve feedback data from the **FeedbackService**.


# Check again

Open Visual Studio Code.

Create a new Blazor WebAssembly project:

- Open the terminal and run:

`1 dotnet new blazorwasm -o FeedbackApp`

- Navigate to the project directory:

`1 cd FeedbackApp`

Open the project in Visual Studio Code.

# Step 2: Feedback.cs

```csharp
using System.ComponentModel.DataAnnotations;
namespace FeedbackApp.Models
{
    public class Feedback
    {
        \[Required(ErrorMessage = "Name is required.")\]
        public string Name { get; set; }
        \[EmailAddress(ErrorMessage = "Invalid email address.")\]
        public string Email { get; set; }
        \[StringLength(500, ErrorMessage = "Comment cannot exceed 500 characters.")\]
        public string Comment { get; set; }
    }
}
```

# Step 3: FeedbackForm.razor

```csharp
@page "/feedback"
@using FeedbackApp.Models
@using FeedbackApp.Services
@inject FeedbackService FeedbackService
<EditForm Model="@feedback" OnValidSubmit="HandleValidSubmit">
    <DataAnnotationsValidator />
    <ValidationSummary />
    <div>
        <label for="name">Name:</label>
        <InputText id="name" @bind-Value="feedback.Name" class="form-control" />
    </div>
    <div>
        <label for="email">Email:</label>
        <InputText id="email" @bind-Value="feedback.Email" class="form-control" />
    </div>
    <div>
        <label for="comment">Comment:</label>
        <InputTextArea id="comment" @bind-Value="feedback.Comment" class="form-control" />
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
    <a href="/feedback-list" class="btn btn-link">View Submitted Feedback</a>
</EditForm>
@if (isSubmitted)
{
    <p>Thank you for your feedback!</p>
}
@code {
    private Feedback feedback = new();
    private bool isSubmitted = false;
    private void HandleValidSubmit()
    {
        FeedbackService.AddFeedback(feedback);
```

# Step 4: FeedbackService.cs

```csharp
using FeedbackApp.Models;
using System.Collections.Generic;
namespace FeedbackApp.Services
{
   public class FeedbackService
    {
        private List<Feedback> feedbackList;
        public void AddFeedback(Feedback feedback)
        {
            if (feedbackList == null){
                feedbackList = new List<Feedback>();
            }
            feedbackList.Add(feedback);
        }
        public IEnumerable<Feedback> GetFeedback() \=> feedbackList;
    }
}
```

# Step 5: Register Service in Program.cs

`8 await builder.Build().RunAsync();`


# Step 6: FeedbackList.razor

```csharp
@page "/feedback-list"
@using FeedbackApp.Services;
@inject FeedbackService FeedbackService
<h3>Submitted Feedback</h3>
<table class="table">
    <thead>
        <tr>
            <th>Name</th>
            <th>Email</th>
            <th>Comment</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var feedback in FeedbackService.GetFeedback())
        {
            <tr>
                <td>@feedback.Name</td>
                <td>@feedback.Email</td>
                <td>@feedback.Comment</td>
            </tr>
        }
    </tbody>
</table>
```
