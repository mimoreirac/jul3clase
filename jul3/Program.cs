// Factorial de un Numero
Console.WriteLine("~~~~~~~~~~~~ Factorial de un número ~~~~~~~~~~~~~");
Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());
int resultado = 1;

for (int i = 1; i <= num; i++)
{
    resultado = resultado*i;
}

Console.WriteLine(resultado);