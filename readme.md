Administering the Interview
===========================
###30 minutes, 100 possible points

---
Before beginning, make sure they understand that you assume from their resume that they are proficient in .NET, C#, SOLID design principles, and at least one IoC Container

1. Show the candidate Class1 and it's unit test

  They <i>may not</i> change the for loop
  * (5 points) Have them finish the class so that the unit tests pass
  * (2 points) Single if-then-else statement
  * (2 points) StringBuilder class
  * (1 point) No extraneous lists or processing
2. Have them perform a code review on Class2
  * (2 points) Identifies "SetRange" method as Sequential Coupling issue (must call as dependency initializer)
  * (2 points) Recommends Constructor Injection
  * (2 points) Recommends putting the range elements into another class
  * (2 points) Justifies another class because it can be injected by IoC container whereas integer primitives cannot.
  * (2 points) Recognizes extranneous loop in Generate Output based on putting items in a list and calling string.join
3. Show them Class 3 and the Extensions file.
  * Ask them how they would apply the provided interface and introduce a second implementation
  * Ask them what they would need to change to make the library a pluggable dependency
4. Introduce class 4
  * Have them examine the IoC configuration in the program wrapper and suggest improvements
  * Ask them to finish the code review review by commenting on the unit tests
