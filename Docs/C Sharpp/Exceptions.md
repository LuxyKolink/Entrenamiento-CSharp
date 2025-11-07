![[Pasted image 20251104143454.png]]

![[Pasted image 20251104144833.png]]

![[Pasted image 20251104151808.png]]
![[Pasted image 20251105101723.png]]

![[Pasted image 20251105112307.png]]

When an exception is thrown, the thread is suspended, and if the calling code has defined a try-catch
statement, then it is given a chance to handle the exception. If the current method does not handle it,
then its calling method is given a chance, and so on up the call stack.
As you have seen, the default behavior of a console app is to output a message about the exception,
including a stack trace, and then stop running the code. The application is terminated. This is better
than allowing the code to continue executing in a potentially corrupt state. Your code should only
catch and handle exceptions that it understands and can properly fix.