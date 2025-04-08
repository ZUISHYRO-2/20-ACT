// See https://aka.ms/new-console-template for more information

/*
 * Estado de un Proceso: Dado el número de un estado (1: En progreso, 2:
 * Completado, 3: Cancelado), muestra el mensaje correspondiente.
 */
namespace _20act.Models;

public class Act19
{
    public double Num18 { get; set; }
    public void act_19(double estado)
    {
        
        switch (estado)
        {
            case 1:
                Console.WriteLine("El paquete está en progreso.");
                break;
            case 2:
                Console.WriteLine("El paquete ha sido completado.");
                break;
            case 3:
                Console.WriteLine("El paquete ha sido cancelado.");
                break;
            default:
                Console.WriteLine("El paquete no existe.");
                break;
        }
    }
              
}