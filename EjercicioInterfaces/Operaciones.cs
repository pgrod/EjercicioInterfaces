namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double AreaCuadrado(double lado)
        {
            return lado * lado;
        }
        public double AreaRectangulo(double largo, double ancho)
        {
            return largo * ancho;
        }
        public double PerimetroCuadrado(double lado)
        {
            return 4 * lado;
        }
        public double PerimetroRectangulo(double largo, double ancho)
        {
            return 2 * (largo + ancho);
        }
        public double VolumenCuadrado(double lado)
        {
            return lado * lado * lado;
        }

        public void Imprimir(double ladoCuadrado, double largoRectangulo, double anchoRectangulo)
        {
            Console.WriteLine("Resultados:");
            Console.WriteLine($"Área del cuadrado: {AreaCuadrado(ladoCuadrado)}");
            Console.WriteLine($"Perimetro del cuadrado: {PerimetroCuadrado(ladoCuadrado)}");
            Console.WriteLine($"Volúmen del Cuadrado: {VolumenCuadrado(ladoCuadrado)}");
            Console.WriteLine($"Área del rectangulo: {AreaRectangulo(largoRectangulo, anchoRectangulo)}");
            Console.WriteLine($"Perimetro del Rectangulo: {PerimetroRectangulo(largoRectangulo, anchoRectangulo)}");
            
        }

        public double VolumeCuadrado(double lado)
        {
            throw new NotImplementedException();
        }
    }
}
