using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab2
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string Gender;

        public Person(string firstName, string lastName, DateTime dateOfBirth, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Person personObj))
                return false;

            if (FirstName == personObj.FirstName && 
                LastName == personObj.LastName && 
                DateOfBirth == personObj.DateOfBirth && 
                Gender == personObj.Gender)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() 
                   + LastName.GetHashCode()
                   + DateOfBirth.GetHashCode()
                   + Gender.GetHashCode();
        }
    }
}
