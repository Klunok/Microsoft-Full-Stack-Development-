
# Lecture 01 - Introduction to Rendering Models in Blazor

## Introduction

Blazor supports two rendering models: Server-Side Rendering (SSR) and Client-Side Rendering (CSR). These models dictate where the user interface (UI) is generated and updated, shaping the app’s performance and responsiveness.

## Server-Side Rendering (SSR)

In SSR, the server generates the UI and sends fully rendered pages to the browser. This approach ensures content is immediately ready to display.

### Key Features

- The server gathers data and builds HTML content for display.
- Content is always fresh, as it’s updated with every request.

### Advantages

- With faster initial load times and improved SEO, crawlers can easily index rendered content.
- Consistent performance across devices is especially beneficial for less-powerful client devices.

### Drawbacks

- Interactions may feel slower since user actions require server round-trips for updates.

SSR is well-suited for content-heavy or SEO-focused applications where initial load speed is critical.

## Client-Side Rendering (CSR)

CSR shifts rendering responsibility to the browser. Using technologies like Blazor WebAssembly, the browser downloads resources and processes UI updates locally.

### Key Features

- Resources such as HTML, CSS, and JavaScript are loaded initially.
- Updates and interactions occur without further server involvement.

### Advantages

- Enables faster, more interactive user experiences after the initial load.
- Allows offline functionality, as the app can function independently of the server.
- Reduces server load, improving scalability for high-traffic applications.

### Drawbacks

- Requires a larger initial download, which can delay first interactions.
- Places higher demands on the client’s device, potentially affecting older hardware.
- May face data consistency challenges if offline syncs are infrequent.

CSR is ideal for highly interactive applications where responsiveness and offline capabilities are priorities.

## Conclusion

Both SSR and CSR serve distinct purposes. SSR excels in delivering immediate content and ensuring compatibility across devices, while CSR provides dynamic and responsive experiences post-load. The choice between these models depends on the application’s needs, with hybrid approaches offering the best of both worlds.


# Lecture 02 - Use Cases of Server-Side Blazor

## Introduction

Server-side Blazor is a hosting model in the Blazor framework that enables developers to create interactive web applications using C# and.NET, where most application logic is executed on the server.

## Key Concepts

- Server-Centric Architecture: In server-side Blazor, UI updates and logic execution occur on the server, communicated to the client via a real-time connection using SignalR.
- Real-Time Updates: SignalR allows instantaneous updates to the client browser without page reloads, enabling responsive applications.
- State Management: Server-side Blazor preserves user data across sessions, ensuring a consistent and seamless user experience.

## Use Cases

- Fast Load Times: This is suitable for scenarios requiring quick initialization by reducing client-side processing and data transfer. Examples include dashboards and tools for frequent use.
- Device Compatibility: This is ideal for broad device support, including older devices without WebAssembly compatibility, such as public information sites or customer service tools.
- Real-Time Applications: Works well for apps needing instant updates, such as live reporting dashboards and collaborative tools.
- Server-Controlled Logic: Simplifies updates by managing changes on the server, immediately reflecting them on the client.

## Conclusion

Server-side Blazor is an efficient solution for creating responsive, device-compatible applications with real-time capabilities. It is particularly suited for applications with dynamic updates and diverse user bases.

# Lecture 03 - Use Cases of Client-Side Blazor

## Introduction

Client-Side Blazor, powered by WebAssembly, is a framework for building interactive web applications using C# and.NET. It fully enables client-side execution for enhanced responsiveness and functionality.

## Key Concepts

1\. Architecture

- Blazor WebAssembly runs applications entirely in the browser, leveraging WebAssembly for near-native speed and performance without JavaScript dependency.
- It initializes by downloading the.NET runtime, app code, and dependencies, creating a local environment for app execution.

2\. Execution

- Applications run locally in the browser, contacting the server only for data as needed, providing seamless and offline-friendly experiences.

3\. Advantages

- Offline capability: Supports functionality without constant internet connectivity.
- Faster and interactive user experience: Reduces delays by handling interactions directly in the browser.
- Reduced server load: Processes user actions on the client side, improving scalability.
- Enhanced interactivity: Delivers immediate feedback and engagement, such as real-time updates and media processing.

## Use Cases

1\. Single Page Applications (SPAs)

- Ideal for dynamic updates without page reloads, ensuring smooth navigation (e.g., task management tools).

2\. Highly Interactive Applications:

- Applications like healthcare apps with dynamic forms benefit from responsive and adaptive user interfaces.

3\. Media Tools

- Real-time media editing (e.g., photo editors) with immediate, server-independent adjustments.

4\. Real-Time Dashboards

- Visualizes data dynamically (e.g., sales dashboards with instant chart updates).

4\. Offline Functionality

- Supports uninterrupted use in unreliable network conditions, syncing data when reconnected (e.g., travel planning apps).

6\. Reduced Server Interaction

- Suitable for high-traffic applications, such as e-commerce, where localized processing reduces server strain.

## Conclusion

Client-Side Blazor empowers developers to create responsive, scalable, and interactive web applications. It is an excellent choice for scenarios requiring real-time responsiveness, offline capabilities, and reduced reliance on server communication.


# Lecture 04 - Implementing Hybrid Rendering

## Introduction

This guide shows you how to configure a Blazor application for hybrid rendering, combining server-side and client-side approaches for optimal performance and flexibility.

## Steps to Implement Hybrid Rendering

1\. Set Up Your Blazor Application:

- Create a Blazor Web App project using Visual Studio.
- Add necessary dependencies and libraries based on your rendering needs.

2\. Configure render modes in `Program.cs`

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services
.AddRazorComponents() // core services
.AddInteractiveServerRenderMode() // SignalR interactivity
.AddInteractiveWebAssemblyRenderMode(); // WASM interactivity
```

3\. Identify Components for Server-Side Rendering:

- Use Blazor Server for components that:
	- Handle sensitive data, such as patient records in healthcare applications.
		- Require frequent server interactions, like real-time financial data.
		- Depend heavily on server resources, such as APIs or secure databases.
- Configure these components to render on the server by adding them to your server project.

Example:

```csharp
@page "/securecomponent"
<SecureComponent />
```

4\. Identify Components for Client-Side Rendering:

- Use Blazor WebAssembly for components that:
	- Reduce server load, such as product filtering in an e-commerce site.
		- Work offline, like note-taking features in a travel app.
		- Require interactivity, such as real-time form validation or image editing.
- Add these components to your WebAssembly project and ensure they can function independently of server interactions when required.

Example:

```csharp
@page "/interactive"
<InteractiveForm @rendermode="InteractiveWebAssembly" /> (<InteractiveForm />)
```

5\. Combine Server and Client-Side Components:

- Mix server-side and client-side rendering in your application based on functionality.
- Example setup for an educational app:
- Blazor Server: Secure login and real-time data updates.
- Blazor WebAssembly: Quizzes and offline lesson plans.

6\. Optimize Your Application:

- Ensure server-rendered components minimize latency by optimizing database queries.
- Use caching for client-rendered components to enable offline interactions.
- Test your application to verify smooth transitions between server and client rendering.

## Conclusion

By assigning the right **@rendermode** to each component in **a Blazor Web App** , you can deliver secure, high‑performance features alongside offline‑capable, responsive UI—all without juggling multiple projects.

