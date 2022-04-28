using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Fathername;
        public string Country;
        public string City;
        public string Postalcode;
        public Adres Address;


     
        public string GetAddress()
        {
            return $"{Address.Country} {Address.City} {Address.Postalcode}";
        }
        public Student(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;

        }
    }
}
