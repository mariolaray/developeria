// See https://aka.ms/new-console-template for more information
using System.Drawing;
/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

// 
Random random = new Random();

int saludMonstruo = 10;
int saludHeroe = 10;
int daño;

do
{
    
    if (saludMonstruo > 0)
    {
        daño = random.Next(0, 11);
        saludMonstruo -= daño;
        Console.WriteLine($"DAÑO INFLINGIDO AL MONSTRUO : {daño}* , le queda al monstruo: {saludMonstruo} de vida");
        if (saludMonstruo <= 0)
        {
            saludMonstruo = 0;
            Console.WriteLine($"LA SALUD DEL MONSTRUO HA LLEGADO A {saludMonstruo} Ó MENOS, el monstruo ha sido derrotado");
        }


        if (saludHeroe > 0 && saludMonstruo > 0)
        {
            daño = random.Next(1, 11);
            saludHeroe -= daño;
            Console.WriteLine($"DAÑO INFLINGIDO AL HEROE : {daño}* , le queda al heroe: {saludHeroe} de vida");
        }
        if (saludHeroe <= 0)
        {
            saludHeroe = 0;
            Console.WriteLine($"LA SALUD DEL HEROE HA LLEGADO A {saludHeroe} Ó MENOS , el heroe ha sido derrotado");
        }
    }
} while (saludMonstruo > 0 && saludHeroe > 0);

