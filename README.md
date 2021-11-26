# NIGTest

Solution: DayToDate.sln
Author: Wilson Siringoringo
Date: 26/11/2021
Description: A simple ASP.Net web server application with a single API service, which convert a string input to a string output. The string input is an English word for any day of the week (e.g. Thursday), and the output is a string representation of the nearest date corresponding to the day.
Assumptions:
1. The formatting of the string output is meant to be read by humans, therefore does not have formal requirements
2. Invalid input will result in a default date string of "01/01/0001", which is the lowest value of DateTime datatype in .Net
Design: The simplicity of the requirements warrants the use of a monolythic, self containing web application. As opposed to the layered design required by real life applications. A unit test project containing a handful of rudimentary tests have also been created to validate key parts of the application logic.
Coding: Although ready to use solutions may be avaliable on the public domain, the code has been written from scratch. This is because writing proprietary code is quicker than searching and harnessing someone else's code from the Internet.

