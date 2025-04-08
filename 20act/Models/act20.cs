// See https://aka.ms/new-console-template for more information

/*Selección de Menú Simple: Crea un menú donde las opciones son: 1: Ver
 productos, 2: Agregar al carrito, 3: Realizar compra, y actúa según la selección.
 */
namespace _20act.Models;

public class Act20
{
    public double Num19 { get; set; }
    public void act_20(double opcion)
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Mostrando productos...");
                   
                break;
            case 2:
                Console.WriteLine("Agregando producto al carrito...");
                    
                break;
            case 3:
                Console.WriteLine("Realizando compra...");
                    
                break;
            case 4:
                Console.WriteLine("Saliendo del menú...");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, selecciona una opción del 1 al 4.");
                break;
        }
    }
            
}