// See https://aka.ms/new-console-template for more information

/*
 * Tipo de Triángulo:
 * Con los lados de un triángulo, determina si es equilátero, isósceles o escaleno.
 * Para clasificar un triángulo en equilátero, isósceles o escaleno, se pueden seguir
 * las siguientes definiciones:
 * 1. Equilátero: Todos los lados son de igual longitud.
 * 2. Isósceles: Dos lados son de igual longitud y uno diferente.
 * 3. Escaleno: Todos los lados son de diferente longitud.
 */
namespace _20act.Models;

public class Act15
{

    public double Num14 { get; set; }
    public void act_15(double ladoA, double ladoB, double ladoC)
    {
            
        if (ladoA == ladoB && ladoB == ladoC)
        {
            Console.WriteLine("Equilátero");
        }
        else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
        {
            Console.WriteLine("Isósceles");
        }
        else
        {
            Console.WriteLine("Escaleno");
        }
    }            
            
           
}