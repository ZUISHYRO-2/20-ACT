namespace _20act.Models;

public class act1
{
    public double num { get; set; }

    public void act_1(double _num)
    {
        this.num = _num;

        if (num > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (num < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es cero.");
        }
    }
}
