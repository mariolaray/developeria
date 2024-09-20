// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Globalization;

/*
*/

// EJERCICIO 4.4 Interpolaricion de cadenas en un formulario
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
CultureInfo usCulture = new CultureInfo("en-US");

        Console.WriteLine($"Dear {customerName},");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit.ToString("C", usCulture)}.\n");

        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "";

        comparisonMessage = currentProduct.PadRight(20);
        comparisonMessage += currentReturn.ToString("P", usCulture).PadRight(10);
        comparisonMessage += currentProfit.ToString("C", usCulture).PadRight(20);

        comparisonMessage += "\n";
        comparisonMessage += newProduct.PadRight(20);
        comparisonMessage += newReturn.ToString("P", usCulture).PadRight(10);
        comparisonMessage += newProfit.ToString("C", usCulture).PadRight(20);

        Console.WriteLine(comparisonMessage);