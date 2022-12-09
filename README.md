# geotab-test-assignment

## Problem: 
Write tested code (in any language) that accepts a numeric type and returns a truncated, "prettified" string version. The prettified version should include one number after the decimal when the truncated number is not an integer. It should prettify numbers greater than 6 digits and support millions, billions and trillions. 

### Examples:
input: 1000000
output: 1M
input: 2500000.34 
output: 2.5M
input: 532
output: 532
input: 1123456789
output: 1.1B 

## Approach
As a task, we will make a separate class library that can be reused anywhere in the future and imported into a new project. It was decided to use the console as an interface, because this is the fastest approach to show the results of the library.  

In addition to the implemented option through a separate library, there was a variant to make the functionality through the extension method. This approach also has the right to life, but there are nuances. 
The extension method variant is good if this functionality will be used in one project and other projects/services won't need this functionality. This approach eliminates the need to create a separate project for one small feature and the solution will look more laconic.
However, if you need to use the functionality in other projects/services, with this approach you will have to copy the function into each project and this will lead to inconsistency of data, because somewhere the function may be updated and somewhere it may be skipped. That's why I decided to use the variant of a separate class library, because it's easier to monitor and update if necessary.

## Design decisions
The main design solution was the usage of dependency injection, in order to achieve maximum flexibility and extensibility of the functionality later on. This approach is very convenient, because if we go to add a new implementation of IPrettifier (for example for scientific e notation, 3.5B == 3.5e9), it can be done with minimal changes in functionality. 

### Brief architecture description:
Frontend (aka CLI)
↓
IPrettifier ← NumberSIPrettifier (in the separate class library)
↑
NumberSIPrettifierTests

## Assumptions
Since the essence of the task is to make decorate large numbers, the first thing to do is to understand how large they will be. Obviously **int** and even **ulong** will not be enough (ulong size is 18,446,744,073,709,551,615 which equals 18.4E after decoration). For the task **double** is quite good, because its length of +- 10^308 will be enough.  
There was also a question regarding the accuracy of the fractional part of the decorated number. The requirements did not specify whether it was necessary to be able to set the accuracy of the fractional part, but I thought that such a possibility would be useful in the future and since it did not complicate the development, it was decided to add it.

## Unit tests
The entire assignment functionality is covered by unit tests. All tests are written in AAA pattern. What was tested:
1. All possible scenarios of the number scenery.
2. Scenarios with negative and fractional numbers.
3. Passing a string as an argument.
4. Calling an error because the number is too large.
5. Functioning the accuracy of the fractional part of the embellished number.  

## Requirements questions
During development, the question of rounding a number was important. For example 999999 is 999M or should it stay as it is, since the requirements say ***"It should prettify numbers greater than 6 digits"***. Similar questions arose with other edge situations (e.g. 999B is 1T or not). It was decided not to round numbers to the upper digit, so as not to violate the requirements of the TOR.
