using Microsoft.Win32;

namespace práctica
{
    internal class Program
    {
        static void Main()
        {
            int cantidadPersonas = 0;

            while (true)
            {
                try
                {
                    Console.Write("Digite la cantidad de personas que desea registrar: ");
                    string entrada = Console.ReadLine();
                    cantidadPersonas = int.Parse(entrada);

                    if (cantidadPersonas < 1)
                    {
                        Console.WriteLine("\nLa cantidad debe ser mayor o igual a 1!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nDigite un número válido.");
                }
            }

            List<string> nombres = new List<string>();
            List<int> edades = new List<int>();

            
            for (int i = 0; i < cantidadPersonas; i++)
            {
                Console.WriteLine("\nRegistro de la persona " + (i + 1) + ":");
    
            // Nombre de cada persona
            Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);

                //  Edad
                int edad = 0;
                while (true)
                {
                    try
                    {
                        Console.Write("Edad: ");
                        string entradaEdad = Console.ReadLine();
                        edad = int.Parse(entradaEdad);


                        if (edad >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("La edad debe ser un número positivo!!");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debe ingresar un número válido");
                    }
                }

                edades.Add(edad);
            }

            // ista general de personas
            Console.WriteLine("\nLista general de personas: ");
        for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine("Nombre " + (i + 1) + " :" + nombres[i]);
                Console.WriteLine("Edad " + (i + 1) + " :" + edades[i]);
                
            }

            // En caso de qque solo se ingrese una persona
            if (cantidadPersonas == 1)
            {
                Console.WriteLine("Nombre: " + nombres[0]);
                if (edades[0] >= 18)
                {
                    Console.WriteLine("\nEs mayor de edad.");
                }
                else
                {
                    Console.WriteLine("\nEs menor de edad.");
                }
            }
            else if (cantidadPersonas >= 2)
            {
              
                List<string> NombresMayores = new List<string>();
                List<int> EdadesMayores = new List<int>();
                List<string> NombresMenores = new List<string>();
                List<int> EdadesMenores = new List<int>();

                for (int i = 0; i < nombres.Count; i++)
                {
                    if (edades[i] >= 18)
                    {
                        NombresMayores.Add(nombres[i]);
                        EdadesMayores.Add(edades[i]);
                    }
                    else
                    {
                        NombresMenores.Add(nombres[i]);
                        EdadesMenores.Add(edades[i]);
                    }
                }

                //Lista de personas mayores de edad
                if (NombresMayores.Count > 0)
                {
                    Console.WriteLine("\n*Listado de mayores de edad: ");
                    for (int i = 0; i < NombresMayores.Count; i++)
                    {
                        Console.WriteLine(NombresMayores [i] + "-" + EdadesMayores[i]);
                    }
                }

                // Lista de personas menores de edad
                if (NombresMenores.Count > 0)
                {
                    Console.WriteLine("\n*Listado de menores de edad: ");
                    for (int i = 0; i < NombresMenores.Count; i++)
                    {
                        Console.WriteLine(NombresMenores [i] + "-" + EdadesMenores[i]);
                    }
                }
            }
        }
    }
}
