// See https://aka.ms/new-console-template for more information
public class Act17
{
    public double num16 { get; set; }
    public void act_17(double tipoFruta)
    {
            switch (tipoFruta)
            {
                case 1:
                    Console.WriteLine("Fruta cítrica: Rica en vitamina C y con un sabor ácido.");
                    break;
                case 2:
                    Console.WriteLine("Fruta tropical: Exótica y jugosa, perfecta para climas cálidos.");
                    break;
                case 3:
                    Console.WriteLine("Fruta baya: Pequeña y jugosa, a menudo dulce.");
                    break;
                default:
                    Console.WriteLine("Tipo de fruta no reconocido. Por favor, introduce 1, 2 o 3.");
                    break;
            }
    }
}


