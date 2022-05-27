double a, b, dividendo, divisor, resto;

Console.Clear();

Console.WriteLine("--- Máximo divisor comum ---\n");

Console.Write("Digite o primeiro número (a): ");
a = dividendo = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo número (b): ");
b = divisor = Convert.ToDouble(Console.ReadLine());

do
{
    resto = dividendo % divisor;
    dividendo = divisor;
    divisor = resto;
} 
while (resto != 0);

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nMDC({a}, {b}) = {dividendo}");
Console.ResetColor();

Console.Write("\nPressione uma tecla para finalizar... ");
Console.ReadKey(); 
Console.Clear();
