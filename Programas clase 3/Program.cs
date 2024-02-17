int numero = int.Parse("5");
if (numero < 0 )
{
    Console.WriteLine("El numero es negativo");
}
else if(numero > 0 )
{
    Console.WriteLine("El numero es positivo");
}
else
{
    Console.WriteLine("El numero es 0");
}

int edad = int.Parse("18");
if (edad <= 18)
{
    Console.WriteLine("Entre");
}
else
{
    Console.WriteLine("NO PUEDE ENTRAR");
}

Console.Write("Ingrese su año de nacimiento: ");
int año = int.Parse(Console.ReadLine());
if(año >= 1928 && año <= 1945)
{
    Console.WriteLine("Usted pertenece a la generacion silenciosa");
}
else if(año >= 1946 && año  <=1964)
{
    Console.WriteLine("Usted pertenece a la generacion de los baby boomer");
}
else if (año >= 1965 && año <= 1980)
{
    Console.WriteLine("Usted pertenece a la generacion X");
}
else if (año >= 1981 && año <= 1996)
{
    Console.WriteLine("Usted pertenece a la generacion de los millennial");
}
else if (año >= 1997 && año <= 2012)
{
    Console.WriteLine("Usted pertenece a la generacion Z");
}
else if (año >= 2013)
{
    Console.WriteLine("Usted pertenece a la generacion Alfa");
}
else
{
    Console.WriteLine("Año invalido");   
}

switch(año)
{
    case >= 1928 and <= 1945: 
    Console.WriteLine("Usted pertenece a la generacion silenciosa");
        break;
    case >= 1946 and <= 1964:
    Console.WriteLine("Usted pertenece a la generacion de los baby boomer");
        break;
    case >= 1965 and <= 1980:
    Console.WriteLine("Usted pertenece a la generacion X");
        break;
    case >= 1981 and 1996:
    Console.WriteLine("Usted pertenece a la generacion de los millennial");
        break;
    case >= 1997 and <= 2012:
    Console.WriteLine("Usted pertenece a la generacion Z");
        break;
    case >= 2013:
    Console.WriteLine("Usted pertenece a la generacion Alfa");
        break;
    default: Console.WriteLine("Año invalido");
        break;
}

string nombre, pais;
int edad1;
char genero;

Console.Write("Ingrese nombre: ");
nombre = Console.ReadLine().ToUpper();
Console.Write("Ingrese país: ");
pais = Console.ReadLine().ToUpper();
Console.Write("Ingrese su edad: ");
edad1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese genero (m o f): ");
genero = char.Parse(Console.ReadLine().ToLower());

if (!nombre.StartsWith("A") && (edad1 >= 18 || genero == 'f')
    && (pais == "GUATEMALA" || pais == "MEXICO"))
{ 
    Console.WriteLine("Ud. Cumple con los requisitos");
}
else
{
    Console.WriteLine("No admitdo");
}

