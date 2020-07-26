# Exercise 3.1

Answer the following questions:

1. What happens when you divide an `int` variable by 0?

A `System.DivideByZeroException` exception is thrown.

2. What happens when you divide a `double` variable by 0?

The result is `∞`, infinity.

3. What happens when you overflow an `int` variable, that is, set it to a value beyond its range?

Nothing happens by default. It will only overflow to a negative number.

4. What is the difference between `x = y++;` and `x = ++y;`?

The first assigns the current value of y to x and then increments y. The second increments y first and then assigns its new value to x.

5. What is the difference between `break`, `continue`, and `return` when used inside a loop statement?

Break will end the loop. Continue will end the current iteration of the loop. Return will end the current function or method.

6. What are the three parts of a `for` statement and which of them are required?

The three parts are the initializer, conditional, and iterator. None of them are required; `for (;;)` is valid;

7. What is the difference between the `=` and `==` operators?

`=` is the assignment operator. `==` is the equality operator.

8. Does the following statement compile? `for (; true;);`

Yes. It is an infinite loop.

9. What does the underscore represent in a switch expression?

The default case.

10. What interface must an object implement to be enumerated over by using the `foreach` statement?

IEnumerable.
