using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransRiwi.Models;
using TransRiwi.Views;

namespace TransRiwi.Controllers
{
    public class CustomerController
    {
        MainView mainView = new MainView();
        CustomerView customerView = new CustomerView();
        AdministratorApp _app = new AdministratorApp();

        public void ManageCustomer()
        {
            bool back = false;
            while (!back)
            {
                int option = customerView.ShowCustomerMenu();

                switch (option)
                {
                    case 1:
                        ShowCustomers();
                        break;
                    case 2:
                        AddCustomer();
                        break;
                    case 3:
                        DeleteCustomer();
                        break;
                    case 4:
                        SearchCustomer();
                        break;
                    case 5:
                        EditCustomer();
                        break;
                    case 6:
                        back = true;
                        break;
                    default:
                        mainView.ShowMessage("Opcion invalida.");
                        break;
                }
            }
        }
        //Mostrar todos los clientes
        private void ShowCustomers()
        {
            System.Console.WriteLine("------------------------");
            _app.ShowCustomers();
            mainView.ShowMessage("--------------------------");

        }

        //Agregar un nuevo cliente
        private void AddCustomer()
        {
            Customer customer = customerView.GetCustomerInfo();
            _app.AddCustomer(customer);
            System.Console.WriteLine("------------------------");
            mainView.ShowMessage("Cliente agregado exitosamente.");
        }

        // Método para eliminar un cliente
        private void DeleteCustomer()
        {
            Guid id = mainView.GetIdForAction("eliminar");
            Customer customer = _app.GetCustomerById(id); // Usar el método de AdministradorApp para obtener el cliente

            if (customer != null)
            {
                _app.RemoveCustomer(customer); // Usar el método de AdministradorApp para eliminar el cliente
                mainView.ShowMessage("Cliente eliminado exitosamente.");
            }
            else
            {
                mainView.ShowMessage("Cliente no encontrado.");
            }
        }

        // Buscar un cliente por id
        private void SearchCustomer()
        {
            Guid id = mainView.GetIdForAction("Buscar");
            Customer customer = _app.GetCustomerById(id); // Usar el método de AdministradorApp para obtener el cliente

            if (customer != null)
            {
                System.Console.WriteLine($"Cliente encontrado: {customer.GetName()} {customer.GetLastName()}");
                System.Console.WriteLine($"Documentyo: {customer.GetTypeDocument()}-{customer.GetIdentificationNumber()}");
                System.Console.WriteLine($"Cliente encontrado: {customer.GetEmail()}");
                System.Console.WriteLine($"Cliente encontrado: {customer.GetPhoneNumber()}");
                System.Console.WriteLine("Cliente Encontrado con exito");
            }
            else
            {
                mainView.ShowMessage("Cliente no encontrado.");
            }
        }

        // Editar un cliente
        private void EditCustomer()
        {
            Guid id = mainView.GetIdForAction("Editar");
            Customer customer = _app.GetCustomerById(id); // Usar el método de AdministradorApp para obtener el cliente
            if (customer != null)
            {
                customerView.GetCustomerInfo(customer);
                mainView.ShowMessage("Cliente Actualizado con exito");
            }
            else
            {
                mainView.ShowMessage("Cliente no encontrado");
            }
        }
    }
}