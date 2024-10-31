using EjercicioInterfaces;

Operaciones operaciones = new Operaciones();
Console.WriteLine("Ingrese el lado del cuadrado: ");
double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el largo del rectangulo: ");
double largoRectangulo =  Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese ancho del rectaangulo: ");
double anchoRectangulo = Convert.ToDouble(Console.ReadLine());

operaciones.Imprimir(ladoCuadrado, largoRectangulo, anchoRectangulo);