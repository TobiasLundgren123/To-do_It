using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Models;

namespace To_do_It.Data
{
    internal class PeopleService
    {
        
            private static Person[] persons;

        public PeopleService()
        {
            Person[] persons = new Person[0] { };
           
        }

        public int Size()
        {
            return persons.Length;
        }

        public Person[] FindAll()
        {
            return persons;
        }

        //public Person FindById(int personId)
        //{
        //    int foundid = Person

        //    return Person[personId];
        //}

        public Person newPerson(String firstName, String lastName)
        {
            Person newPersonToAdd = new Person(firstName, lastName);
            persons.AddtoList(newPersonToAdd);
                return newPersonToAdd;
        }


    }
    }

