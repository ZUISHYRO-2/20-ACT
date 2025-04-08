// See https://aka.ms/new-console-template for more information
/*
 * Calculo de Descuentos: Llama a un artículo y su precio, y aplica un descuento
 * según el tipo de producto (1: ropa 20%, 2: comida 10%, 3: electrónica 5%).
 */
namespace _20act.Models;

public class Act13
{
 public double Num12 { get; set; }
 
 public void act_13(string nombre,double precio)
 {
  double desc = 0;

  switch (nombre){
   case "ropa":
    desc = precio * 0.20;
    break;
    
   case "comida":
    desc = precio * 0.10;
    break;
    
   case "electronica":
    desc = precio * 0.05;
    break;
    
   default:
    Console.WriteLine("no esta en el catalogo");
    break;
    
  }
  double descFin = desc - precio;
  Console.WriteLine("su valor total es: " + descFin + "ya con el descuento del: " + desc);
            
 }
}