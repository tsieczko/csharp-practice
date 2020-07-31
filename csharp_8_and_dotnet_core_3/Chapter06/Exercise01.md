# Exercise 6.1

1. What is a delegate?

It is a variable that can be assigned to a function or method. 
Then, when the delegate is called, the function assigned to it is called.

2. What is an event?

An event is one or more functions that can be called from somewhere else. 
Events allow objects to pass messages to each other.

3. How are a base class and a derived class related?

The derived class contains all the members of the base class.

4. What is the difference between is and as operators?

The `is` operator returns true is both operands are the same type. T
he `as` operator casts the first operand to the type provided in the second operand. 
`as` also suppresses exceptions and just returns null.

5. Which keyword is used to prevent a class from being derived from, or a method from being further overridden?

`sealed` can be used to prevent a class from being derived from.

6. Which keyword is used to prevent a class from being instantiated with the new keyword?

`static` makes it so that a class cannot be instantiated.

7. Which keyword is used to allow a member to be overridden?

`override` allows a declares that a member is to be overridden.

8. What's the difference between a destructor and a deconstruct method?

A destructor deallocates memory and destroys everything. A deconstructor just breaks up objects into its parts (like a tuple).

9. What are the signatures of the constructors that all exceptions should have?

```C#
public PersonException() : base() { }

public PersonException(string message) : base(message) { }

public PersonException(string message, Exception innerException)
: base(message, innerException) { }
```

10. What is an extension method and how do you define one?

An extension method extends the functionality of a class. 
You define one with the `this` keyword in the parameters of methods in a class that is declared with the `static` keyword.

```C#
public static class StringExtensions
{
	public static bool IsValidEmail(this string input)
	{
		
	}
}
```
