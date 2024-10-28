using System.ComponentModel.Design;

namespace ListaLigada.Logica;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! lista ligada simples");
        Console.WriteLine("");

        var singleList = new SingleList<string>();

        int opcion = 0;
        do
        {
            opcion = Menu();
            switch (opcion) {
                case 1:
                    AgregarElemento();
                    break;
                case 2:
                    MostrarLista();
                    break;
                case 0:
                    break;
                default: 
                    Console.WriteLine("Esta opción no existe");
                    break;
            }
        } while (opcion != 0) ;


                void AgregarElemento()
                {
                    Console.WriteLine("Escribe el nombre del nodo");
                    var data = Console.ReadLine();
                    singleList.Add(data);
                }

                void MostrarLista()
                {
                    Console.WriteLine(singleList);
                }
                Console.ReadKey();
    }//termina main



    private static int Menu()
    {
        Console.WriteLine("Menu\n");
        Console.WriteLine("1. Agregar elemento\n");
        Console.WriteLine("2. Mostrar lista\n");
        Console.WriteLine("0. Salir\n");

        bool esValido = false;
        int opcion = 0;

        do
        {
            Console.WriteLine("Elige una opcion del menú");
            var opcionCapturada = Console.ReadLine();

            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Elige una opción válida");
                esValido = false;
            }
            else
            {
                esValido = true;
            }
        } while (esValido == false);

        return opcion;
    }
}

    

   
