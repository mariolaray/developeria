// See https://aka.ms/new-console-template for more information
using System.Drawing;
/*

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

*/
// EJERCICIO 4.2.2
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

var result1 = (int)Math.Round(value1 / value2);
var result2 = value2 / (decimal)value3;
var result3 = value3 / value1;

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");