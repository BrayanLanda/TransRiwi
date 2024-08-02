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

        // //Metodos para editar
        // public void EditCustomer(Customer customer)
        // {
        //     if (customers.Contains(customer))
        //     {
        //         customers.Remove(customer);
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Cliente no encontrado.");
        //     }
        // }

        //Metodos para mostrar 
        public void ShowCustomers()
        {
            foreach (var customer in customers)
            {
                customer.SetShowDetails();
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
                //vehicle.SetShowDetails();
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
        // public Vehicle FindVehicleById(Guid id)
        // {
        //     return//vehicles.FirstOrDefault(v => v.GetId() == id);
        // }
    }
}