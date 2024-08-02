using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransRiwi.Views;

namespace TransRiwi.Controllers
{
    public class MainController
    {
        private readonly MainView _view = new MainView();
        private readonly DriverController _driverController = new DriverController();
        private readonly VehicleController _vehicleController = new VehicleController();
        private readonly CustomerController _customerController = new CustomerController();
        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                int mainOption = _view.ShowMenu();
                switch (mainOption)
                {
                    case 1:
                        _customerController.ManageCustomer();
                        break;
                    /*case 2:
                        ManageCustomers();
                        break;
                    case 3:
                        ManageVehicle();
                        break;
                    case 4:
                        ManageQueries();
                        break;*/
                    case 5:
                        exit = true;
                        break;
                }
            }

            _view.ShowMessage("Gracias por usar el sistema de Gestion Escolar");
        }
    }
}