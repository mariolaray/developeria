// See https://aka.ms/new-console-template for more information
using System.Drawing;
/*
*/

// EJERCICIO 3.4 mostrar resto 0 con un for e if de 3 , 5 y 3&5 del 1 al 100
for (int i = 0; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + "-FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + "-Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + "-Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }

}