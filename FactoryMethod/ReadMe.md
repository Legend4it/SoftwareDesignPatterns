# Factory Method

## Description: 
Defines an interface for creating objects but allows subclasses to alter the type of objects that will be created.
## When to use: 
When the exact type of the object isn't known until runtime or when you want to decouple object creation from its usage.
## Why: 
Improves flexibility and reusability of code by isolating the object creation logic.
## Scenario:
You are building a system that needs to create different types of CreditCard objects (Visa, MasterCard, etc.), but you don’t want the client code to be tightly coupled with specific classes.