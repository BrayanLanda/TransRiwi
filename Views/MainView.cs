using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Views
{
    public class MainView
    {
        //Vista principal
        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("==== TransRiwi ====");
            Console.WriteLine("1. Gestionar Clientes");
            Console.WriteLine("2. Gestionar Vehículos");
            Console.WriteLine("3. Gestionar Conductores");
            Console.WriteLine("4. Gestionar Consultas");
            Console.WriteLine("5. Salir");
            Console.Write("Elija una opcion: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 5)
            {
                System.Console.Write("Opcion invalida, intenta de nuevo: ");
            }
            return option;
        }

        //Solicitar un id para editar o eliminar
        public Guid GetIdForAction(string action)
        {
            System.Console.Write($"Ingresa el id del registro a {action}: ");
            Guid id;
            while (!Guid.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Id invalido. Intente de nuevo: ");
            }
            return id;
        }

         public int GetIdIntForAction(string action)
        {
            System.Console.Write($"Ingresa el id del registro a {action}: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Id invalido. Intente de nuevo: ");
            }
            return id;
        }

        //Monstrar mensaje y esperar confirmacion del usuario
        public void ShowMessage(string mensaje)
        {
            System.Console.WriteLine(mensaje);
            System.Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}