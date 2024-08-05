using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransRiwi.Models;
using TransRiwi.Views;

namespace TransRiwi.Controllers
{
    public class VehicleController
    {
        MainView mainView = new MainView();
        VehicleView vehicleView = new VehicleView();
        AdministratorApp _app = new AdministratorApp();

        public void ManageVehicles()
        {
            bool back = false;
            while (!back)
            {
                int option = vehicleView.ShowVehicleMenu();

                switch (option)
                {
                    case 1:
                        ShowVehicles();
                        break;
                    case 2:
                        AddVehicle();
                        break;
                    case 3:
                        DeleteVehicle();
                        break;
                    case 4:
                        SearchVehicle();
                        break;
                    case 5:
                        EditVehicle();
                        break;
                    case 6:
                        back = true;
                        break;
                    default:
                        mainView.ShowMessage("Opción inválida.");
                        break;
                }
            }
        }

        // Mostrar todos los vehículos
        private void ShowVehicles()
        {
            Console.WriteLine("------------------------");
            _app.ShowVehicles();
            mainView.ShowMessage("--------------------------");
        }

        // Agregar un nuevo vehículo
       private void AddVehicle()
        {
            List<Customer> customers = _app.ShowCustomers();
            Vehicle vehicle = vehicleView.GetCustomerInfo();
            _app.AddVehicle(vehicle);
            System.Console.WriteLine("------------------------");
            mainView.ShowMessage("Vehiculo agregado exitosamente.");
        }

        // Método para eliminar un vehículo
        private void DeleteVehicle()
        {
            int id = mainView.GetIdIntForAction("eliminar");
            Vehicle vehicle = _app.FindVehicleById(id); // Usar el método de AdministradorApp para obtener el vehículo

            if (vehicle != null)
            {
                _app.RemoveVehicle(vehicle); // Usar el método de AdministradorApp para eliminar el vehículo
                mainView.ShowMessage("Vehículo eliminado exitosamente.");
            }
            else
            {
                mainView.ShowMessage("Vehículo no encontrado.");
            }
        }

        // Buscar un vehículo por id
        private void SearchVehicle()
        {
            int id = mainView.GetIdIntForAction("Buscar");
            Vehicle vehicle = _app.FindVehicleById(id); // Usar el método de AdministradorApp para obtener el vehículo

            if (vehicle != null)
            {
                vehicle.ShowDetails();
                mainView.ShowMessage("Vehículo encontrado con éxito.");
            }
            else
            {
                mainView.ShowMessage("Vehículo no encontrado.");
            }
        }

        // Editar un vehículo
        private void EditVehicle()
        {
            int id = mainView.GetIdIntForAction("Editar");
            Vehicle vehicle = _app.FindVehicleById(id); // Usar el método de AdministradorApp para obtener el vehículo
            if (vehicle != null)
            {
                Customer owner = vehicle.Owner;
                vehicleView.GetVehicleInfo(owner, vehicle);
                mainView.ShowMessage("Vehículo actualizado con éxito.");
            }
            else
            {
                mainView.ShowMessage("Vehículo no encontrado.");
            }
        }
    }
}