Administering the Interview
===========================
###30 minutes, n possible points

---
Before beginning, make sure they understand that you assume from their resume that they are proficient in .NET, C#, SOLID design principles, 
and at least one IoC Container

1. Show the candidate ReverseEvenNumberGenerator and its unit test
  They <i>may not</i> change the for loop
  * (5 points) Have them finish the class so that the unit tests pass
  * (2 points) Single if-then-else statement
  * (2 points) don't concatenate strings to produce the result (string builder or string.Join)
  * (1 point) No extraneous lists or processing
  * (1 point) Style
2. Have them perform a code review on Class1
  * (2 points) Identifies "SetRange" method as Sequential Coupling issue (must call as dependency initializer)
  * (2 points) Recommends Constructor Injection
  * (2 points) name the class something meaningful
  * (2 points) Recommends putting the range elements into another class
  * (2 points) Justifies another class because it can be injected by IoC container whereas integer primitives cannot.
  * (2 points) Recognizes extraneous loop in Generate Output based on putting items in a list and calling string.join
3. Show them OddNumberGenerator and the Extensions file.
  * Ask them how they would apply the provided interface and introduce a second implementation
    * (2 points) Make the class non-static
    * (2 points) Remove the "this" keyword from each method
    * (2 points) Remove the "static" keyword from each method
    * (2 points) Change the existing calls to be made from an instance of the object
  * Ask them what they would need to change to make the library a pluggable dependency
    * (2 points) Register the desired class in the IoC container & provide as dependency
4. Introduce FizzBuzzGenerator
  * Have them examine the IoC configuration in the program wrapper and suggest improvements
    * (2 points) The UsingFactoryMethod and OnCreate registrations are a code smell that means the classes themselves should be refactored
    * (2 points) Multiple identical registrations should be performed by convention
  * Ask them to finish the code review by commenting on the unit tests
    * (1 point) Split tests into classes to mirror the classes being tested and common test setup conditions "When..."
    * (1 point) Rename test methods to follow a "Should..."
    * (2 points) Use a stub rather than private class
    * (2 points) Missing unit tests for FizzBuzzGenerator
