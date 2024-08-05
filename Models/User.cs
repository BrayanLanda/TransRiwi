using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class User
    {
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string TypeDocument { get; set; }
        protected string IdentificationNumber { get; set; }
        protected DateOnly BirthDate { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Address { get; set; }

        //Constructor protegido
        protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            IdentificationNumber = identificationNumber;
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        //Metodo para mostrar detalles
        protected virtual void ShowDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Apellido: {LastName}");
            Console.WriteLine($"Tipo de Documento: {TypeDocument}");
            Console.WriteLine($"Número de Identificación: {IdentificationNumber}");
            Console.WriteLine($"Fecha de Nacimiento: {BirthDate}");
            System.Console.WriteLine($"Edad: {CalculateAge()} años");
            Console.WriteLine($"Correo Electrónico: {Email}");
            Console.WriteLine($"Número de Teléfono: {PhoneNumber}");
            Console.WriteLine($"Dirección: {Address}");
        }

        //Metodo para mostrar los dellates en las demas clases
        public virtual void SetShowDetails()
        {
            ShowDetails();
        }

        //Metodo para calcular la edad y mostrarla
        protected int CalculateAge()
        {
            int age = DateTime.Today.Year - BirthDate.Year;
            if (DateTime.Today.Month < BirthDate.Month || (DateTime.Today.Month == BirthDate.Month && DateTime.Today.Day < BirthDate.Day))
            {
                age--;
            }
            return age;
        }
        public int GetAge()
        {
            return CalculateAge();
        }
        public void SetAge()
        {
            CalculateAge();
        }

        //Getting and setting
        public Guid GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetTypeDocument()
        {
            return TypeDocument;
        }
        public string GetIdentificationNumber()
        {
            return IdentificationNumber;
        }
        public DateOnly GetBirthDate()
        {
            return BirthDate;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
        public void SetTypeDocument(string typeDocument)
        {
            TypeDocument = typeDocument;
        }
        public void SetIdentificationNumber(string identificationNumber)
        {
            IdentificationNumber = identificationNumber;
        }
        public void SetBirthDate(DateOnly birthDate)
        {
            BirthDate = birthDate;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }
        
    }
}