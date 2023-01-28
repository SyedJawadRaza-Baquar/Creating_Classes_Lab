using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Creating_Classes_Lab
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
            IsWorking = isWorking;
        }

        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FavoriteColour { get => favoriteColour; set => favoriteColour = value; }
        public int Age { get => age; set => age = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        
        public void DisplayPersonInfo ()
        {
            Console.Write(PersonId + ": " + FirstName + " " + LastName + "'s favorite color is " + FavoriteColour + "\n\n");
        }

        public void ChangeFavoriteColor()
        {
            FavoriteColour = "White";
        }

        public void GetAgeInTenYears ()
        {
            int newAge = Age + 10;
            Console.Write(FirstName + " " + LastName + "'s age in 10 years is " + newAge + "\n\n");
        }

        public override string ToString()
        {
            return "personId = " + PersonId + "\n" + "firstName = " + FirstName + "\n" + "lastName = " + LastName + "\n" + "favoriteColor = " + FavoriteColour + "\n" + "age = " + Age + "\n" + "isWorking = " + IsWorking + "\n\n";
        }
    }
}
