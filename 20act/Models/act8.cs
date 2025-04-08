namespace _20act.Models;

public class Act8
{
    public double Num7 { get; set; }
    public void act_8(double sueldo)
    {
        
        if (sueldo < 1000){

            double rest15 = sueldo * 0.15;
            Console.WriteLine("usted tiene el dumento de: " + rest15 + " ya con descuento aplicado");

        } else if (sueldo >= 1000 && sueldo <= 2000 ) {

            double rest10 = sueldo * 0.10;
            Console.WriteLine("Usted tiene que pagar: " + rest10 + " ya con descuento aplicado");

        }else if (sueldo > 2000){

            double rest5 = sueldo * 0.5;
            Console.WriteLine("Usted tiene que pagar: " + rest5 + " Ya con descuento aplicado");

        }
    }
}