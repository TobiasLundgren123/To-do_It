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

        private static Person[] personArray = new Person[0];

        public Person[] PersonArray
        {
           get { return personArray; }
    set { personArray = value; }
           
        }

        public int Size()
        {
            return personArray.Length;
        }

        public Person[] FindAll()
        {
            //foreach (Person person in personArray)
            //{
            //    Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.id);
            //}
            return personArray;
        }

        public Person FindById(int personId)
        {
            foreach (Person person in personArray)
            {
                if (personId == person.id)
                {
                    return person;
                }
            }
            return null;
        }

        public Person newPerson(String firstName, String lastName)
        {
            Person newPersonToAdd = new Person(firstName, lastName, PersonSequencer.NextPersonId());
            Array.Resize(ref personArray, personArray.Length + 1);
            personArray[personArray.Length - 1] = newPersonToAdd;
            return newPersonToAdd;
        }

        public void Clear()
        {
            personArray = new Person[0];
        }

        public void Remove(Person personRemove)
        {
            Person[] newPersonArray = new Person[0];
            foreach (Person person in personArray)
            {
                if (person.Equals(personRemove))
                {

                }
                else
                {
                    Array.Resize(ref newPersonArray, newPersonArray.Length + 1);
                    newPersonArray[newPersonArray.Length - 1] = person;
                }
            }
            Clear();
            personArray = newPersonArray;
        }

    }
    }

