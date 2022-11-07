// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

int number = 0;

static bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Indtast nummer: ");

while (Int32.TryParse(Console.ReadLine(), out number) == false)
{
    Console.WriteLine("Prøv Igen");
}

Console.WriteLine(IsEven(number));



/*

static double plus(double x, double y)
{
    return x + y;
}

static double minus(double x, double y)
{
    return x - y;
}

static double multiply(double x, double y)
{
    return x * y;
}

static double divide(double x, double y)
{
    return x / y;
}


Console.WriteLine("Indtast først tal: ");
double input1 = 0;
double input2 = 0;

while (Double.TryParse(Console.ReadLine(), out input1) == false)
{
    Console.WriteLine("Prøv igen:");
}

Console.WriteLine("Indtast andet tal: ");

while (Double.TryParse(Console.ReadLine(), out input2) == false)
{
    Console.WriteLine("Prøv igen:");
}


int valg = 0;
int[] valgArray = { 1, 2, 3, 4 };

Console.WriteLine("Vælg operation:\n" +
"(1) - Plus\n" +
"(2) - Minus\n" +
"(3) - Gange\n" +
"(4) - Divider");

while (Int32.TryParse(Console.ReadLine(), out valg) == false || valgArray.Contains(valg) == false)
{
    Console.WriteLine("Prøv igen:");
}

switch (valg)
{
    case 1:
        Console.WriteLine(input1 + "+" + input2 + "=" + plus(input1, input2));
        break;
    case 2:
        Console.WriteLine(input1 + "-" + input2 + "=" + minus(input1, input2));
        break;
    case 3:
        Console.WriteLine(input1 + "*" + input2 + "=" + multiply(input1, input2));
        break;
    case 4:
        Console.WriteLine(input1 + "/" + input2 + "=" + divide(input1, input2));
        break;
}

*/



/*
for (int i = 1; i <= 10; i++)
{   
    if (i % 2 == 0)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Uneven");
    }
    Console.WriteLine(i);
}
*/

