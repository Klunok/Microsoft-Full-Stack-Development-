
# Lecture 01: Data Binding in Blazor

## Introduction to Data Binding

Data binding is a technique that links the user interface (UI) to the underlying application logic, ensuring that changes in one reflect automatically in the other. In Blazor, this capability enhances interactivity and streamlines application development by removing the need for manual data updates or page refreshes.

## Core Concepts of Data Binding

Blazor supports data binding to provide flexibility and responsiveness. This includes two primary types of binding that cater to different use cases.

### One-Way Binding

One-way binding flows data from the application logic to the UI. It displays static or read-only data, such as product details or status messages. Since there’s no feedback loop from the UI to the application, it ensures the displayed data remains consistent.

### Two-Way Binding

This mode allows data to move in both directions, enabling changes in the UI (e.g., user inputs) to update the application’s data model and vice versa. This makes two-way binding an excellent choice for dynamic forms and interactive elements where data synchronization is critical.

## Practical Applications of Data Binding

The practical use cases of data binding in Blazor highlight its role in creating responsive and user-friendly applications.

1. Real-Time Form Input Management: Blazor allows forms to bind input fields directly to the application’s data. For example, a user’s input in a form field updates the data store in real-time, ensuring data persistence even if the session is interrupted. This feature is invaluable for applications with multi-step processes or large forms.
2. Dynamic User Interfaces: Data binding can dynamically update UI components based on changes in the data store. A typical example is a sports application displaying live game scores that update automatically without requiring a manual refresh.
3. State Management: Maintaining a state through data binding ensures that user actions, such as selecting options or entering data, are preserved. For instance, in an e-commerce checkout process, data binding helps retain the shipping address when progressing to the payment step, enhancing the user experience by preventing redundant inputs.

## Conclusion

Blazor’s data binding capabilities form the backbone of its interactivity and responsiveness. Enabling seamless synchronization between the UI and data simplifies development processes and enhances user experience. Whether it's managing forms, dynamically updating UIs, or maintaining state, data binding ensures applications are efficient, intuitive, and reliable. For developers, mastering data binding is essential for building modern, scalable, and user-focused Blazor applications.

# Lecture 02 Handling User Events

## Introduction

Learn how to handle common user interactions, such as button clicks, input changes, and mouse events, in Blazor to create dynamic and responsive applications.

## How to Handle Events in Blazor

### 1\. Handle Button Click Events

#### Steps

- Add a button to your Blazor page and use the @onclick directive to attach an event handler.

```csharp
<button @onclick="AddToCart">Add to Cart</button>
```

- In your code-behind or inline C#, create the event handler method:

```csharp
private void AddToCart() {
cartCount++; // Increases the cart count each time the button is clicked.
}
```

Result: When clicking the button, the AddToCart method will execute and update the cart count.

### 2\. Handle Input Changes in Real Time

#### Steps

- Add an input field and use the @oninput directive to call a method whenever the input changes.

```html
<input @oninput="UpdateSearch" placeholder="Search for products..." />
<p>You searched for: @searchQuery</p>
```

- Define the event handler method to process the input:

private void UpdateSearch(ChangeEventArgs e) {

searchQuery = e.Value.ToString(); // Updates the search query as the user types.

}

Result: The paragraph below the input will update in real-time with the text entered in the input field.

### 3\. Handle Mouse Hover Events

#### Steps

- Add an element with a @onmouseover directive to trigger an action when the user hovers over it.

```csharp
<div class="p-4 border rounded">
<p @onmouseover="ShowProductDetails">Hover over the product</p>
</div>
<p>@productDetails</p>
```

- Create the method to handle the hover event:

```csharp
private void ShowProductDetails() {
productDetails = "Eco-friendly product with reusable packaging."; // Updates details on hover.
}
```

Result: When the user hovers over the text, additional product details will appear below it.

### Tips for Success

- Reuse Handlers: Use one method for similar events across your application to reduce redundant code.
- Keep Code Organized: Separate UI markup and C# logic for maintainability.

## Conclusion

By following these steps, you can easily handle user events in Blazor, enabling you to build interactive and user-friendly applications. Experiment with these techniques to enhance the interactivity of your project


# Lecture 03 Using Event Callbacks

## Introduction

This guide outlines using EventCallback and EventCallback<T> in Blazor applications for effective event handling between child and parent components.

## Steps to Implement Event Callbacks

1. Understand Callbacks
- A callback is passed into another function or event handler, executed when a specific event occurs.

2\. Trigger Events in Child Components

- Use the EventCallback type in the child component to define events.
- Example:

```csharp
<button @onclick="OnClick">Click Me</button>
@code {
\[Parameter\]
public EventCallback OnClick { get; set; }
}
```

3\. Handle Events in Parent Components

- Pass a method from the parent to handle the child’s event.
- Example:

```csharp
<ChildComponent OnClick="HandleClick"></ChildComponent>
@code {
private void HandleClick() {
Console.WriteLine("Button clicked in the child!");
}
}
```

4\. Use EventCallback<T> to Pass Data

- Utilize EventCallback<T> for passing specific data types.
- Example in the child component:

```csharp
<button @onclick="() => OnValueSubmit.InvokeAsync(value)">Submit Value</button>
@code {
\[Parameter\]
public EventCallback<string> OnValueSubmit { get; set; }
private string value = "Blazor Rocks";
}
```

5\. Receive Data in Parent Components

- Handle the data sent by the child in the parent component:

```csharp
<ChildComponent OnValueSubmit="HandleValueSubmit"></ChildComponent>
@code {
private string receivedValue = "";
private void HandleValueSubmit(string value) {
receivedValue = value;
}
}
```

## Conclusion

Using EventCallback and EventCallback<T> enhances communication between components, enabling scalable and responsive web applications. Focus on defining clear event flows for robust event handling.
