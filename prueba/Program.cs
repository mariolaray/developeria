// See https://aka.ms/new-console-template for more information
using System.Drawing;
/*
//Ejemplo 3.1 Caso ternario < >

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//Ejercicio 3.1 Bucle con ternario que dice si es cara o cruz

Random n1 = new Random();

while(true){
    int randomN = n1.Next(0,2);
    Console.WriteLine((randomN == 0) ? "heads": "tails");
    System.Threading.Thread.Sleep(500);
}
*/
// EJERCICIO 3.1.2 Ejercicio con tenario con privliegios
string permission = "Admin";
int level = 15;
        // Determinar el mensaje usando expresiones ternarias
        string message = permission.Contains("Admin")
            ? (level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.")
            : permission.Contains("Manager")
                ? (level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.")
                : "You do not have sufficient privileges.";

        // Mostrar el mensaje
        Console.WriteLine(message);


