using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransRiwi.Models;
using TransRiwi.Validations;

namespace TransRiwi.Views
{
    public class CustomerView
    {
        public int ShowCustomerMenu()
        {
            Console.Clear();
            Console.WriteLine("==== Clientes ====");
            Console.WriteLine("1. Mostrar clientes");
            Console.WriteLine("2. Agregar cliente");
            Console.WriteLine("3. Eliminar cliente");
            Console.WriteLine("4. Buscar cliente");
            Console.WriteLine("5. Editar cliente");
            Console.WriteLine("6. Volver al menú principal");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 6)
            {
                System.Console.Write("Opcion invalida, Intenta de nuevo: ");
            }
            return option;
        }

        //Metodo para agregar o editar un cliente
        public Customer GetCustomerInfo(Customer customer = null)
        {
            Console.Clear();
            System.Console.WriteLine(customer == null ? "==== Agregar un nuevo customer ====" : "==== Editar un customer ====");

            string name;
            do
            {
                System.Console.Write("Nombre: ");
                name = Console.ReadLine().Trim();
                if (!InpuyValidator.IsAlphabetic(name))
                {
                    System.Console.WriteLine("Nombre inválido. Solo se permiten letras y espacios.");
                }
            } while (!InpuyValidator.IsAlphabetic(name));

            string lastName;
            do
            {
                System.Console.Write("Apellido: ");
                lastName = Console.ReadLine().Trim();
                if (!InpuyValidator.IsAlphabetic(lastName))
                {
                    System.Console.WriteLine("Apellido inválido. Solo se permiten letras y espacios.");
                }
            } while (!InpuyValidator.IsAlphabetic(lastName));

            string documentType;
            do
            {
                System.Console.Write("Tipo de Documento (CC/TI): ");
                documentType = Console.ReadLine().Trim().ToUpper();
                if (documentType != "CC" && documentType != "TI") System.Console.WriteLine("Tipo de documento invalido. Intente de nuevo.");
            } while (documentType != "CC" && documentType != "TI");

            string documentNumber;
            do
            {
                System.Console.Write("Numero de Documento: ");
                documentNumber = Console.ReadLine().Trim();
                if (!InpuyValidator.IsNumeric(documentNumber))
                {
                    System.Console.WriteLine("Número de documento inválido. Solo se permiten números.");
                }
            } while (!InpuyValidator.IsNumeric(documentNumber));

            System.Console.Write("Fecha de Nacimiento (YYYY-MM-DD): ");
            DateOnly hireDate;
            while (!DateOnly.TryParse(Console.ReadLine(), out hireDate))
            {
                System.Console.Write("Formato invalido. Intente de nuevo (YYYY-MM-DD): ");
            }

            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            string phone;
            do
            {
                System.Console.Write("Numero de Telefono: ");
                phone = Console.ReadLine().Trim();
                if (!InpuyValidator.IsNumeric(phone))
                {
                    System.Console.WriteLine("Número de telefono inválido. Solo se permiten números.");
                }
            } while (!InpuyValidator.IsNumeric(phone));

            System.Console.Write("Direccion: ");
            string address = Console.ReadLine();

            System.Console.Write("Nivel de afilacion: ");
            string membershipLevel = Console.ReadLine();

            System.Console.Write("Metodo preferido de pago: ");
            string preferredPaymentMethod = Console.ReadLine();

            if (customer == null)
            {
                return new Customer(name, lastName, documentType, documentNumber, hireDate, email, phone, address, membershipLevel, preferredPaymentMethod);
            }
            else
            {
                //Actualizar datos del customer existente
                customer.SetName(name);
                customer.SetLastName(lastName);
                customer.SetTypeDocument(documentType);
                customer.SetIdentificationNumber(documentNumber);
                customer.SetEmail(email);
                customer.SetPhoneNumber(phone);
                customer.SetAddress(address);
                customer.MembershipLevel = membershipLevel;
                customer.PreferredPaymentMethod = preferredPaymentMethod;

                return customer;
            }
        }
    }
}