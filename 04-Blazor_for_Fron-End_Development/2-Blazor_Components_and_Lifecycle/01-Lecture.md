# Lecture 01 Blazor Components

## Introduction to Blazor Components

Blazor components are modular building blocks within Blazor applications, encapsulating user interface, logic, and state in self-contained units. Blending C#, HTML, and CSS allows for streamlined, responsive web development.

## Types of Blazor Components

### Standard Components

Standard components are pre-built elements, such as input fields, buttons, and navigation links, that handle frequent tasks without requiring custom code. These components are optimized for everyday uses, such as accepting user input, enabling data binding, and simplifying form validation, making development faster and more reliable.

### Razor Components

Razor components provide extensive customization options, allowing developers to control the appearance and behavior of specific UI elements fully. Unlike standard components, Razor components support code reuse across an application, and they encapsulate both functionality and design, making them versatile for building unique, consistent interfaces.

### Third-Party Components

Third-party components offer ready-made, advanced functionalities through external libraries. Examples include complex UI elements like charts, data grids, and sortable tables. These components are particularly useful for enterprise-level applications, saving development time on sophisticated UI needs by allowing easy integration of pre-built features.

## Key Features of Blazor Components

### Parameter Passing

Blazor components support parameter passing, allowing parent components to send data to child components. This feature enhances reusability by enabling each component instance to adapt to its context and data requirements.

### Event Handling

Event handling allows components to respond to user interactions, such as clicks or keystrokes. Blazor’s directives make it easy to bind these interactions to methods within the component, adding interactivity and responsiveness to the application.

### Lifecycle Methods

Lifecycle methods manage component behavior at different stages, including initialization, updating, and disposal. These methods help optimize performance, efficiently enabling components to handle tasks like data fetching or resource cleanup and improving app reliability.

## Conclusion

Blazor components enable developers to create modular, reusable elements seamlessly integrating UI, logic, and state. Mastering the types and features of Blazor components empowers developers to build interactive, scalable applications efficiently, enhancing both the speed and quality of development.


# Lecture 02 Lifecycle_of_Blazor_Components

## Introduction

The Blazor component lifecycle is essential for managing component state, rendering, updates, and cleanup in applications, allowing developers to build efficient and dynamic user interfaces. Lifecycle methods are specifically designed to control component behavior across different phases.

## Key Lifecycle Methods and Their Purposes

1. OnInitialized: Called once when the component is initialized. This method is suitable for setting up initial state and loading data that won’t change frequently.
2. OnInitializedAsync: An asynchronous version for data fetching at the start of the component lifecycle.
3. OnParametersSet: Triggered when the component receives new parameters from a parent. It helps update component state based on parameter changes, enabling dynamic behavior.
4. OnAfterRender: Runs after the component has rendered, ideal for interacting with JavaScript or performing post-render updates. It includes a firstRender flag to limit specific operations to the first render only.
5. Dispose: Used when a component is no longer needed, this method cleans up resources like timers or event listeners to prevent memory issues.

### Best Practices for Effective Lifecycle Method Usage

- Keep Methods Simple: Isolate responsibilities within each lifecycle method, such as handling data fetching only in OnInitialized.
- Optimize Rendering: Control unnecessary re-renders using ShouldRender, reducing performance overhead by re-rendering only when needed.

## Conclusion

By mastering these lifecycle methods, developers can enhance the responsiveness and efficiency of Blazor applications, ensuring a seamless user experience.


# Lecture 03 Communication Between Blazor Components: Parent-Child Interaction

## Introduction

In Blazor applications, components communicate to build dynamic, responsive web interfaces. This interaction is especially important for parent-child components, where data often flows from the parent to the child and, occasionally, from the child back to the parent in response to user actions or other events.

## Parent-to-Child Communication Using Parameters

Parent components use the \[Parameter\] attribute to send data to child components, a straightforward way to enable data flow without compromising each component's independence. This setup allows a child to receive data types directly from its parent, such as strings, integers, or objects.

- How It Works: The parent component assigns values to child parameters in HTML-like syntax. In the child component, properties marked with \[Parameter\] receive and utilize this data.
- Example: A parent component might pass a username to a child that displays "Hello, \[username\]"—a simple, effective way to personalize content without embedding data directly in the child component.

## Child-to-Parent Communication Using Event Callbacks:

Child components occasionally need to notify the parent component of actions, often through EventCallback and EventCallback<T>.

- EventCallback: This type allows the child to send basic event notifications to the parent. For example, when a button is clicked on the child, it can trigger an action in the parent.
- EventCallback<T>: With this generic version, the child can send specific data, like a selected item, back to the parent. This capability allows child components to remain interactive and responsive while the parent controls higher-level logic.
- Example: A child component displaying user details in a user management interface might have an "Update" button. When clicked, it triggers an EventCallback to notify the parent, updating its data list accordingly. This structure allows child components to trigger responses in the parent without direct dependencies, keeping the design modular and clean.

### Benefits of Blazor Component Communication

These communication methods enhance flexibility and modularity:

- Maintainability: Parent and child components remain loosely coupled, meaning updates in one do not affect the other.
- Reusability: Components become versatile and capable of handling varied data and use cases. For instance, a child component that displays product details can be used across different product categories by passing specific data from the parent.

## Conclusion

Blazor's approach to component communication—using parameters for parent-to-child data flow and event callbacks for child-to-parent notifications—supports scalable, maintainable applications. These techniques allow developers to build modular, reusable components that respond to user interactions while keeping code organized and efficient



