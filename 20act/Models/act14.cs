// See https://aka.ms/new-console-template for more information

/*
 * Sistema de Calificaciones:
 * Dado un número del 0 al 10,
 * muestra el nivel de desempeño
 * (0-3: Bajo, 4-7: Medio, 8-10: Alto).
 */
namespace _20act.Models;

public class Act14
{
 public double Num13 { get; set; }
 
 public void act_14(double contador)
 {
  if (contador >= 0 && contador <= 3){
    
   Console.WriteLine("el nivel de desempeño es bajo: ");
    
  }else if (contador >= 4 && contador <= 7) {
    
   Console.WriteLine("el nivel de desempeño es medio: ");
    
  }else if (contador >= 8 && contador <= 10) {
    
   Console.WriteLine("el nivel de desempeño es alta");
    
  }
  else
  {
   Console.WriteLine("ingresa una calificacion valida12");
  }
 }
}