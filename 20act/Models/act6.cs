public class act6
{
    public double num5 { get; set; }


    public void act_6(double _num, double _num2, double _num3)
    {


        if (_num >= _num2 && _num >= _num3)
        {

            Console.WriteLine(" El numero: " + _num + " es mayor a los demas");

        }
        else if (_num2 >= _num && _num2 >= _num3)
        {

            Console.WriteLine("El numero: " + _num2 + " es mayor a los demas");

        }
        else if (_num3 >= _num && _num3 >= _num2)
        {

            Console.WriteLine("El numero: " + _num3 + " es mayor a los demas");

        }
        else
        {

            Console.WriteLine("los numeros son iguales");

        }

    }
}
