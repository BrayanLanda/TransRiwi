using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class Vehicle
    {

        private static int _idCounter = 1;
        public int Id { get; private set; }
        public string Placa { get; set; }
        public string Type { get; set; }
        public string EngineNumber { get; set; }
        public string NumberSerial { get; set; }
        public byte PeopleCapacity { get; set; }
        public Customer Owner { get; set; }

        // Constructor para inicializar las propiedades del vehículo
        public Vehicle(int id, string placa, string type, string engineNumber, string numberSerial, byte peopleCapacity, Customer owner)
        {
            Id = id;
            Placa = placa;
            Type = type;
            EngineNumber = engineNumber;
            NumberSerial = numberSerial;
            PeopleCapacity = peopleCapacity;
            Owner = owner;
        }

        public Vehicle()
        {
            Id = _idCounter++;
        }
        // Método para mostrar los detalles del vehículo
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle Details:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Engine Number: {EngineNumber}");
            Console.WriteLine($"Number Serial: {NumberSerial}");
            Console.WriteLine($"People Capacity: {PeopleCapacity}");
            Console.WriteLine($"Owner: {Owner.GetName} {Owner.GetEmail()}");
        }
    }
}