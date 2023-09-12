using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema
{
    public class Customer
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public bool Isreducted { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Customer() { }
        public Customer(string name, string surname, bool isreducted)
        {
            Name = name;
            Surname = surname;
            Isreducted = isreducted;
            PurchaseDate = new DateTime();
        }
    }
}