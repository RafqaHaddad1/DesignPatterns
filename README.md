# 📄Design Patterns

## Table of Contents

* [Creational Design Patterns](#Creational-Design-Patterns)
    * [Factory Method](#a-factory-method)
    * [Abstract Factory](#b-abstract-factory)
    * [Builder](#c-builder)
    * [Prototype](#d-prototype)
    * [Singleton](#e-singleton)
* [Structural Design Patterns](#Structural-Design-Pattern)
    * [Adapter](#a-adapter)
    * [Bridge](#b-bridge)
    * [Composite](#c-composite)
    * [Decorator](#d-decorator)
    * [Facade](#e-facade)
    * [Flyweight](#f-flyweight)
    * [Proxy](#g-proxy)
* [Behavioral Design Patterns](#Behavioral-Design-Pattern)
    * [Chain of Responsibility](#a-chain-of-responsibility)
    * [Command](#b-command)
    * [Iterator](#c-iterator)
    * [Mediator](#d-mediator)
    * [Memento](#e-memento)
    * [Observer](#f-observer)
    * [State](#g-state)
    * [Strategy](#h-strategy)
    * [Template](#i-template)
    * [Visitor](#j-visitor)
* [Contact](#Contact)
* [References](#Reference)
  
# Design Patterns

A design pattern project typically involves implementing well-established solutions to common software design problems. It focuses on structuring code in a reusable and maintainable way, enhancing software quality and developer productivity. Projects often include identifying appropriate patterns (like Singleton, Observer, or Factory), applying them to specific problem domains (like UI frameworks or database interactions), and documenting their usage for future reference. This approach not only improves code organization but also promotes a standardized way of tackling recurring design challenges across different software components.

# Creational Design Patterns

Provide various object creation mechanisms, which increase flexibility and reuse of existing code. Helps make a system independent of how its objects are created, composed and represented

## A. Factory Method 

The **Factory Method Pattern** is a creational design pattern that provides an interface for creating objects in a superclass while allowing subclasses to determine the specific class or object to instantiate. 

### 🎯 Purpose
- Abstracts the process of object creation, promoting loose coupling between the creator and the created object.
- Enables subclasses to decide which class to instantiate.
- Defers instantiation to subclasses.

### 🛠️ When to Use
- When you don't know the exact types and dependencies of objects your code should work with.
- To provide users of your library or framework with a way to extend its internal components.
- When reusing existing objects is more efficient than rebuilding them each time.
- When encapsulating object creation logic.
- For supporting multiple product variations.
- When object initialization is somewhat expensive.

### 🧩 Components
- **Creator**: An abstract class or interface that declares the factory method.
- **Concrete Creators**: Subclasses that implement the factory method.
- **Product**: The common interface for the objects created.
- **Concrete Products**: Actual instances of objects created by the factory method.

### 🌟 Benefits
- Decouples client code from concrete classes.
- Supports extensibility and flexibility.
- Centralizes product creation code, making it easier to maintain.
- Allows introducing new product types without breaking existing client code.
- Simplifies complex object creation.

### 🤔 Impacts and Considerations
- Scalability: Easily create corresponding factories without modifying existing code.
- Maintenance.
- Code reusability.
- A powerful tool for managing complexity in software design.

### 🌍 Real-Life Scenario
- Notification System: The notification mode can vary based on user preferences or conditions.

In summary, the Factory Method Pattern provides a way to create objects dynamically, allowing for flexibility and extensibility in software design. It's particularly useful when dealing with varying object types or when you want to encapsulate object creation logic


## B. Abstract Factory 



The **Abstract Factory Pattern** is a creational design pattern that organizes the creation of related or dependent objects without specifying their concrete classes.

### 🎯 Purpose
- Create families of related products (e.g., Chair, Sofa, CoffeeTable) with different variants (e.g., Modern, Victorian, ArtDeco).
- Ensures that products within a family match.
- Defines interfaces for each product type, allowing different variants to implement these interfaces.
- Enables addition of new product families or variants without altering existing code.

### 🧩 Components
- **Abstract Factory**: High-level blueprint defining rules for creating related objects.
- **Concrete Factories**: Implement rules specified by the abstract factory, providing specific implementations for creating objects within a family.
- **Abstract Products**: Represent the family of related objects.
- **Concrete Products**: Actual instances of objects created by concrete factories.
- **Client**: Utilizes the abstract factory to create families of objects without knowing their concrete types.

### 🌍 Real-Life Scenarios
- Developing cross-platform GUI libraries (different platforms require different UI components).
- Handling various database systems (creating database-related objects for different databases).
- Maintaining consistent look and feel across diverse environments (ensuring consistent UI elements).

### 🌟 Advantages
- Isolates client code from concrete classes.
- Eases exchanging object families.
- Promotes consistency among objects.

### 🚧 Disadvantages
- Adds complexity due to multiple layers of abstraction.
- Requires defining new interfaces for each family of objects.

### 🛠️ Use When
- You need to create related objects without depending on concrete classes.
- You want to switch between different types easily while following the same rules.
- Consider implementing the abstract factory method when a class deals with multiple product types.
In summary, the Abstract Factory Pattern provides a flexible way to create families of related objects, allowing for extensibility and consistency in software design. 

---------------------------------------
### 🔄 Differences between the **Factory Method** and **Abstract Factory** patterns:

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


## C. Builder


 ### 🎯 Purpose
- Separates the construction of complex objects from their representation.
- Allows building different types and representations of an object using the same construction process.
- Enables step-by-step construction with flexibility to call only necessary steps for a specific configuration.
- Different builder classes can implement the same construction steps differently to produce various product representations.

### 🤔 When to Use
- When you want to create different representations of a product.
- For constructing composite trees or other complex objects.

### 🌟 Advantages
- Step-by-step object construction.
- Reusable construction code for various product representations.
- Adheres to the single responsibility principle by isolating complex construction logic.

### 🌍 Real-Life Scenario
- In web development, the Builder pattern can be used for creating complex Response objects in a web server.
- Example: Constructing various types of HTTP responses (with different headers, body content, and status codes) based on incoming requests.

### 🧩 Components
- **ResponseBuilder**: Defines methods for adding headers, setting status codes, and building the body.
- **Concrete Builders** (e.g., JsonResponseBuilder, HtmlResponseBuilder): Implement the interface to create different response types.
- **ResponseDirector**: Manages the construction process using a builder instance.
- **Product**: The final complex object being built.

The Builder pattern provides flexibility, reusability, and separation of concerns in complex object creation.


## D. Prototype



The **Prototype Pattern** is a creational design pattern that allows you to copy existing objects without making your code dependent on their classes. Instead of building a new object from scratch, you create a copy of an existing object (the prototype) that serves as a blueprint and can be customized as needed. 

### 🎯 Purpose
- The Prototype pattern solves the problem of creating exact copies of objects by delegating the cloning process to the objects themselves.
- It defines a common interface for cloning (typically with a single `clone` method).
- Cloning an object avoids the issues of external copying and class dependencies.
- Objects of the same class can access each other's private fields during cloning.

### 🌍 Real-Life Scenario
- In web development, the Prototype Design Pattern is useful for creating complex user interface components.
- For example, consider a web application that allows users to create custom dashboards. Each dashboard contains widgets (charts, tables, forms) configured by the user.
- Instead of creating each widget from scratch, the application can use prototypes. When a user selects a widget, the application clones the prototype and applies custom configurations.

### 🤔 When to Use
- When your code shouldn't depend on the concrete classes of the object you need to copy.
- To reduce the number of subclasses that only differ in initialization.

### 🌟 Advantages
- Clone objects without coupling to their concrete classes.
- Eliminate repeated initialization code by using pre-built prototypes.
- Conveniently produce complex objects.
- Provide an alternative to inheritance for handling configuration presets.

### 🧩 Components
- **Prototype Interface or Abstract Class**: Defines the common interface for cloning.
- **Concrete Prototypes**: Implement the prototype interface and create copies of themselves.
- **Client Code**: Interacts with prototypes and performs cloning.
- **Clone Method**: Specifies the cloning behavior.

In summary, the Prototype Pattern allows efficient object cloning and flexibility in creating complex objects.


## E. Singleton



The **Singleton pattern** is a software design pattern that ensures a class has only one instance and provides global access to that instance.

### 🎯 Purpose and Benefits
- Restricts instantiation of a class to a single instance.
- Useful when exactly one object is needed to coordinate actions across a system.
- Solves problems related to shared resources, access control, and global state.
- Provides easy access to the single instance.

### 🛠️ Implementation
- Declare all constructors of the class as private to prevent direct instantiation.
- Provide a static method (often named `getInstance`) that returns a reference to the instance.
- The instance is usually stored as a private static variable.
- Lazy initialization: The instance is created when needed (when the static method is first called).

###🌍 Real-Life Scenarios
- **Database Connections**: Manage a single database connection.
- **Configuration Files**: Read configuration settings once and reuse the same instance.
- **Logging**: Implement a logging class with a single point of access.

### 📊 Impact Analysis
- **Unit Testing**: Singleton's global state can make unit testing challenging.
- **Resource Contention**: In multi-threaded apps, synchronization is crucial to avoid conflicts.
- **Hidden Dependencies**: Singleton usage can lead to tightly coupled components.

### 🤔 When to Use
- When a class should have only one instance shared across clients (e.g., a database object).
- When stricter control over global variables is needed.

### 🔄 Difference between Static and Singleton
- **Static Class**: Cannot be instantiated; all members are static.
- **Singleton Class**: Allows one instance, holds state, and provides global access.
- A Static Class cannot be extended whereas a singleton class can be extended.
- A Static Class cannot be initialized whereas a singleton class can be.
- A Static class is loaded automatically by the CLR when the program containing the class is loaded.

  
Remember, the Singleton pattern ensures a single point of access while managing global resources! 


# Structural Design Pattern
Concerned with how classes and objects are composed to from larger structures. They help ensure that when one part of a system changes, the entire structure does not need to do the same. Explain how to assemble objects and classes into larger structures, while keeping these structures flexible and efficient


## A. Adapter



The **Adapter pattern** is a structural design pattern that allows two incompatible interfaces to collaborate.
### 🎯 Purpose and Benefits
- **Bridge Incompatible Interfaces**: The Adapter pattern acts as a bridge between existing classes with different interfaces.
- **Seamless Integration**: It enables smooth communication between systems without modifying their source code.
- **Real-Life Example**: Imagine integrating a third-party analytics library (expecting JSON) into an app that downloads stock data in XML format. The adapter converts XML data to JSON, ensuring compatibility.

### 🌍 Real-Life Scenario
- **Database Connections**: When working with different databases (e.g., MySQL, PostgreSQL), an adapter standardizes methods for connecting and querying data.
- **Third-Party Libraries**: Useful for integrating libraries or APIs with different interfaces.

### 🤔 When to Use
- When existing code has an incompatible interface with the rest of the system.
- When reusing subclasses lacking common functionality that can't be added to the superclass.

### 🌟 Advantages
- Separates interface or data conversion code from business logic.
- Allows introducing new adapters without breaking existing client code.

Remember, the Adapter pattern ensures smooth collaboration between systems with different interfaces! 


## B. Bridge


The **Bridge pattern** is a structural design pattern that allows you to split a large class or closely related classes into two separate hierarchies: abstraction and implementation. 

 ### 🎯 Purpose and Benefits
- **Decoupling Abstraction and Implementation**: The Bridge pattern separates the high-level control layer (abstraction) from the actual code that performs operations (implementation).
- **Independently Developed Hierarchies**: Abstraction and implementation can evolve independently.
- **Dynamic Bridge**: The bridge allows changing implementations at runtime.

### 🌟 Abstraction and Implementation
- **Abstraction**: Represents the high-level interface that clients interact with. It defines operations without knowing implementation details.
- **Implementation**: Provides the actual functionality. Subclasses (like DarkTheme and LightTheme) implement specific behavior.

### 🌍 Real-Life Scenarios
- **Remote Control**: Abstraction (remote control) interacts with devices (TV, DVD player) through a bridge.
- **Database Interface**: Abstraction defines standard database operations, while drivers (MySQL, PostgreSQL) handle specifics.

### 🤔 When to Use
- When abstraction and implementation need to vary independently.
- When avoiding a permanent binding between them is essential.
- To manage a proliferation of classes resulting from coupled interfaces.
- When sharing an implementation among multiple objects.

Remember, the Bridge pattern promotes modularity and flexibility by separating abstraction and implementation! 


## C. Composite



The **Composite pattern** is a structural design pattern that allows you to compose objects into tree structures and work with them as if they were individual objects.

 ### 🎯 Purpose and Benefits
- **Tree-Like Object Structure**: The Composite pattern represents hierarchical structures where individual objects and compositions (composites) share a common interface.
- **Uniform Treatment**: Client code interacts with both simple and complex elements uniformly.
- **Recursion and Polymorphism**: Conveniently work with complex tree structures using recursion and polymorphism.

### 🖼️ Example
- **CompoundGraphic**: A container class that can hold sub-shapes (simple shapes or other compound shapes).
- **Client Code**: Interacts with all shapes through a common interface, unaware of whether it's dealing with a simple shape or a compound shape.

### 🤔 When to Use
- When implementing tree-like structures (e.g., graphics, file systems).
- When you want consistent treatment of individual elements and compositions.
- When introducing new element types without breaking existing code.

### 🌍 Real-Life Scenarios
- **Customer Portfolios**: Representing a customer's portfolio in banking applications.
- **Complex GUIs**: Creating GUIs with nested elements treated uniformly.
- **File Systems**: Modeling files and directories.
- **UI Components**: Simplifying manipulation of complex UI components.

  
Remember, the Composite pattern simplifies working with hierarchical structures by treating compositions and individual elements uniformly! 


## D. Decorator


The **Decorator pattern** is a structural design pattern that allows you to add new functionality to an existing object without altering its original class.

### 🎯 Purpose and Benefits
- **Dynamic Behavior Extension**: The Decorator pattern dynamically adds behavior to an object without affecting other instances of the same class.
- **Alternative to Subclassing**: Instead of creating subclasses, decorators wrap the original object.
- **Runtime Adjustments**: Allows adding or removing dependencies during runtime.

### 🖼️ Example
- Initially, a notification library had a `Notifier` class for email notifications.
- As users demanded more types (SMS, Facebook, Slack), subclass explosion occurred.
- Decorator pattern solved this by adding behaviors dynamically using composition.
- Each notification type became a decorator, stacking on the base `Notifier`.

### 🤔 When to Use
- When assigning extra behaviors to objects at runtime without breaking existing code.
- When inheritance cannot extend an object's behavior (e.g., final classes).

### 🌍 Real-Life Scenario
- Enhancing UI components in web development (e.g., spellchecking, auto-completion).
- **Components**: Interface/abstract class, Concrete Component.
- **Decorator**: Abstract class maintaining a reference to a Component.
- **Concrete Decorator**: Extends the Decorator, providing additional behavior.

### 🌟 Advantages
- Extend behavior without new subclasses.
- Adjust responsibilities at runtime.
- Combine multiple behaviors using decorators.
- Divide monolithic classes into smaller ones.

Remember, the Decorator pattern enhances flexibility and maintains a clean structure! 


## E. Facade

### 🌐 Overview
The Facade design pattern provides a simplified interface to a complex system of classes, libraries, or frameworks, hiding underlying complexities for easier access to functionalities.

### 🎯 Purpose
To provide a straightforward interface for a complex subsystem.

### 🖼️ Example
- Imagine a computer with operations like `startCPU()`, `loadRAM()`, and `readDisk()`. A `ComputerFacade` class could offer a single method, `startComputer()`, that encapsulates these operations.

### 🤔 Use Cases
1. **Simplifying API Usage**: Facades can streamline interactions with complex APIs.
2. **Database Operations**: Simplifies database interactions by encapsulating complex operations.

   
## F. Flyweight


### 🌐 Overview
The Flyweight design pattern minimizes memory usage and computational expenses by sharing data among similar objects.

### 🎯 Purpose
To efficiently manage a large number of fine-grained objects by sharing common data.

### 🌟 Key Points
- Flyweight objects are immutable and initialized via constructor parameters.
- They do not expose setters or public fields.
- A factory method maintains a pool of flyweights, reusing or creating them as needed.

### 🌍 Real-Life Scenarios
1. **Text Editors**: Manages character formatting to reduce memory usage.
2. **Web Browsers**: Uses flyweights to prevent loading duplicate images.
3. **String Interning in Java**: Reuses identical string instances to save memory.


## G. Proxy


The **Proxy** design pattern allows you to add an extra layer of control over access to an object. 

### 🎯 Purpose
To control access to an object by acting as an intermediary.

### 🌟 Key Points
1. Proxies can perform tasks like controlling object creation, managing access rights, providing a simplified interface, and adding security checks.
2. Types of proxies include virtual, protection, remote, logging, caching, and smart reference.

### 🌟 Advantages
1. Control without clients knowing.
2. Manage object lifecycle.
3. Works even if the object isn't ready or available.
4. Introduce new proxies without changing clients or the service.

### 🌐 Different types of proxies and their use cases

### 1. Virtual Proxy
- Acts as a stand-in for expensive-to-create objects.
- Creates the real object only when its functionality is explicitly required (lazy loading).
- Example: A `VirtualImage` class that loads the actual image only when needed for display.

### 2. Protection Proxy
- Controls access to the real object, protecting it from unauthorized access.
- Implements appropriate permissions.
- Example: A `ProtectedFile` class that allows access only to users with the correct password.

### 3. Remote Proxy
- Provides a local representation for an object in a different address space or on a remote server.
- Used in distributed systems to hide the complexity of remote calls.
- Example: A `RemoteDatabase` class handling network communication with a database server.

### 4. Logging Proxy
- Adds logging functionality when accessing an object.
- Tracks the number of times an object's method has been called.
- Example: A `LoggingCalculator` class that logs calculations performed by a calculator.

### 5. Caching Proxy
- Improves performance by holding results of expensive operations.
- Reuses cached results when the same inputs occur again.
- Useful in web development for caching web pages, API calls, or database queries.
  
# Behavioral Design Pattern
Concerned with algorithms and the assignment of responsibilities between objects, they focus on the patterns of communication between classes or objects



## A. Chain of Responsibility


The **Chain of Responsibility** design pattern allows you to pass requests along a chain of handlers. Each handler decides whether to process the request or pass it to the next handler in the chain. :

### 🌐 Overview
The Chain of Responsibility design pattern allows you to pass requests along a chain of handlers. Each handler decides whether to process the request or pass it to the next handler in the chain.

### 🎯 Purpose
To handle requests by linking multiple handlers into a chain.

##@ 🖼️ Example
- Payment processing systems where a purchase request goes through handlers for different payment types (credit card, PayPal, etc.).

### 🌍 Real-Life Scenarios
1. **Event Handling in Web Development**: Events propagate up the DOM tree until a handler processes them.
2. **Logging Systems**: Log messages pass through handlers responsible for different logging actions.

### 🤔 When to Use
1. When your program processes requests that can be handled by different handlers.
2. When handling requests in a specific sequence or order is crucial.

### 🌟 Advantages
1. Provides control over the order of request handling.
2. Decouples classes that send requests from classes that handle them.


## B. Command

The **Command Design Pattern** is a behavioral design pattern that encapsulates a request as an object. It allows for the parameterization of clients with different requests and supports undoable operations—actions that can be reversed or undone in a system.

### 🧩 Components
- **Command**: An interface for executing an operation.
- **ConcreteCommand**: A class that extends the Command interface. It implements the Execute method by invoking corresponding operations on the Receiver object.
- **Receiver**: This class knows how to perform the operations associated with carrying out a request. Any class can serve as a Receiver.
- **Invoker**: A class that asks the command to carry out the request.
- **Client**: The client creates a ConcreteCommand object and sets its receiver.

### 🌍 Real-Life Scenario
- In web development, the Command pattern can be seen in event handling. When an event occurs, it can be handled by the element that triggered it or be passed up the DOM tree until an element with a corresponding event handler is found.
- In software design, it’s often used in logging systems where a log message could be passed through multiple handlers, each responsible for a different logging action (e.g., writing to a file, sending an email, etc.).
- In practice, the Command pattern decouples the sender (Invoker) from the receiver (Receiver), allowing for flexibility and reusability in object-oriented software. It's particularly useful when you want to avoid hard-wiring requests directly into classes and need to specify requests at runtime. For example, consider a remote control system for various devices, where each button press corresponds to a different command.

### 🤔 When to Use
1. When your program is expected to process different kinds of requests in various ways. It lets you link several handlers into one chain and upon receiving a request, “ask” each handler whether it can process it.
2. When it’s essential to execute several handlers in a particular order.

### 🌟 Advantages
1. You can control the order of request handling.
2. Decouple classes that invoke operations from classes that perform operations.
   

## C. Iterator
- Lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree…)




## D. Mediator


The **Mediator Design Pattern** is a behavioral pattern that defines an object—the mediator—to centralize communication between various components or objects in a system. By preventing direct interactions between components and having them communicate through the mediator, this pattern promotes loose coupling, better maintainability, and flexibility in system architecture.


### **Mediator**: 
   - The Mediator interface defines the communication contract, specifying methods that concrete mediators should implement to facilitate interactions among colleagues. It encapsulates the logic for coordinating and managing interactions between objects, promoting loose coupling and centralizing control over their communication.

### 🎯 Purpose
 - The Mediator Design Pattern defines an object—the mediator—to centralize communication between various components or objects in a system. By preventing direct interactions between components and having them communicate through the mediator, this pattern promotes loose coupling, better maintainability, and flexibility in system architecture.

### 🧩 Mediator
- The Mediator interface defines the communication contract, specifying methods that concrete mediators should implement to facilitate interactions among colleagues. It encapsulates the logic for coordinating and managing interactions between objects, promoting loose coupling and centralizing control over their communication.

### 🌍 Real-Life Analogy
- **Classroom Group Project**: In a classroom scenario, each student (colleague) has their tasks but needs to collaborate on a project. The teacher (mediator) acts as the intermediary. Instead of students talking directly to each other, they communicate through the teacher. The teacher manages communication, relaying information back and forth, ensuring effective collaboration without dealing with all the details of each other's work.

### 🖼️ Web Development Example
- **Event Management in React**: In web development, the Mediator pattern is seen in event management systems. Components communicate through a central event manager (the mediator) rather than directly with each other. For instance, in React, components update their state based on events without needing to know the inner workings of other components.

### 🖼️ Software Design Example
- **Integrated Development Environment (IDE)**: An IDE serves as a mediator between plugins and the core software. The IDE provides a central interface for plugins to extend functionality without modifying the core system directly.


## E. Memento


### 🌐 Overview
The Memento Design Pattern is a behavioral pattern that allows you to save and restore an object's internal state without revealing its implementation details. It enables capturing the internal state of an object at a particular moment and externalizing this state so that the object can be restored to that state later.

### 🧩 Components
- **Originator**: Manages the state and can create mementos.
- **Memento**: Stores the state of the originator.
- **Caretaker**: Manages and keeps track of mementos.
- **Client**: Interacts with the originator and caretaker to save or restore states.

### 🌍 Real-Life Scenario
- **Text Editor with Undo Feature**: Building a text editor where each user action (typing, formatting changes) creates a memento. These mementos can be used to revert the editor back to previous states, enabling undo functionality.

### 🌟 Use Cases
- Providing undo/redo functionality in applications.
- Protecting the state of an object from external modification by allowing controlled access to mementos.
  

## F. Observer



### 🌐 Overview
The Observer Design Pattern defines a subscription mechanism to notify multiple objects (observers) about events that happen to a subject (observable). This pattern promotes loose coupling between subjects and observers, allowing multiple objects to react to changes in the subject's state without needing to know the specifics of each other.

### 🌍 Real-Life Scenarios
- **Model-View-Controller (MVC) Frameworks**: Views (observers) update automatically when the model (subject) changes state.
- **Event Listeners in JavaScript**: Elements (subjects) in a web page notify event handlers (observers) of user interactions like clicks or input changes.
- **WebSocket Connections**: Servers (subjects) notify connected clients (observers) of real-time updates or messages.
- **Notification Systems**: Applications notify users (observers) of events such as new messages, reminders, or updates.

### 🌟 Software Development Impact
- **Decouples Subject from Observers**: Subjects and observers are independent and interact through defined interfaces, promoting flexibility and easier maintenance.
- **Supports Broadcasting Updates**: Subjects can notify multiple observers simultaneously, ensuring efficient communication of state changes.

## G. State

### 🌐 Overview
The State Design Pattern allows an object to alter its behavior when its internal state changes, appearing as if it changes its class. This pattern is useful when an object's behavior depends on its state and needs to change dynamically at runtime without massive conditional statements.

### 🧩 Components
- **Context**: Object whose behavior changes based on its internal state.
- **State Interface**: Defines methods that concrete state classes should implement.
- **Concrete State Classes**: Implement specific behaviors corresponding to different states of the context.

### 🖼️ Example
Imagine a light switch that has states "On" and "Off":
- **Context**: LightSwitch, which changes its behavior (turning on or off) based on its current state.
- **State Interface**: SwitchState, with methods like `turnOn()` and `turnOff()`.
- **Concrete State Classes**: OnState and OffState, implementing `turnOn()` and `turnOff()` methods accordingly.

### 🤔 When to Use
- When an object's behavior changes based on its internal state, and these behaviors can vary independently.
- To simplify code that would otherwise be dominated by large conditional statements.


## H. Strategy


### 🌐 Overview
The Strategy Design Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. It allows algorithms to vary independently from clients that use them, promoting flexibility and reusability in software design.

### 🎯 Purpose and Example
The Strategy pattern is useful in scenarios such as:
- **Sorting Algorithms**: Choosing different sorting strategies (e.g., bubble sort, merge sort) based on data size or type.
- **Form Validation in Web Development**: Applying validation strategies based on user input (e.g., email validation, password strength validation).

### 🤔 When to Use
You should consider using the Strategy pattern when:
- There are multiple algorithms that can be used interchangeably within a system.
- You need to encapsulate algorithms and make them easily swappable without affecting the client code.


## I. Template



### 🌐 Overview
The Template Method Design Pattern defines the skeleton of an algorithm in a superclass and allows subclasses to override specific steps. It provides a way to define the structure of an algorithm while allowing subclasses to provide specific implementations of certain steps.

### 🎯 Purpose and Example
The Template Method pattern is useful in scenarios such as:
- **Report Generation**: Where a base class defines the overall structure of generating a report (e.g., opening/closing files, formatting headers and footers), while subclasses provide specific implementations for generating different types of reports (e.g., PDF report, HTML report).

### 🤔 When to Use
You should consider using the Template Method pattern when:
- You want to define a common algorithm structure across multiple subclasses.
- Subclasses need to customize certain steps of the algorithm without changing the overall structure.

## J. Visitor




### 🌐 Overview
The Visitor Design Pattern is used to perform operations on a group of similar objects without changing their structure. It allows adding new operations to existing object structures without modifying those structures.

### 🎯 Purpose and Example
The primary purpose of the Visitor pattern is:
- **Adding New Operations**: It enables adding new operations or algorithms to a group of objects without altering their classes.

### 🖼️ Example Scenario:
In a graphical editor application:
- Objects like circles, rectangles, and triangles may each implement a `Shape` interface.
- The Visitor pattern allows defining new operations (e.g., calculating area, drawing) that can be applied uniformly across different shapes without modifying their individual classes.

### 🌍 Real-Life Scenarios
The Visitor pattern finds application in:
- **Web Development**: Manipulating DOM elements with various behaviors without changing their structure.
- **Software Design**: Operating on complex structures such as graphical elements or hierarchical data.

### 🌟 Benefits
- **Separation of Concerns**: Operations are separated from the object structure, promoting single responsibility and cleaner code.
- **Extensibility**: New operations can be added easily by creating new Visitor implementations without modifying existing objects.


## Contact

If you have any questions or feedback, feel free to reach out to us:

- **Email:** [Rafqa.elhaddad@gmail.com](mailto:Rafqa.elhaddad@gmail.com)
- **GitHub:** [RafqaHaddad1](https://github.com/RafqaHaddad1)

We appreciate your interest in this project!

## Reference

- [Refactoring Guru]( https://refactoring.guru/design-patterns/)
- [TutorialsPoint]( https://www.tutorialspoint.com/design_pattern/index.htm)
- [DotnetTutorials](https://dotnettutorials.net/lesson/design-patterns-online-training/)
- [DoFactory](https://www.dofactory.com/net/design-patterns)
- [GeeksForGeeks](https://www.geeksforgeeks.org/software-design-patterns/?ref=lbp)






