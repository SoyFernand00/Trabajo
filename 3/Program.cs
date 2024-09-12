int nu;
do
{
    Console.WriteLine("Ingresar el numero:" );
    nu = int.Parse(Console.ReadLine());
}while (nu <= 0) ;
int nu1 = 1;
int nu2;
/*Console.WriteLine("Ingresar el numero:");
nu2 = int.Parse(Console.ReadLine());*/
while (nu1 < 13 && nu < 13) 
{
    Console.WriteLine(nu+"x"+nu1+"="+(nu *nu1)); 
    nu1++;
}
Console.WriteLine("Listo!!");
