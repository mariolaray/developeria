// See https://aka.ms/new-console-template for more information
using System.Drawing;
/*
// EJEMPLO DE UN RANDOM 2.2
Random dice = new Random();
int roll = dice.Next(1,7);
Console.WriteLine(roll);

// EJERCICIO 2.2.5
int firstValue = 500;
int secondValue = 600;
int max = Math.Max(firstValue,secondValue);

Console.WriteLine(max);
*/
// EJEMPLO DE 2.3.2 IF'S
Random dice = new Random();

var total = 1;
var tirada = 1;

Console.Write("Dice roll");
for (int i = 0; i < 3; i++)
{
    tirada = dice.Next(1, 7);
    Console.Write($" {tirada} + ");
    total += tirada;
}


Console.WriteLine($"Total: {total}");

if (total > 10)
{
    Console.WriteLine("You win!");
}

else
{
    Console.WriteLine("Sorry, you lose.");
}