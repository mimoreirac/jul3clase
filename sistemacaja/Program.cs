// Sistema de caja
bool repetir = true;

// Precios
double precio_leche, precio_pan, precio_manzana, precio_arroz, precio_jabon, precio_queso, precio_aceite, precio_papel, saldo;
precio_leche = 0.9;
precio_pan = 0.2;
precio_manzana = 0.5;
precio_arroz = 2.50;
precio_jabon = 1.30;
precio_queso = 3.50;
precio_aceite = 4.20;
precio_papel = 0.4;
saldo = .0;


do
{
    Console.WriteLine("~~~~Bienvenid@ a su tienda~~~~");
    Console.WriteLine("Elija un producto, o salir.");
    Console.WriteLine("1. Leche");
    Console.WriteLine("2. Pan");
    Console.WriteLine("3. Manzanas");
    Console.WriteLine("4. Arroz");
    Console.WriteLine("5. Jabón");
    Console.WriteLine("6. Queso");
    Console.WriteLine("7. Aceite");
    Console.WriteLine("8. Papel Higiénico");
    Console.WriteLine("9. Salir");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Cuántas unidades?");
            int cantidad = int.Parse(Console.ReadLine());
            saldo += precio_leche * cantidad;
            break;
        case "2":
            Console.WriteLine("Cuántas unidades?");
            cantidad = int.Parse(Console.ReadLine());
            saldo += precio_pan * cantidad;
            break;
        case "3":
            Console.WriteLine("Cuántas unidades?");
            cantidad = int.Parse(Console.ReadLine());
            saldo += precio_manzana * cantidad;
            break;
        case "4":
            Console.WriteLine("Cuántas unidades?");
            cantidad = int.Parse(Console.ReadLine());
            saldo += precio_arroz * cantidad;
            break;
        case "5":
            Console.WriteLine("Cuántas unidades?");
            cantidad = int.Parse(Console.ReadLine());
            saldo += precio_jabon * cantidad;
            break;
        case "6":
            Console.WriteLine("Cuántas unidades?");
            cantidad = int.Parse(Console.ReadLine());
            saldo += precio_queso * cantidad;
            break;
        case "7":
            Console.WriteLine("Cuántas unidades?");
            cantidad = int.Parse(Console.ReadLine());
            saldo += precio_aceite * cantidad;
            break;
        case "8":
            Console.WriteLine("Cuántas unidades?");
            cantidad = int.Parse(Console.ReadLine());
            saldo += precio_papel * cantidad;
            break;
        case "9":
            Console.WriteLine("Gracias por su compra");
            repetir = false;
            break;
        default:
            break;
    }
} while (repetir);
double iva = saldo * 0.15;
double pagar = saldo + iva;

Console.WriteLine($"Su total es {pagar} ({saldo} + {iva} IVA).");
