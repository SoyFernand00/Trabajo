using System.Diagnostics.CodeAnalysis;

int nu=0;
double suma = 0;
do
{
    Console.WriteLine("Ingresar tu numero: ");
    nu = int.Parse(Console.ReadLine());
} while (nu != 0);
{
    if (nu == 0)
      suma=suma+nu;
}
Console.WriteLine("La suma es: " +suma);

