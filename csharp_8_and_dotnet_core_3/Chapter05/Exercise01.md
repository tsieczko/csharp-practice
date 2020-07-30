# Exercise 5.1

1. What are the six access modifiers and what do they do?

	- public: access is available to all
	- private: access is restricted to the class
	- protected: access is restricted to the class and other classes that inherit the class
	- internal: access is restricted to the class and and class in the same assembly/namespace
	- internal protected: access is restricted to the class and classes that inherit OR are in the same assembly
	- private protected: access is restricted to the class and classes that inherit AND are in the same assembly

2. What is the difference between the static, const, and readonly keywords?

	- static: member is shared across all instances.
	- const: member cannot be changed or updated. It must be known at compile time.
	- readonly: member cannot be changed or updated. It can be a function.

3. What does a constructor do?

It instantiates the default values of an object.

4. Why should you apply the [Flags] attribute to an enum type when you want to store combined values?

It uses less memory by making each enum member a single bit. You can set multiple bits in the same byte for example.

5. Why is the partial keyword useful?

It lets you split a class up into multiple files.

6. What is a tuple?

A tuple allows you to pack multiple variables into one variable.

7. What does the C# ref keyword do?

It returns a reference to the object a variable points to.

8. What does overloading mean?

Overloading is giving the same function or operator name multiple definitions with different signatures.

9. What is the difference between a field and a property?

A field is a data member on a class. A property is a method that acts like a field.

10. How do you make a method parameter optional?

You define the method with default values ex: `bool IsTrue(bool variable = true) {}`.
