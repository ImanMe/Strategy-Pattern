# Strategy-Pattern

The function to calculate the average receives a list of numbers, and an object that is one of the concrete strategy classes.
Because the datatype for the averagingMethod parameter is “IAveragingMethod”, we can pass in any object that implements that
interface (matches the requirements for our strategy).

Then, the CalculateAverageFor() method uses the AverageFor() function in the concrete strategy class to perform the calculation.
