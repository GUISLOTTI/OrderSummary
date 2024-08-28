using System;
using System.Collections.Generic;
using System.Text;
using OrderSummary.Entities.Enums;
using OrderSummary.Entities;

namespace OrderSummary.Entities
{
    class Client
    {
        public String Name { get; set; }
        public String Email { get; set; }

        public DateTime BirthDate { get; set; }
        public Client()
        {
        }
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public override String ToString()
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}