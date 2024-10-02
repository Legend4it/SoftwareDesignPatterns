# Decorator Pattern

## Description: 
The Decorator Pattern is a structural design pattern that allows you to dynamically add behavior or responsibilities to objects at runtime, without modifying their code or using inheritance. It wraps the original object with a "decorator" class that implements the same interface and adds new functionality by delegating tasks to the wrapped object while extending its behavior.

## When to Use Decorator
You should use the Decorator Pattern when:
- When you want to add responsibilities to individual objects, not to entire classes: If you need to add features to specific instances without affecting all instances of a class.

- When extension of behavior is needed at runtime: If you want to allow dynamic behavior modification based on runtime conditions, such as user interactions or configuration options.

- When you want to avoid class explosion: If your design would require numerous subclasses to represent various combinations of behaviors, the Decorator Pattern allows for a more manageable approach by using composition instead of inheritance.

- When you want to adhere to the Open/Closed Principle: If you want to add new functionality to classes without modifying existing code, decorators provide a way to extend functionality without altering the original classes.

## Why to Use Decorator: 
- Flexibility and Reusability: The pattern provides flexibility to create complex behaviors by combining simple decorators. It promotes code reusability since decorators can be used in different combinations for various objects.

- Single Responsibility Principle: Each decorator class has a specific responsibility, making the code easier to manage and maintain.

- Dynamic Behavior Modification: You can add or remove decorators at runtime, enabling changes in behavior on the fly without the need for modifying existing code or creating new subclasses.

- Avoids Inheritance: The Decorator Pattern reduces the need for deep inheritance trees, which can complicate code. It promotes composition over inheritance, leading to a more straightforward and comprehensible code structure.

- Clear Separation of Concerns: By delegating responsibilities to decorators, the core functionality remains focused and uncluttered, making it easier to understand, test, and extend

## Scenario:
Text Formatting System
