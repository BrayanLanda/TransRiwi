using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class Driver : User
    {
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }

        //Constructor
        public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string licenseNumber, string licenseCategory, int drivingExperience) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
        {
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperience;
        }

        //Metodo para mostrar detalles
        protected override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Número de Licencia: {LicenseNumber}");
            Console.WriteLine($"Categoría de Licencia: {LicenseCategory}");
            Console.WriteLine($"Experiencia en Conducir: {DrivingExperience} años");
        }

        //Metodo para para actualizar la catgoria de la licencia
        public void UpdateLicenseCategory(string newLicenseCategory)
        {
            LicenseCategory = newLicenseCategory;
        }

        //Metodo para add la experienica
        public void AddDrivingExperience(int years)
        {
            DrivingExperience += years;
        }
    }
}