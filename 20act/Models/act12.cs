// See https://aka.ms/new-console-template for more information
/*
 * Mes del Año:
 * Dado un número del 1 al 12, muestra el nombre del mes
 * correspondiente.
 */

namespace _20act.Models;

public class Act12
{
 public double Num11 { get; set; }
 
 public void act_12(double mes)
 {
  
   switch (mes){
   case 1:
   Console.WriteLine("es enero");
   break;
     
   case 2:
   Console.WriteLine("es febrero");
   break;
     
   case 3:
   Console.WriteLine("es marzo");
   break;
     
   case 4:
   Console.WriteLine("es abril");
   break;
     
   case 5:
   Console.WriteLine("es mayo");
   break;
     
   case 6:
   Console.WriteLine("es junio");
   break;
     
   case 7:
   Console.WriteLine("es julio");
   break;
     
   case 8:
   Console.WriteLine("es agosto");
   break;
     
   case 9:
   Console.WriteLine("es septembre"); 
   break;
     
   case 10:
   Console.WriteLine("es octubre");
   break;
     
   case 11:
   Console.WriteLine("es novembre");
   break;
     
   case 12:
   Console.WriteLine("es diciembre");
   break;
     
   default:
   Console.WriteLine("no corresponde a ningun mes");
   break;
     
  }
 }
}