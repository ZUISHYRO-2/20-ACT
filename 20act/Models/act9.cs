namespace _20act.Models;

public class Act9
{
    public double Num8 { get; set; }
    public void act_9(double lado1, double lado2, double lado3)
    {
        
        bool esTriangulo = (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);

        if (esTriangulo)
        {
            Console.WriteLine("¡Sí, estas longitudes forman un triángulo válido!");
        }
        else
        {
            Console.WriteLine("No es posible formar un triángulo con estas longitudes.");
        }
    }
}