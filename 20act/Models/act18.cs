// See https://aka.ms/new-console-template for more information

/*
 * Programa de Reserva:
 * Según el mes indicado (1: enero, 2: febrero, etc.), avisa
 * si hay promociones especiales por el mes.
 */
namespace _20act.Models;

public class Act18
{
    public double Num17 { get; set; }
    public void act_18(double mes1)
    {
        switch (mes1)
        {
            case 1:
                Console.WriteLine("Enero: Promoción especial de Año Nuevo.");
                break;
            case 2:
                Console.WriteLine("Febrero: Promoción de San Valentín.");
                break;
            case 3:
                Console.WriteLine("Marzo: Promoción de primavera.");
                break;
            case 4:
                Console.WriteLine("Abril: Promoción de Pascua.");
                break;
            case 5:
                Console.WriteLine("Mayo: Promoción del Día de las Madres.");
                break;
            case 6:
                Console.WriteLine("Junio: Promoción del Día del Padre.");
                break;
            case 7:
                Console.WriteLine("Julio: Promoción de verano.");
                break;
            case 8:
                Console.WriteLine("Agosto: Promoción de regreso a clases.");
                break;
            case 9:
                Console.WriteLine("Septiembre: Promoción de fiestas patrias.");
                break;
            case 10:
                Console.WriteLine("Octubre: Promoción de Halloween.");
                break;
            case 11:
                Console.WriteLine("Noviembre: Promoción de Día de Muertos.");
                break;
            case 12:
                Console.WriteLine("Diciembre: Promoción de Navidad.");
                break;
            default:
                Console.WriteLine("Mes no reconocido. Por favor, introduce un número del 1 al 12.");
                break;
        }
    }
}