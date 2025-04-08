namespace _20act.Models;

public class Act7
{
    public double Num6 { get; set; }
    public void act_7(double num)
    {
            
        string dia;

        switch (num)
        {
            case 1:
                dia = "lunes";
                break;

            case 2:
                dia = "Martes";
                break;

            case 3:
                dia = "Miercoles";
                break;

            case 4:
                dia = "Jueves";
                break;

            case 5:
                dia = "Viernes";
                break;

            case 6:
                dia = "Sabado";
                break;

            case 7:
                dia = "Domingo";
                break;

            default:
                dia = "este no es un dia selecione del 1 al 7";
                break;
        }
    }
}