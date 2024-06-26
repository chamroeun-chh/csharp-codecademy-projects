# App Interfaces

The team at Computron Computing has asked you to join their product team to develop the hottest new Computron computer. You’ll be responsible for building some of the standard apps on this new machine, specifically the to-do list and the password manager.

At this point in development you have two classes started: TodoList representing the to-do list application and PasswordManager representing the password manager. In order to work within the Computron system, every app must have a display and reset feature. In other words, each class will need to implement the IDisplayable and IResetable interfaces.

Classes can implement multiple interfaces using the colon and comma syntax:

``` c#
class TodoList : IDisplayable, IResetable
{} 
```

Let’s get started! Make sure to save every file and test your code in the console with the command:


``` c#
dotnet run
```