// See https://aka.ms/new-console-template for more information
/*
 * Valor de Entrada:
 * Pide un número del 1 al 10 y muestra "Dentro del rango" si el
 * número es válido, o "Fuera del rango" si no lo es.
 */
namespace _20act.Models;

public class Act10
{
 
            
    public double Num9 { get; set; }
    public void act_10(double numero)
    {
        if (numero >= 1 && numero <= 10){
     
            Console.WriteLine("Dentro del rango ");
     
        }else{
     
            Console.WriteLine("Fuera del rango");
     
        }
    }
  
}