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
// EJERCICIO 4.2 TryParse 
using System;



        string[] values = { "12,3", "45", "ABC", "11", "DEF" }; // Nota: Asegúrate de usar punto (.) en lugar de coma (,)
        string message = "";
        double total = 0;

        for (int i = 0; i < values.Length; i++)
        {
            double numero;
            
            // Intentamos convertir el valor a número
            if (double.TryParse(values[i], out numero))
            {
                // Si es un número, sumarlo al total
                total += numero;
            }
            else
            {
                // Si no es un número, concatenarlo al mensaje
                message += values[i];
            }
        }

        // Mostrar los resultados finales solo una vez al final
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");
