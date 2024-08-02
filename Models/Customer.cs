using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models
{
    public class Customer : User
    {
        public string MembershipLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }

        //Constructor
        public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string membershipLevel, string preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
        {
            MembershipLevel = membershipLevel;
            PreferredPaymentMethod = preferredPaymentMethod;
        }

        //Metodo para mostrar detalles
        protected override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Nivel de Membresía: {MembershipLevel}");
            Console.WriteLine($"Método de Pago Preferido: {PreferredPaymentMethod}");
        }

        //Metodo para actualizar el nivel de afilacion
        public void UpdateMembershipLevel(string newMembershipLevel)
        {
            MembershipLevel = newMembershipLevel;
        }
    }
}