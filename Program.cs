int num;

do {
    Console.WriteLine("Ingrese un numero");
    num = int.Parse(Console.ReadLine());
} while (num < 1 || num > 5);