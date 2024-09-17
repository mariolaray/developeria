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
// Crear un array de nombres
        string[] nombres = {"Sophia", "Andrew", "Emma", "Logan"};

        // Crear un array de enteros
        int[][] notas = new int[4][];
        notas[0] = new int[] {90, 86, 87, 98, 100};
        notas[1] = new int[] {92, 89, 81, 96, 90};
        notas[2] = new int[] {90, 85, 87, 98, 68};
        notas[3] = new int[] {90, 95, 87, 88, 96};

        var indiceDeNota = 0;
string letra = "";

        // Mostrar los nombres y sus valores asociados
        foreach (var nombre in nombres)
        {
            int sumaDeValores = 0;
            
            foreach (var nota in notas[indiceDeNota])
            {
                sumaDeValores += nota;
            }

            var media = sumaDeValores / notas[indiceDeNota].Length;
            
            if (media >= 97)
        letra = "A+";

    else if (media >= 93)
        letra = "A";

    else if (media >= 90)
        letra = "A-";

    else if (media >= 87)
        letra = "B+";

    else if (media >= 83)
        letra = "B";

    else if (media >= 80)
        letra = "B-";

    else if (media >= 77)
        letra = "C+";

    else if (media >= 73)
        letra = "C";

    else if (media >= 70)
        letra = "C-";

    else if (media >= 67)
        letra = "D+";

    else if (media >= 63)
        letra = "D";

    else if (media >= 60)
        letra = "D-";

    else
        letra = "F";

            Console.WriteLine($"Nombre: {nombre}, Valores: {string.Join(",", notas[indiceDeNota])}, Media: {media} , Letra: {letra}");

            indiceDeNota++;
        }