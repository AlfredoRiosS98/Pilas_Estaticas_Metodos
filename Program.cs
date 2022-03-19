using System;

namespace Pilas_Estaticas_Metodos
{
    class program
    {
        public static String[] nombre = new String[3];
        public static int top = 0;
        public static void Main(string[] args)
        {
            string op = "";
            int va;

            do
            {
                Console.Clear();

                Console.WriteLine("******************** MENÚ DE OPCIONES - PILAS ESTATICAS ********************");
                Console.WriteLine("\n1. Insertar datos a la pila.");
                Console.WriteLine("2. Eliminar datos de la pila.");
                Console.WriteLine("3. Mostrar datos de las pilas.");
                Console.WriteLine("4. Salir.");

                Console.WriteLine("\nIngresa el valor a elegir:");
                Console.Write("-> ");
                va = Convert.ToInt32(Console.ReadLine());

                switch (va)
                {
                    case 1:
                        insertar();
                        break;
                    case 2:
                        eliminar();
                        break;
                    case 3:
                        mostrar();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("La opción a elegir no existe.");
                        break;
                }

                Console.WriteLine("¿Desea realizar alguna otra acción del menú? Si / No");
                Console.Write("-> ");
                op = Console.ReadLine();
            } while (op != "no");

            Console.WriteLine("Gracias por usar el programa, vuelva pronto.");
        }

        public static void insertar()
        {
            if (top < nombre.Length)
            {
                Console.Clear();

                Console.WriteLine("********** SECCIÓN DE INSERCIÓN DE NOMBRES **********\n");

                for (int i = 0; i <= nombre.Length; i++)
                {
                    Console.WriteLine("Inserta un nombre de un animal." + i);
                    Console.Write("-> ");
                    if (top < nombre.Length)
                    {
                        nombre[top] = Console.ReadLine();
                        top++;
                    }
                    else
                    {
                        Console.WriteLine("La pila esta llena, favor de salir o eliminar un nombre.");
                    }
                }
            }
            else
            {
                Console.WriteLine("La pila esta llena, elimine nombres para poder agregar más");
                Console.WriteLine("Presione la tecla <enter> para continuar.");
                Console.ReadKey();
            }
        }

        public static void eliminar()
        {
            Console.Clear();
            if (top >= 1)
            {
                Console.Clear();

                Console.WriteLine("********** SECCIÓN DE ELIMINACIÓN DE NOMBRES **********\n");

                string otro = "";
                String aux;
                do
                {

                    if (top == -1)
                    {
                        Console.WriteLine("Pila vacía");
                        Console.WriteLine(otro);
                    }
                    else
                    {
                        top--;
                        aux = nombre[top];
                        nombre[top] = "";
                        Console.Write("", aux);
                    }

                    Console.WriteLine("¿Desea eliminar otro nombre? Si / No");
                    Console.Write("-> ");
                    otro = Console.ReadLine();
                } while (otro != "no");
            }
            else
            {
                Console.WriteLine("La pila esta vacia, agregue nombres para poder eliminarlos");
                Console.WriteLine("Presione la tecla <enter> para continuar.");
                Console.ReadKey();
            }
        }

        public static void mostrar()
        {
            if (top >= 1)
            {
                Console.Clear();

                Console.WriteLine("********** SECCIÓN DE MOSTRAR DE nombres **********\n");

                for (int i = top - 1; i >= 0; i--)
                {
                    Console.WriteLine(nombre[i]);
                }
            }
            else
            {
                Console.WriteLine("La pila esta vacia, agregue nombres para poder eliminarlos");
                Console.WriteLine("Presione la tecla <enter> para continuar.");
                Console.ReadKey();
            }
        }
    }
}