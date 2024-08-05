using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class AdministratorApp
    {
        //Listas 
        public List<Customer> customers { get; set; } = new List<Customer>();
        public List<Driver> drivers { get; set; } = new List<Driver>();
        public List<Vehicle> vehicles { get; set; } = new List<Vehicle>();

        //Constructor para inicializar con datos quemados
        public AdministratorApp()
        {
            customers.Add(new Customer("John", "Doe", "CC", "12345678", DateOnly.Parse("1990-01-01"), "john.doe@example.com", "1234567890", "123 Main St", "Gold", "Credit Card"));
            customers.Add(new Customer("Jane", "Smith", "CC", "87654321", DateOnly.Parse("1985-05-05"), "jane.smith@example.com", "0987654321", "456 Elm St", "Silver", "Debit Card"));
            customers.Add(new Customer("Alice", "Johnson", "TI", "11223344", DateOnly.Parse("2000-10-10"), "alice.johnson@example.com", "1122334455", "789 Oak St", "Bronze", "Cash"));
            customers.Add(new Customer("Bob", "Brown", "CC", "44332211", DateOnly.Parse("1995-03-15"), "bob.brown@example.com", "6677889900", "321 Pine St", "Gold", "Credit Card"));
            customers.Add(new Customer("Carol", "Davis", "TI", "55667788", DateOnly.Parse("1988-07-20"), "carol.davis@example.com", "9988776655", "654 Cedar St", "Silver", "Debit Card"));
        }

        //Metodos para agregar
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void AddDriver(Driver driver)
        {
            drivers.Add(driver);
        }
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        //Metodos para eliminar
        public void RemoveCustomer(Customer customer)
        {
            if (customers.Contains(customer))
            {
                customers.Remove(customer);
            }
            else
            {
                System.Console.WriteLine("Cliente no encontrado.");
            }
        }
        public void RemoveDriver(Driver driver)
        {
            drivers.Remove(driver);
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }

        //Metodos para mostrar 
        public void ShowCustomers()
        {
            foreach (var customer in customers)
            {
                System.Console.WriteLine("----------------------------");
                customer.SetShowDetails();
                System.Console.WriteLine("-----------------------------");
            }
        }
        public void ShowDrivers()
        {
            foreach (var driver in drivers)
            {
                driver.SetShowDetails();
            }
        }
        public void ShowVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.ShowDetails();
            }
        }

        //Metodos para buscar
        public Customer GetCustomerById(Guid id)
        {
            return customers.FirstOrDefault(c => c.GetId() == id);
        }
        public Driver FindDriverById(Guid id)
        {
            return drivers.FirstOrDefault(d => d.GetId() == id);
        }
        public Vehicle FindVehicleById(int id)
        {
            return vehicles.FirstOrDefault(v => v.Id == id);
        }
    }
}