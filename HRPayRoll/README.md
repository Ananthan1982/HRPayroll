Template for building ASP Net Core apps. This is a solution template for creating HR Payroll projects with ASP.NET Core.
### Core
The Application Core holds the employee model, which includes entities and abstract classes. This abstraction will be used to calculate the employee salary for various employee types, the new employee type can be introduced  by adding a new concrete class.
## Overview

Factories:
It defines the employee attributes which are required to create the employee object,
and the type of employees (Regular and Contract).

Model:
Which is used to load the data in UI (Employee & Employee type).

Pages:
Create.cshtml => To create the employee
Index.cshtml=>  To list the employees
Edit.cshtml => The selected employee in the list screen, will be navigated to the edit screen, where the user will enter the details like number of working days or number of absence days.
The user will have the calculate salary button, it will calculate the salary based on the details provided.

Common.cs 
Used to hold the employee details in memory.

Next improvement:
Since the salary and tax calculation varies for each employee ,all the hard coded values like salary, tax, number of working days(22) has been moved to the data access layer and it should be read from the database.
An E-leave system can be introduced , so that the number of working days can be calculated without user intervention.
Claim system helps to manage the claims applied by employees, which also impacts the salary calculation.
Time sheet management can be added as a feature, which helps to calculate the over pay and monitor the number of hours the employee has worked in a day or month.


 ## Technologies
* .NET Core 3.1
* ASP .NET Core 3.1
* Bootstrap

