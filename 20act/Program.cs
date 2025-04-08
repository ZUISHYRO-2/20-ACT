// See https://aka.ms/new-console-template for more information

using _20act.Models;
using _20act.allClases;

namespace _20act

{
    abstract class Program
    {
        static void Main()
        {
                    // creamos uns instancia que viene de allClases
                    act1 miClase = new act1();
                    act2 miClase2 = new act2();
                    act3 miClase3 = new act3();
                    act4 miClase4 = new act4();
                    act5 miClase5 = new act5();
                    act6 miClase6 = new act6();
                    Act7 miClase7 = new Act7();
                    Act8 miClase8 = new Act8();
                    Act9 miClase9 = new Act9();
                    Act10 miClase10 = new Act10();
                    Act11 miClase11 = new Act11(); 
                    Act12 miClase12 = new Act12();
                    Act13 miClase13 = new Act13();
                    Act14 miClase14 = new Act14();
                    Act15 miClase15 = new Act15();
                    Act16 miClase16 = new Act16();
                    Act17 miClase17 = new Act17();
                    Act18 miClase18 = new Act18();
                    Act19 miClase19 = new Act19();
                    Act20 miClase20 = new Act20();

                    
                    string? vrd;
        
                    do
                    {
            
                            Console.WriteLine("que actividad vas a probar? [ 1 - 23 ]");
                            int act = Convert.ToInt32(Console.ReadLine());

                            switch (act)
                            {
                                case 1:
                                    // Solicitar al usuario que ingrese un número
                                    Console.WriteLine("Por favor, ingresa un número:");
                                    string? input = Console.ReadLine();

                                    // Validar y convertir el dato ingresado
                                    if (double.TryParse(input, out double numero))
                                    {
                                        // Llamar al método act_1 con el número ingresado
                                        miClase.act_1(numero);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Entrada no válida. Por favor, ingresa un número válido.");
                                    }
                                    break;
                                case 2:
                                    
                                    Console.WriteLine("Ingresa la edad: ");
                                    double num = Convert.ToDouble(Console.ReadLine());

                                    if (num >= 1 && num <= 100)
                                    {
                                        miClase2.act_2(num);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    
                                    break;
                                case 3:
                                    
                                    Console.WriteLine("Ingresa un numero entero: ");
                                    double num2 = Convert.ToDouble(Console.ReadLine());

                                    if (num2 >= 0)
                                    {
                                        miClase3.act_3(num2);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    break;
                                case 4:
                                    
                                    Console.WriteLine(" ingresa el porcentaje (0 - 100)");
                                    double num3 = Convert.ToDouble(Console.ReadLine());

                                    if (num3 > 0)
                                    {
                                        miClase4.act_4(num3);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    
                                    break;
                                case 5:
                                    Console.WriteLine("Ingresa la medida del busto: ");
                                    double num4 = Convert.ToDouble(Console.ReadLine());

                                    if (num4 > 0)
                                    {
                                        miClase5.act_5(num4);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("ingresa tres numeros para determinar cual es el mayor");
                                    Console.WriteLine("Numero 1");

                                    double tng1 = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Numero 2");

                                    double tng2 = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Numero 3");

                                    double tng3 = Convert.ToDouble(Console.ReadLine());
                                    if (tng1 > 0 && tng2 > 0 && tng3 > 0)
                                    {
                                        miClase6.act_6(tng1, tng2, tng3);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    break;
                                case 7:
                                    Console.WriteLine("ingresa un numero del 1 al 7");
                                    int dia = Convert.ToInt32(Console.ReadLine());
                                    
                                    if (dia >= 1 && dia <= 7)
                                    {
                                        miClase7.act_7(dia);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    break;
                                case 8: 
                                    Console.WriteLine("Ingresa el sueldo actual:"); 
                                    double sueldo = Convert.ToDouble(Console.ReadLine());
                                    if (sueldo > 0)
                                    {
                                        miClase8.act_8(sueldo);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    break;
                                case 9:
                                Console.WriteLine("ingrese la longitud de los tres lados ");
                                        Console.WriteLine("longitud 1");
                                        double lado1 = Convert.ToDouble(Console.ReadLine());
                                        
                                        Console.WriteLine("longitud 2");
                                        double lado2 = Convert.ToDouble(Console.ReadLine());
                                        
                                        Console.WriteLine("longitud 3");
                                        double lado3 = Convert.ToDouble(Console.ReadLine());
                                
                                        if (lado1 > 0 && lado2 > 0 && lado3 > 0)
                                        {
                                            miClase9.act_9(lado1, lado2, lado3);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Numero no valido "); 
                                        }
                                break; 
                                case 10:
                                       Console.WriteLine("pide un numero del 1 al 10");
                                       int ent = Convert.ToInt32(Console.ReadLine());

                                       if (ent > 0)
                                       {
                                           miClase10.act_10(ent);
                                       }
                                       else
                                       {
                                           Console.WriteLine("Numero no valido ");
                                       }

                                       break;
                                case 11:
                                     Console.WriteLine("ingresa el primer numero");
                                       int numer = Convert.ToInt32(Console.ReadLine());
                                    
                                       Console.WriteLine("ingresa el segundo numero");
                                       int numero2 = Convert.ToInt32(Console.ReadLine());
                                    
                                       Console.WriteLine("ingresa el operando (+, -, *, /)");
                                       char op = Convert.ToChar(Console.ReadLine() ?? string.Empty);
                                       if (numer > 0 && numero2 >0)
                                       {
                                           miClase11.act_11(op, numer, numero2);
                                       }
                                       else
                                       {
                                           Console.WriteLine("Numero no valido ");
                                       }
                                       break;
                                case 12:
                                    Console.WriteLine("escoje un numero del 1 al 12");
                                      int mes = Convert.ToInt32(Console.ReadLine());

                                    if (mes >= 0 && mes <= 12)
                                    {
                                        miClase12.act_12(mes);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    
                                    break;
                                case 13:
                                       Console.WriteLine("que articulo desea?");
                                       Console.WriteLine("ropa, comida, electronica");
                                       string? nombre = Convert.ToString(Console.ReadLine());

                                       Console.WriteLine("cual es el precio?");
                                       double precio = Convert.ToDouble(Console.ReadLine());
                                       if (nombre != null && precio > 0)
                                       {
                                          miClase13.act_13(nombre, precio);
                                       }
                                       else
                                       {
                                           Console.WriteLine("Numero no valido ");
                                       }

                                       break;
                                case 14:
                                    Console.WriteLine("ingresa la calificacion");
                                    double contador = Convert.ToDouble(Console.ReadLine());
                                    
                                    if (contador >= 0)
                                    {
                                        miClase14.act_14(contador);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }

                                    break;
                                case 15:
                                    Console.WriteLine("Introduce la longitud del lado A:");
                                    double ladoA = Convert.ToDouble(Console.ReadLine());
                                    
                                    Console.WriteLine("Introduce la longitud del lado B:"); 
                                    double ladoB = Convert.ToDouble(Console.ReadLine());
                                    
                                    Console.WriteLine("Introduce la longitud del lado C:"); 
                                    double ladoC = Convert.ToDouble(Console.ReadLine());

                                    if (ladoA > 0 && ladoB > 0 && ladoC > 0)
                                    {
                                        miClase15.act_15(ladoA, ladoB, ladoC);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    
                                    break;
                                case 16:
                                    Console.WriteLine("Introduce un turno (mañana, tarde, noche):");
                                            string? turno = Convert.ToString(Console.ReadLine());

                                    if (!string.IsNullOrEmpty(turno = null))
                                    {
                                        miClase16.act_16(turno);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    break;
                                case 17:
                                    Console.WriteLine("Introduce el número correspondiente al tipo de fruta (1: cítrica, 2: tropical, 3: baya):");
                                    int tipoFruta = Convert.ToInt32(Console.ReadLine());

                                    if (tipoFruta >= 0)
                                    {
                                        miClase17.act_17(tipoFruta);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }

                                    break;
                                case 18:
                                    Console.WriteLine("Introduce el número del mes (1: enero, 2: febrero, ..., 12: diciembre):"); 
                                    double mes1 = Convert.ToDouble(Console.ReadLine());

                                    if (mes1 >= 0)
                                    {
                                        miClase18.act_18(mes1);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }

                                    break;
                                case 19:
                                  Console.WriteLine("Introduce el número del estado del proceso (1: En progreso, 2: Completado, 3: Cancelado):"); 
                                    double estado = Convert.ToDouble(Console.ReadLine());

                                    if (estado >= 0)
                                    {
                                        miClase19.act_19(estado);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Numero no valido ");
                                    }
                                    
                                    break;
                                case 20:
                                                                
                                        Console.WriteLine("Selecciona una opción del menú:");
                                        Console.WriteLine("1: Ver productos");
                                        Console.WriteLine("2: Agregar al carrito");
                                        Console.WriteLine("3: Realizar compra");
                                        Console.WriteLine("4: Salir");

                                        int opcion = Convert.ToInt32(Console.ReadLine());

                                        if (opcion >= 1)
                                        {
                                            miClase20.act_20(opcion);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Numero no valido ");
                                        } 
                                        break;
  
                                
                                default:
                                    Console.WriteLine("Opción no válida.");
                                    break;
                            }
        
                        Console.WriteLine("quieres continuar?");
                        Console.WriteLine("[si/no]");
                        vrd = Convert.ToString(Console.ReadLine()); 
                        
                    } while (vrd == "si");
        }
    }
    
}

