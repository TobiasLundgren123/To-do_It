using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Data;

namespace To_do_It.Models
{
    internal class Person
    {

        private readonly int personId;
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName, int personId)
        {
            this.personId = personId;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException("First name can't be null or empty");
            }
            else
            {
                this.firstName = firstName;
                
                }

                if (string.IsNullOrEmpty(lastName))
                {
                    throw new ArgumentNullException("Last name can't be null or empty"); ;
                }
                else
                {
                    this.lastName = lastName;
                }

            }
        

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name can't be null or empty");
                }
                else
                {
                    firstName = value;

                }

            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can't be null or empty"); ;
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public int id 
        {
            get
            {
                return personId;
            }
        }

        //public override string? ToString()
        //{
        //    return base.ToString();
        //}
    }
}
