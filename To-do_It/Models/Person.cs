using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_It.Models
{
    internal class Person
    {

        private readonly int Id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            if (string.IsNullOrEmpty(firstName)) {
                throw new ArgumentNullException();
            } else {
                this.firstName = firstName;
                    }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.lastName = lastName;
            }

        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

    }
}
