namespace _20act.Models;

public class act2
{
    public double num { get; set; }
        public void act_2(double _num)
        {
            
            if (_num >= 65)
            {

                Console.WriteLine("Usted es un anciano.");

            }
            else if (_num >= 20 && _num <= 64)
            {

                Console.WriteLine("Usted es un adulto.");

            }
            else if (_num >= 13 && _num <= 19)
            {

                Console.WriteLine("usted es un adolecente.");

            }
            else
            {

                Console.WriteLine("usted es un niño.");

            }
           
          
        }

    }
