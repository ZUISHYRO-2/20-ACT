namespace _20act.Models;
public class act5
{
    public double num4 { get; set; }
    public void act_5(double _num)
    {
            
            
            if (_num < 90){

                Console.WriteLine("Tu talla es: S ");

            }else if (_num >= 90 && _num <= 100){

                Console.WriteLine("Tu talla es: M ");

            }else if (_num >= 101 && _num <= 110){

                Console.WriteLine("Tu talla es: L ");

            }else{

                Console.WriteLine("Tu talla es: XL");
                        
            }
            
        
    }

    
}
            


