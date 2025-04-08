// See https://aka.ms/new-console-template for more information
/*
 * Operador Aritmético:
 * Escribe un algoritmo que solicite dos números y un
 * operador (+, -, *, /) y realice la operación correspondiente.
 */
namespace _20act.Models;

public class Act11
{
 public double Num10 { get; set; }
 public void act_11(double op, double numer, double numero2)
 {
  
   double resultado = 0;

    switch (op)
   {
    case '+':
    resultado = numer + numero2;
    break;
      
    case '-':
    resultado = numer - numero2;
    break;
      
    case '*':
    resultado = numer * numero2;
    break;
      
    case '/':
    resultado = numer / numero2;
    break;
      
    default:
    Console.WriteLine(" invalido ");
    break;
   }
   Console.WriteLine("el resultado es:" + resultado);
              
     
 }
}