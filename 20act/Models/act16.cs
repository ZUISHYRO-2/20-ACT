// See https://aka.ms/new-console-template for more information
/*
 * Sistema de Turnos: Un algoritmo que pregunte por un turno (mañana, tarde,
 * noche) y muestra un mensaje diferente según el turno elegido.
 */
namespace _20act.Models;

public class Act16
{
    public double Num15 { get; set; }
    public void act_16(string? turno)
    {
        switch (turno)
        {
            case "mañana":
            Console.WriteLine("Buenos días. ¡Que tengas un día productivo!");
            break;
            case "tarde":
            Console.WriteLine("Buenas tardes. ¡Espero que estés teniendo una tarde genial!");
            break;
            case "noche":
            Console.WriteLine("Buenas noches. ¡Que descanses bien!");
            break;
            default:
            Console.WriteLine("Turno no reconocido. Por favor, introduce 'mañana', 'tarde' o 'noche'.");
            break;
        }
    }
}