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
*/
//EJERCICIO DE MEDIAS CON ARRAYS 
 // Crear una lista de nombres
        List<string> nombres = new List<string> { "Sophia", "Andrew", "Emma", "Logan" ,"jose"};

        // Crear una lista de listas de enteros para las notas
        List<List<int>> notas = new List<List<int>>
        {
            new List<int> { 90, 86, 87, 98, 100 },
            new List<int> { 92, 89, 81, 96, 90 },
            new List<int> { 90, 85, 87, 98, 68 },
            new List<int> { 90, 95, 87, 88, 96 },
            new List<int> { 90, 95, 87, 88, 96 }

        };

        // Mostrar los nombres y sus valores asociados
        for (int i = 0; i < nombres.Count; i++)
        {
            var nombre = nombres[i];
            var listaNotas = notas[i];

            int sumaDeValores = 0;

            foreach (var nota in listaNotas)
            {
                sumaDeValores += nota;
            }

            var media = sumaDeValores / listaNotas.Count;

            // Determinar la letra correspondiente según la media
            string letra = media switch
            {
                >= 97 => "A+",
                >= 93 => "A",
                >= 90 => "A-",
                >= 87 => "B+",
                >= 83 => "B",
                >= 80 => "B-",
                >= 77 => "C+",
                >= 73 => "C",
                >= 70 => "C-",
                >= 67 => "D+",
                >= 63 => "D",
                >= 60 => "D-",
                _ => "F"
            };

            // Imprimir la información
            Console.WriteLine($"Nombre: {nombre}, Valores: {string.Join(",", listaNotas)}, Media: {media}, Letra: {letra}");
        }
    