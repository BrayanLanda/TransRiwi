using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransRiwi.Models;
using TransRiwi.Validations;

namespace TransRiwi.Views
{
    public class VehicleView
    {
        public int ShowVehicleMenu()
        {
            Console.Clear();
            Console.WriteLine("==== Vehículos ====");
            Console.WriteLine("1. Mostrar vehículos");
            Console.WriteLine("2. Agregar vehículo");
            Console.WriteLine("3. Eliminar vehículo");
            Console.WriteLine("4. Buscar vehículo");
            Console.WriteLine("5. Editar vehículo");
            Console.WriteLine("6. Volver al menú principal");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 6)
            {
                Console.Write("Opción inválida. Intenta de nuevo: ");
            }
            return option;
        }

        // Método para agregar o editar un vehículo
        public Vehicle GetVehicleInfo(List<Customer> customers, Vehicle vehicle = null)
        {
            Console.Clear();
            System.Console.WriteLine(vehicle == null ? "==== Agregar un nuevo Vehiculo ====" : "==== Editar un Vehiculo ====");

            string placa;
            do
            {
                Console.Write("Placa: ");
                placa = Console.ReadLine().Trim();
                if (!InpuyValidator.IsAlphabetic(placa))
                {
                    Console.WriteLine("Placa inválida. Intenta de nuevo.");
                }
            } while (string.IsNullOrEmpty(placa));

            string type;
            byte peopleCapacity = 0;
            do
            {
                Console.Write("Tipo de Vehículo (MOTO/CARRO/BUS): ");
                type = Console.ReadLine().Trim().ToUpper();
                if (type == "MOTO")
                {
                    peopleCapacity = 2;
                }
                else if (type == "CARRO")
                {
                    peopleCapacity = 5;
                }
                else if (type == "BUS")
                {
                    peopleCapacity = 50;
                }
                else
                {
                    Console.WriteLine("Tipo de vehículo inválido. Intenta de nuevo.");
                }
            } while (type != "MOTO" && type != "CARRO" && type != "BUS");

            Console.Write("Número de Motor: ");
            string engineNumber = Console.ReadLine().Trim();

            Console.Write("Número de Serie: ");
            string numberSerial = Console.ReadLine().Trim();

            Customer owner = GetCustomerByName(customers);
            if (owner == null)
            {
                Console.WriteLine("Cliente no encontrado. Cancelando operación.");
                return null;
            }

            if (vehicle == null)
            {
                return new Vehicle
                (
                    placa,
                    type,
                    engineNumber,
                    numberSerial,
                    peopleCapacity,
                    owner
                );
            }
            else
            {
                vehicle.Placa = placa;
                vehicle.Type = type;
                vehicle.EngineNumber = engineNumber;
                vehicle.NumberSerial = numberSerial;
                vehicle.PeopleCapacity = peopleCapacity;
                vehicle.Owner = owner;

                return vehicle;
            }
        }

        // Método para obtener el cliente por nombre
        private Customer GetCustomerByName(List<Customer> customers)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string customerName = Console.ReadLine().Trim();

            return customers.FirstOrDefault(c => string.Equals(c.GetName(), customerName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
