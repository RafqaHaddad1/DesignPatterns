# Design Pattern
A design pattern typically involves implementing well-established solutions to common software design problems. It focuses on structuring code in a reusable and maintainable way, enhancing software quality and developer productivity. Projects often include identifying appropriate patterns (like Singleton, Observer, or Factory), applying them to specific problem domains (like UI frameworks or database interactions), and documenting their usage for future reference. This approach not only improves code organization but also promotes a standardized way of tackling recurring design challenges across different software components.

## Table of content
- [Creational Design Patterns](#Creational-Design-Patterns)
  - [Factory Method](#Factory-Method)
  - [Abstract Factory](#Abstract-Factory)
  - [Builder](#Builder)
  - [Prototype](#Prototype)
  - [Singleton](#Singleton)
- [Structural Design Patterns](#Structural-Design-Pattern)
  - [Adapter](#Adapter)
  - [Bridge](#Bridge)
  - [Composite](#Composite)
  - [Decorator](#Decorator)
  - [Facade](#Facade)
  - [Flyweight](#Flyweight)
  - [Proxy](#Proxy)
- [Behavioral Design Patterns](#Behavioral-Design-Pattern)
     - [Chain of Responsibility](#Chain-of-Responsibility)
     - [Command](#Command)
     - [Iterator](#Iterator)
     - [Mediator](#Mediator)
     - [Memento](#Memento)
     - [Observer](#Observer)
     - [State](#State)
     - [Strategy](#Strategy)
     - [Template Method](#Template)
     - [Visitor](#Visitor)
- [References](#References)
## Installation

## Usage

## Design Patterns:

A design pattern project typically involves implementing well-established solutions to common software design problems. It focuses on structuring code in a reusable and maintainable way, enhancing software quality and developer productivity. Projects often include identifying appropriate patterns (like Singleton, Observer, or Factory), applying them to specific problem domains (like UI frameworks or database interactions), and documenting their usage for future reference. This approach not only improves code organization but also promotes a standardized way of tackling recurring design challenges across different software components.

## Creational Design Patterns:
Provide various object creation mechanisms, which increase flexibility and reuse of existing code. Helps make a system independent of how its objects are created, composed and represented

---------------------------------------
### A. Factory Method:

---------------------------------------
The **Factory Method Pattern** is a creational design pattern that provides an interface for creating objects in a superclass while allowing subclasses to determine the specific class or object to instantiate. Here are the key points:

 **Purpose**:
   - Abstracts the process of object creation, promoting loose coupling between the creator and the created object.
   - Enables subclasses to decide which class to instantiate.
   - Defers instantiation to subclasses.

 **When to Use**:
   - When you don't know the exact types and dependencies of objects your code should work with.
   - To provide users of your library or framework with a way to extend its internal components.
   - When reusing existing objects is more efficient than rebuilding them each time.
   - When encapsulating object creation logic.
   - For supporting multiple product variations.
   - When object initialization is somewhat expensive.

 **Components**:
   - **Creator**: An abstract class or interface that declares the factory method.
   - **Concrete Creators**: Subclasses that implement the factory method.
   - **Product**: The common interface for the objects created.
   - **Concrete Products**: Actual instances of objects created by the factory method.

 **Benefits**:
   - Decouples client code from concrete classes.
   - Supports extensibility and flexibility.
   - Centralizes product creation code, making it easier to maintain.
   - Allows introducing new product types without breaking existing client code.
   - Simplifies complex object creation.

 **Impacts and Considerations**:
   - Scalability: Easily create corresponding factories without modifying existing code.
   - Maintenance.
   - Code reusability.
   - A powerful tool for managing complexity in software design.

 **Real-Life Scenario**:
   - Notification System: The notification mode can vary based on user preferences or conditions¹.

In summary, the Factory Method Pattern provides a way to create objects dynamically, allowing for flexibility and extensibility in software design. It's particularly useful when dealing with varying object types or when you want to encapsulate object creation logic

---------------------------------------
### B. Abstract Factory

---------------------------------------
Certainly! The **Abstract Factory Pattern** is a creational design pattern that organizes the creation of related or dependent objects without specifying their concrete classes. Here are the key points:

**Purpose**:
   - Create families of related products (e.g., Chair, Sofa, CoffeeTable) with different variants (e.g., Modern, Victorian, ArtDeco).
   - Ensures that products within a family match.
   - Defines interfaces for each product type, allowing different variants to implement these interfaces.
   - Enables addition of new product families or variants without altering existing code.

**Components**:
   - **Abstract Factory**: High-level blueprint defining rules for creating related objects.
   - **Concrete Factories**: Implement rules specified by the abstract factory, providing specific implementations for creating objects within a family.
   - **Abstract Products**: Represent the family of related objects.
   - **Concrete Products**: Actual instances of objects created by concrete factories.
   - **Client**: Utilizes the abstract factory to create families of objects without knowing their concrete types.

 **Real-Life Scenarios**:
   - Developing cross-platform GUI libraries (different platforms require different UI components).
   - Handling various database systems (creating database-related objects for different databases).
   - Maintaining consistent look and feel across diverse environments (ensuring consistent UI elements).

 **Advantages**:
   - Isolates client code from concrete classes.
   - Eases exchanging object families.
   - Promotes consistency among objects.

 **Disadvantages**:
   - Adds complexity due to multiple layers of abstraction.
   - Requires defining new interfaces for each family of objects.

 **Use When**:
   - You need to create related objects without depending on concrete classes.
   - You want to switch between different types easily while following the same rules.
   - Consider implementing the abstract factory method when a class deals with multiple product types.

In summary, the Abstract Factory Pattern provides a flexible way to create families of related objects, allowing for extensibility and consistency in software design. 

---------------------------------------
Differences between the **Factory Method** and **Abstract Factory** patterns:

---------------------------------------

 **Factory Method**:
   - **Purpose**: Defines an interface for creating an object but allows subclasses to decide which class to instantiate.
   - **Responsibility**: Delegates instantiation to subclasses, enabling them to choose the concrete implementation.
   - **Example**: Consider a class hierarchy for different vehicle types (e.g., Car, Bike). Each subclass (e.g., CarFactory, BikeFactory) implements the factory method to create a specific vehicle.
   - **Use Case**: Useful when you want to separate instantiation logic from business logic and avoid code duplication.

 **Abstract Factory**:
   - **Purpose**: Creates an entire family of related or dependent objects without specifying their concrete classes.
   - **Responsibility**: Provides an interface for creating families of objects (e.g., UI elements, furniture) that aren't in the same hierarchy.
   - **Example**: Creating different styles of UI elements (buttons, menus) for various platforms (Windows, macOS, Linux) using an abstract factory.
   - **Use Case**: Ideal when you need to create related objects with consistent behavior across different families.

In summary:
- **Factory Method** focuses on creating a single object with subclass flexibility.
- **Abstract Factory** deals with creating families of related objects. It ensures consistency and extensibility across different families .

---------------------------------------
### C. Builder

---------------------------------------
Certainly! Let's summarize the **Builder Pattern**:

 **Purpose**:
   - Separates the construction of complex objects from their representation.
   - Allows building different types and representations of an object using the same construction process.
   - Enables step-by-step construction with flexibility to call only necessary steps for a specific configuration.
   - Different builder classes can implement the same construction steps differently to produce various product representations.

 **When to Use**:
   - When you want to create different representations of a product.
   - For constructing composite trees or other complex objects.

 **Advantages**:
   - Step-by-step object construction.
   - Reusable construction code for various product representations.
   - Adheres to the single responsibility principle by isolating complex construction logic.

 **Real-Life Scenario**:
   - In web development, the Builder pattern can be used for creating complex Response objects in a web server.
   - Example: Constructing various types of HTTP responses (with different headers, body content, and status codes) based on incoming requests.
   - Components:
     - **ResponseBuilder**: Defines methods for adding headers, setting status codes, and building the body.
     - **Concrete Builders** (e.g., JsonResponseBuilder, HtmlResponseBuilder): Implement the interface to create different response types.
     - **ResponseDirector**: Manages the construction process using a builder instance.
     - **Product**: The final complex object being built.

The Builder pattern provides flexibility, reusability, and separation of concerns in complex object creation.

---------------------------------------
### D. Prototype

---------------------------------------
Certainly! The **Prototype Pattern** is a creational design pattern that allows you to copy existing objects without making your code dependent on their classes. Instead of building a new object from scratch, you create a copy of an existing object (the prototype) that serves as a blueprint and can be customized as needed. Let's break down the key points:

 **Purpose**:
   - The Prototype pattern solves the problem of creating exact copies of objects by delegating the cloning process to the objects themselves.
   - It defines a common interface for cloning (typically with a single `clone` method).
   - Cloning an object avoids the issues of external copying and class dependencies.
   - Objects of the same class can access each other's private fields during cloning.

**Real-Life Scenario**:
   - In web development, the Prototype Design Pattern is useful for creating complex user interface components.
   - For example, consider a web application that allows users to create custom dashboards. Each dashboard contains widgets (charts, tables, forms) configured by the user.
   - Instead of creating each widget from scratch, the application can use prototypes. When a user selects a widget, the application clones the prototype and applies custom configurations.

 **When to Use**:
   - When your code shouldn't depend on the concrete classes of the object you need to copy.
   - To reduce the number of subclasses that only differ in initialization.

 **Advantages**:
   - Clone objects without coupling to their concrete classes.
   - Eliminate repeated initialization code by using pre-built prototypes.
   - Conveniently produce complex objects.
   - Provide an alternative to inheritance for handling configuration presets.

 **Components**:
   - **Prototype Interface or Abstract Class**: Defines the common interface for cloning.
   - **Concrete Prototypes**: Implement the prototype interface and create copies of themselves.
   - **Client Code**: Interacts with prototypes and performs cloning.
   - **Clone Method**: Specifies the cloning behavior.

In summary, the Prototype Pattern allows efficient object cloning and flexibility in creating complex objects.

---------------------------------------
### E. Singleton

---------------------------------------
Certainly! The **Singleton pattern** is a software design pattern that ensures a class has only one instance and provides global access to that instance. Here are the key points:

1. **Purpose and Benefits**:
   - Restricts instantiation of a class to a single instance.
   - Useful when exactly one object is needed to coordinate actions across a system.
   - Solves problems related to shared resources, access control, and global state.
   - Provides easy access to the single instance.

2. **Implementation**:
   - Declare all constructors of the class as private to prevent direct instantiation.
   - Provide a static method (often named `getInstance`) that returns a reference to the instance.
   - The instance is usually stored as a private static variable.
   - Lazy initialization: The instance is created when needed (when the static method is first called).

3. **Real-Life Scenarios**:
   - **Database Connections**: Manage a single database connection.
   - **Configuration Files**: Read configuration settings once and reuse the same instance.
   - **Logging**: Implement a logging class with a single point of access.

4. **Impact Analysis**:
   - **Unit Testing**: Singleton's global state can make unit testing challenging.
   - **Resource Contention**: In multi-threaded apps, synchronization is crucial to avoid conflicts.
   - **Hidden Dependencies**: Singleton usage can lead to tightly coupled components.

5. **When to Use**:
   - When a class should have only one instance shared across clients (e.g., a database object).
   - When stricter control over global variables is needed.

6. **Difference between Static and Singleton**:
   - **Static Class**: Cannot be instantiated; all members are static.
   - **Singleton Class**: Allows one instance, holds state, and provides global access.
   - A Static Class cannot be extended whereas a singleton class can be extended.
   - A Static Class cannot be initialized whereas a singleton class can be.
   - A Static class is loaded automatically by the CLR when the program containing the class is loaded.
Remember, the Singleton pattern ensures a single point of access while managing global resources! 😊


## Structural Design Pattern
Concerned with how classes and objects are composed to from larger structures. They help ensure that when one part of a system changes, the entire structure does not need to do the same. Explain how to assemble objects and classes into larger structures, while keeping these structures flexible and efficient

---------------------------------------
### A. Adapter

---------------------------------------
Certainly! The **Adapter pattern** is a structural design pattern that allows two incompatible interfaces to collaborate. Here are the key points:

 **Purpose and Benefits**:
   - **Bridge Incompatible Interfaces**: The Adapter pattern acts as a bridge between existing classes with different interfaces.
   - **Seamless Integration**: It enables smooth communication between systems without modifying their source code.
   - **Real-Life Example**: Imagine integrating a third-party analytics library (expecting JSON) into an app that downloads stock data in XML format. The adapter converts XML data to JSON, ensuring compatibility.

 **Real-Life Scenario**:
   - **Database Connections**: When working with different databases (e.g., MySQL, PostgreSQL), an adapter standardizes methods for connecting and querying data.
   - **Third-Party Libraries**: Useful for integrating libraries or APIs with different interfaces.

 **When to Use**:
   - When existing code has an incompatible interface with the rest of the system.
   - When reusing subclasses lacking common functionality that can't be added to the superclass.

 **Advantages**:
   - Separates interface or data conversion code from business logic.
   - Allows introducing new adapters without breaking existing client code.

Remember, the Adapter pattern ensures smooth collaboration between systems with different interfaces! 😊

---------------------------------------
### B. Bridge

---------------------------------------

Certainly! The **Bridge pattern** is a structural design pattern that allows you to split a large class or closely related classes into two separate hierarchies: abstraction and implementation. Here are the key points:
 **Purpose and Benefits**:
   - **Decoupling Abstraction and Implementation**: The Bridge pattern separates the high-level control layer (abstraction) from the actual code that performs operations (implementation).
   - **Independently Developed Hierarchies**: Abstraction and implementation can evolve independently.
   - **Dynamic Bridge**: The bridge allows changing implementations at runtime.
 **Abstraction and Implementation**:
   - **Abstraction**: Represents the high-level interface that clients interact with. It defines operations without knowing implementation details.
   - **Implementation**: Provides the actual functionality. Subclasses (like DarkTheme and LightTheme) implement specific behavior.
 **Real-Life Scenarios**:
   - **Remote Control**: Abstraction (remote control) interacts with devices (TV, DVD player) through a bridge.
   - **Database Interface**: Abstraction defines standard database operations, while drivers (MySQL, PostgreSQL) handle specifics.
 **When to Use**:
   - When abstraction and implementation need to vary independently.
   - When avoiding a permanent binding between them is essential.
   - To manage a proliferation of classes resulting from coupled interfaces.
   - When sharing an implementation among multiple objects.

Remember, the Bridge pattern promotes modularity and flexibility by separating abstraction and implementation! 😊

---------------------------------------
### C. Composite

---------------------------------------

Certainly! The **Composite pattern** is a structural design pattern that allows you to compose objects into tree structures and work with them as if they were individual objects. Here are the key points:

 **Purpose and Benefits**:
   - **Tree-Like Object Structure**: The Composite pattern represents hierarchical structures where individual objects and compositions (composites) share a common interface.
   - **Uniform Treatment**: Client code interacts with both simple and complex elements uniformly.
   - **Recursion and Polymorphism**: Conveniently work with complex tree structures using recursion and polymorphism.

 **Example**:
   - **CompoundGraphic**: A container class that can hold sub-shapes (simple shapes or other compound shapes).
   - **Client Code**: Interacts with all shapes through a common interface, unaware of whether it's dealing with a simple shape or a compound shape.

 **When to Use**:
   - When implementing tree-like structures (e.g., graphics, file systems).
   - When you want consistent treatment of individual elements and compositions.
   - When introducing new element types without breaking existing code.

 **Real-Life Scenarios**:
   - **Customer Portfolios**: Representing a customer's portfolio in banking applications.
   - **Complex GUIs**: Creating GUIs with nested elements treated uniformly.
   - **File Systems**: Modeling files and directories.
   - **UI Components**: Simplifying manipulation of complex UI components.

Remember, the Composite pattern simplifies working with hierarchical structures by treating compositions and individual elements uniformly! 😊

---------------------------------------
### D. Decorator

---------------------------------------

The **Decorator pattern** is a structural design pattern that allows you to add new functionality to an existing object without altering its original class. Here are the key points:

 **Purpose and Benefits**:
   - **Dynamic Behavior Extension**: The Decorator pattern dynamically adds behavior to an object without affecting other instances of the same class.
   - **Alternative to Subclassing**: Instead of creating subclasses, decorators wrap the original object.
   - **Runtime Adjustments**: Allows adding or removing dependencies during runtime.

 **Example**:
   - Initially, a notification library had a `Notifier` class for email notifications.
   - As users demanded more types (SMS, Facebook, Slack), subclass explosion occurred.
   - Decorator pattern solved this by adding behaviors dynamically using composition.
   - Each notification type became a decorator, stacking on the base `Notifier`.

 **When to Use**:
   - When assigning extra behaviors to objects at runtime without breaking existing code.
   - When inheritance cannot extend an object's behavior (e.g., final classes).

 **Real-Life Scenario**:
   - Enhancing UI components in web development (e.g., spellchecking, auto-completion).
   - Components: Interface/abstract class, Concrete Component.
   - Decorator: Abstract class maintaining a reference to a Component.
   - Concrete Decorator: Extends the Decorator, providing additional behavior.

 **Advantages**:
   - Extend behavior without new subclasses.
   - Adjust responsibilities at runtime.
   - Combine multiple behaviors using decorators.
   - Divide monolithic classes into smaller ones.

Remember, the Decorator pattern enhances flexibility and maintains a clean structure! 😊

---------------------------------------
### E. Facade

---------------------------------------
Certainly! The **Facade** design pattern provides a simplified interface to a complex system of classes, libraries, or frameworks. It hides the underlying complexities and offers an easier way to access functionalities. Here's a summary:

- **Purpose**: To provide a straightforward interface for a complex subsystem.
- **Example**: Imagine a computer with operations like `startCPU()`, `loadRAM()`, and `readDisk()`. A `ComputerFacade` class could offer a single method, `startComputer()`, that encapsulates these operations, making it easier for users to operate the computer without dealing with low-level details.
- **Use Cases**:
    1. **Simplifying API Usage**: Facades can streamline interactions with complex APIs. Instead of making multiple API calls, a facade provides a single method that handles all necessary calls.
    2. **Database Operations**: When saving a user to a database, a facade simplifies the process by offering a `saveUser` method that hides connection handling, query preparation, execution, and error handling. 😊

---------------------------------------
### F. Flyweight

---------------------------------------
Certainly! The **Flyweight** design pattern aims to minimize memory usage and computational expenses by sharing as much data as possible among similar objects. Here's a summary:

- **Purpose**: To efficiently manage a large number of fine-grained objects by sharing common data.
- **Key Points**:
    - Flyweight objects are immutable and initialized via constructor parameters.
    - They should not expose setters or public fields.
    - A factory method maintains a pool of flyweights, reusing existing ones or creating new ones as needed.
- **Real-Life Scenarios**:
    1. **Text Editors**: In text editors, the flyweight pattern manages character formatting. Shared objects represent characters with similar formatting, reducing memory usage.
    2. **Web Browsers**: Modern browsers use flyweights to prevent loading the same images twice. Cached images save bandwidth and speed up page rendering.
    3. **String Interning in Java**: The `java.lang.String` class reuses identical string instances using the flyweight pattern, saving memory.😊

---------------------------------------
### G. Proxy

---------------------------------------
Certainly! The **Proxy** design pattern allows you to add an extra layer of control over access to an object. Here's a summary:

- **Purpose**: To control access to an object by acting as an intermediary.
- **Key Points**:
    - Proxies can perform tasks like controlling object creation, managing access rights, providing a simplified interface, and adding security checks.
    - Types of proxies include virtual, protection, remote, logging, caching, and smart reference.
- **Advantages**:
    1. Control without clients knowing.
    2. Manage object lifecycle.
    3. Works even if the object isn't ready or available.
    4. Introduce new proxies without changing clients or the service.

Different types of proxies and their use cases:

1. **Virtual Proxy**:
   - Acts as a stand-in for expensive-to-create objects.
   - Creates the real object only when its functionality is explicitly required (lazy loading).
   - Example: A `VirtualImage` class that loads the actual image only when needed for display.

2. **Protection Proxy**:
   - Controls access to the real object, protecting it from unauthorized access.
   - Implements appropriate permissions.
   - Example: A `ProtectedFile` class that allows access only to users with the correct password.

3. **Remote Proxy**:
   - Provides a local representation for an object in a different address space or on a remote server.
   - Used in distributed systems to hide the complexity of remote calls.
   - Example: A `RemoteDatabase` class handling network communication with a database server.

4. **Logging Proxy**:
   - Adds logging functionality when accessing an object.
   - Tracks the number of times an object's method has been called.
   - Example: A `LoggingCalculator` class that logs calculations performed by a calculator.

5. **Caching Proxy**:
   - Improves performance by holding results of expensive operations.
   - Reuses cached results when the same inputs occur again.
   - Useful in web development for caching web pages, API calls, or database queries.

  
## Behavioral Design Pattern
Concerned with algorithms and the assignment of responsibilities between objects, they focus on the patterns of communication between classes or objects


---------------------------------------
### A. Chain of Responsibility

---------------------------------------
Certainly! The **Chain of Responsibility** design pattern allows you to pass requests along a chain of handlers. Each handler decides whether to process the request or pass it to the next handler in the chain. Here's a summary:

- **Purpose**: To handle requests by linking multiple handlers into a chain.
- **Example**: Payment processing systems where a purchase request goes through handlers for different payment types (credit card, PayPal, etc.).
- **Real-Life Scenarios**:
    1. **Event Handling in Web Development**: Event handling passes events up the DOM tree until a corresponding event handler is found.
    2. **Logging Systems**: Log messages can be passed through multiple handlers, each responsible for different logging actions (e.g., writing to a file, sending an email).
- **When to Use**:
    1. When your program processes different requests in various ways.
    2. When executing several handlers in a specific order is essential.
- **Advantages**:
    1. Control over request handling order.
    2. Decoupling of classes that invoke operations from those that perform operations.

---------------------------------------
### B. Command

---------------------------------------
Certainly! The **Command Design Pattern** is a behavioral design pattern that encapsulates a request as an object. It allows for the parameterization of clients with different requests and supports undoable operations—actions that can be reversed or undone in a system. Let's break down the components:

1. **Command**: An interface for executing an operation.
2. **ConcreteCommand**: A class that extends the Command interface. It implements the Execute method by invoking corresponding operations on the Receiver object.
3. **Receiver**: This class knows how to perform the operations associated with carrying out a request. Any class can serve as a Receiver.
4. **Invoker**: A class that asks the command to carry out the request.
5. **Client**: The client creates a ConcreteCommand object and sets its receiver.
In practice, the Command pattern decouples the sender (Invoker) from the receiver (Receiver), allowing for flexibility and reusability in object-oriented software. It's particularly useful when you want to avoid hard-wiring requests directly into classes and need to specify requests at runtime. If you'd like an example, consider a remote control system for various devices, where each button press corresponds to a different command. 🚀

---------------------------------------
### C. Iterator: Lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree…)

---------------------------------------

---------------------------------------
### D. Mediator

---------------------------------------
Certainly! The **Mediator Design Pattern** is a behavioral pattern that defines an object—the mediator—to centralize communication between various components or objects in a system. By preventing direct interactions between components and having them communicate through the mediator, this pattern promotes loose coupling, better maintainability, and flexibility in system architecture¹.

Here's a summary of the Mediator pattern:

1. **Mediator**: The Mediator interface defines the communication contract, specifying methods that concrete mediators should implement to facilitate interactions among colleagues. It encapsulates the logic for coordinating and managing interactions between objects, promoting loose coupling and centralizing control over their communication.

2. **Real-Life Analogy**: Imagine a group project in a classroom. Each student (colleague) has their tasks but needs to work together on a project. The teacher (mediator) acts as the intermediary. Instead of students talking directly to each other, they communicate through the teacher. The teacher manages communication, relaying information back and forth. This way, everyone collaborates effectively without dealing with all the details of each other's work¹.

3. **Web Development Example**: In web development, the Mediator pattern can be seen in event management systems. Components communicate through a central event manager (the mediator) rather than directly with each other. For instance, in React, components update their state based on events without needing to know the inner workings of other components¹².

4. **Software Design Example**: An Integrated Development Environment (IDE) serves as a mediator between plugins and the core software. The IDE provides a central interface for plugins to extend functionality without modifying the core system directly. 🌟

---------------------------------------
### E. Memento

---------------------------------------

Certainly! The **Memento Design Pattern** is a behavioral pattern that allows you to save and restore an object's internal state without revealing its implementation details. Here's how it works:

1. **Components of the Memento Design Pattern**:
    - **Originator**: Responsible for creating and managing the state of an object. It can set and get the object's state and create Memento objects to store its state. The Originator communicates directly with the Memento to create snapshots of its state and restore from them.
    - **Memento**: An object that stores the state of the Originator at a specific point in time. It provides a way to retrieve the state without allowing direct modification.
    - **Caretaker**: Keeps track of Memento objects. It doesn't know the details of the state stored in the Memento but can request Mementos from the Originator to save or restore the object's state.
    - **Client**: Represents the part of the application or system that interacts with the Originator and Caretaker to achieve specific functionality. The client initiates requests to save or restore the state of the Originator through the Caretaker.

2. **Real-Life Scenario**:
    - Imagine you're building a text editor application with an undo feature. Each time the user modifies the text (typing, deleting, formatting), the editor's state (content and formatting) is saved as a memento. If the user wants to undo their last action, the editor restores its state from the most recent memento. Users can revert documents to previous states without needing to understand the internal representation of those states¹².

3. **Use Cases**:
    - When you want to produce snapshots of an object's state to restore a previous state (e.g., undo functionality).
    - When direct access to object fields or getters/setters violates encapsulation.
The Memento pattern is impactful when historical states need to be maintained and restored later. It's particularly useful for reversible actions or capturing object snapshots¹. For instance, think of it as a safety net for your application's state! 📜🔍


---------------------------------------
### F. Observer


---------------------------------------

Certainly! The **Observer Design Pattern** is a powerful behavioral pattern that allows you to define a subscription mechanism, notifying multiple objects (observers) about events that happen to the object they're observing (the subject). Let's explore some real-world scenarios where the Observer pattern shines:

1. **Model-View-Controller (MVC) Frameworks**:
   - In MVC frameworks, the model represents the subject, and views act as observers. When the model undergoes changes (such as a database update), it notifies the views to update the user interface (UI) accordingly. For example, when a user's profile data changes, the associated views (like profile pages or dashboards) automatically reflect those updates¹.

2. **Event Listeners in JavaScript**:
   - JavaScript relies heavily on event listeners, which essentially follow the Observer pattern. Elements on a webpage (the subjects) notify event handler functions (the observers) when specific events occur—such as button clicks, form submissions, or mouse movements. Event listeners allow dynamic interactions without tightly coupling the elements¹.

3. **WebSocket Connections**:
   - In real-time applications, WebSocket servers act as subjects. When new data becomes available (e.g., chat messages, live scores, stock prices), they send notifications to connected clients (observers). The Observer pattern ensures that clients receive updates without constantly polling the server¹.

4. **Notification Systems**:
   - Any application with a notification feature—whether it's email, social media, or task management—employs the Observer pattern. When new events (messages, friend requests, reminders) occur, the system notifies users through various channels. Observers (users) stay informed without needing to actively check for updates¹.

5. **Data Binding**:
   - Frameworks that support data binding (like Angular, React, or Vue.js) use the Observer pattern. UI components (observers) automatically sync with underlying data models (subjects). When data changes, the UI updates seamlessly. For instance, changing a form input value instantly reflects in the UI without manual intervention¹.

6. **Isolation and Flexibility**:
   - The Observer pattern helps keep different parts of a system isolated. By decoupling subjects from observers, it promotes maintainability and extensibility. When changes in one component (subject) affect others (observers), managing these dependencies flexibly becomes crucial. The Observer pattern provides an elegant solution to this challenge¹.

Remember, whether you're building web applications, desktop software, or mobile apps, the Observer pattern remains a valuable tool for managing communication and ensuring loose coupling between components. 🌟🔍

---------------------------------------
### G. State

---------------------------------------
Certainly! The **State Design Pattern** is a behavioral pattern that allows an object to alter its behavior when its internal state changes. It appears as if the object changes its class dynamically based on its state. Let's dive into the details:

1. **Components of the State Design Pattern**:
    - **Context**: Represents the object whose behavior changes based on its internal state. It maintains a reference to the current state object.
    - **State Interface**: Defines the contract for concrete state classes. It typically includes methods that handle specific actions related to the state.
    - **Concrete State Classes**: These classes implement the State interface. Each concrete state class represents a specific state of the context object. They encapsulate behavior related to that state.

2. **Example: Light Switch**:
    - Imagine a light switch with two possible states: "On" and "Off."
    - The `LightSwitch` class contains a reference to the `State` interface.
    - Two concrete state classes exist: `OnState` and `OffState`.
    - Each state class has a `handleRequest` method that performs an action (e.g., turning the light on or off).
    - When the `pressSwitch` method of the `LightSwitch` is called, it delegates the action to the current state's `handleRequest` method.
    - This results in toggling the light and changing the switch's state¹.

3. **When to Use the State Pattern**:
    - **Multiple States with Distinct Behaviors**: If your object can exist in several states (e.g., On/Off, Open/Closed, Started/Stopped), and each state dictates unique behaviors, the State pattern effectively encapsulates this logic.
    - **Complex Conditional Logic**: When conditional statements (if-else or switch-case) become extensive and complex within your object, the State pattern organizes and separates state-specific behavior into individual classes, improving readability and maintainability.
    - **Frequent State Changes**: If your object transitions between states frequently (e.g., during user interactions), the State pattern provides a clear mechanism for managing these transitions and their associated actions.
    - **Adding New States Easily**: If you anticipate adding new states in the future, the State pattern allows you to create new state classes without affecting existing ones¹.

Remember, the State pattern helps streamline state transitions, making your code more modular and adaptable. Whether it's a light switch, a traffic light, or any other system with changing states, this pattern provides an elegant solution! 🌟🔌

---------------------------------------
### H. Strategy

---------------------------------------
Certainly! The **Strategy pattern** is a powerful design pattern that allows you to define a family of algorithms, encapsulate each algorithm in a separate class, and make their objects interchangeable. Let's dive deeper into its key aspects:

1. **Purpose and Example**:
   - The Strategy pattern is useful when you have multiple algorithms that can be used interchangeably based on different contexts.
   - For instance:
     - In sorting, you might choose different sorting algorithms (e.g., bubble sort, merge sort, quick sort) based on the dataset's size or type.
     - In compression, you'd want to support various algorithms (like ZIP, RAR) and allow users to select their preferred one.
     - Navigation apps could use different routing strategies (fastest, shortest, avoiding tolls) that users can switch between.

2. **Web Development and E-Commerce**:
   - In web development, the Strategy pattern can be applied to form validation. Different strategies are used based on the form's context.
   - E-commerce platforms can use it for applying different discount strategies during checkout.

3. **Software Development Impact**:
   - The Strategy pattern allows you to maintain and extend algorithms without changing the clients that use them.
   - It provides flexibility and reusability by separating algorithm implementation from the context.

4. **When to Use the Strategy Pattern**:
   - **Multiple Algorithms**: When you have several interchangeable algorithms (sorting, searching, compression, etc.).
   - **Encapsulating Algorithms**: To separate algorithm details from the context, making maintenance and testing easier.
   - **Runtime Selection**: Dynamically switch between algorithms based on user preferences or system states.
   - **Reducing Conditionals**: Eliminate conditional statements in favor of modular code.
   - **Testing and Extensibility**: Facilitate unit testing and add new algorithms without modifying existing code.
Remember, the Strategy pattern promotes cleaner code, better separation of concerns, and improved maintainability. Feel free to ask if you need further clarification or examples! 😊

---------------------------------------
### I. Template

---------------------------------------
Certainly! The **Template Method pattern** is a design pattern that defines the skeleton of an algorithm in a superclass but allows subclasses to override specific steps without altering the overall structure. Let's explore its key aspects:

1. **Purpose and Example**:
   - The Template Method pattern is useful when you want to create a common processing algorithm with a fixed sequence of steps, but allow customization of specific steps by subclasses.
   - For instance:
     - In an application framework for data processing, you could define a generic structure with steps like data loading, transformation, and storage. Subclasses customize each step's behavior without changing the overall sequence.
     - In web development, a web page generation framework might use this pattern. The base class defines rendering methods for header, content, and footer. Subclasses customize these methods for different page types while maintaining a consistent layout.
     - Similarly, in software design, a report generation system could use the Template Method pattern. The base class defines the report structure (title, table of contents, summary), and subclasses implement specific content for financial, sales, or inventory reports.

2. **When to Use the Template Method Pattern**:
   - When you want clients to extend specific steps of an algorithm without altering the entire structure.
   - When you have several classes with nearly identical algorithms, differing only in minor details.
Remember, the Template Method pattern promotes code reuse, consistency, and flexibility. 😊

---------------------------------------
### J. Visitor

---------------------------------------
Certainly! The **Visitor pattern** is a design pattern used when you need to perform an operation on a group of similar objects. Let's explore its key aspects:

1. **Purpose and Example**:
   - The Visitor pattern allows you to define an external visitor class that performs specific operations on elements of a complex structure (such as a hierarchy of shapes).
   - Consider a shape hierarchy with square and circle classes. Traditionally, you'd define an `area()` method in each shape class. However, the Visitor pattern offers an alternative.
   - Here's how it works:
     - Create a separate "AreaCalculator" visitor class with methods like `visitSquare()` and `visitCircle()` to calculate the area for each shape.
     - The shapes (square, circle) have an `accept()` method that takes the visitor and calls the appropriate visit method based on the shape's type.
     - This isolates area calculation logic, making it easier to add new shapes (with corresponding visit methods) without modifying existing shape classes.

2. **Real-Life Scenarios**:
   - In web development:
     - Use the Visitor pattern to perform rendering, validation, or serialization on different types of elements in a web page.
     - For example, create a `ValidationVisitor` that checks input elements for validity. Each input element class has an `accept` method for the visitor to perform validation logic.
   - In software development:
     - For operations across diverse objects:
       - Imagine a graphics editor with shapes (circles, rectangles, lines). Use an `ExportVisitor` to export shapes into different file formats (SVG, PNG) without altering shape classes.
       - Separating concerns allows you to add new operations without modifying existing code.
Remember, the Visitor pattern promotes flexibility, maintainability, and separation of concerns 😊


## References:

https://www.tutorialspoint.com/design_pattern/index.htm

https://refactoring.guru/design-patterns

https://dotnettutorials.net/lesson/design-patterns-online-training/

https://www.dofactory.com/net/design-patterns

https://www.geeksforgeeks.org/software-design-patterns/?ref=lbp
