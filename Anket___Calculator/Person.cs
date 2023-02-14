using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket___Calculator
{
    public class Person
    {
        public Person() { }
        public Person(string name, string surname, string fatherName, string country, string city, string phone, DateTime date, string gender)
        {
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            Country = country;
            City = city;
            Phone = phone;
            Date = date;
            Gender = gender;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FatherName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public DateTime Date { get; set; }

        public string Gender { get; set; }

    }
}
