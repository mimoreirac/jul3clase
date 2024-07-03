// Número mayor, menor y promedio
Console.WriteLine("~~~~Mayor, Menor, Promedio~~~~");
Console.WriteLine("Cuántos números va a ingresar=?");
int cant_num = int.Parse(Console.ReadLine());
int mayor,menor,acumulador;
mayor = menor = acumulador = 0;

for (int i = 1; i <= cant_num; i++)
{
    Console.WriteLine("Ingrese un número");
    int num = int.Parse(Console.ReadLine());
    if (i == 1 | num > mayor)
    {
        mayor = num;
    }
    if (i == 1 | num < menor)
    {
        menor = num;
    }
    acumulador += num;
}
int resultado = acumulador/cant_num;
Console.WriteLine($"El número mayor es {mayor}.");
Console.WriteLine($"El número menor es {menor}.");
Console.WriteLine($"El promedio es {resultado}.");

