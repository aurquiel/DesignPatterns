using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Prototype
{
    public class Person : IDeepClonable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDateTime { get; set; }
        public Address Address { get; set; }

        public Person(int id, string name, DateTime birthDateTime, Address address)
        {
            Id = id;
            Name = name;
            BirthDateTime = birthDateTime;
            Address = address;
        }

        public Person DeepCopy()
        {
          //return ((IDeepClonable<Person>)this).DeepCopySerilization<Person>(this);    
          return this.DeepCopySerilization<Person>();    
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name:{Name}, Birthdate:{BirthDateTime.ToString()}, Address: {Address.ToString()}";
        }
    }

    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Street: {Street}, HouseNumber: {HouseNumber}";
        }
    }
}
