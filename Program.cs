using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Classes_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);

           Person person2 = new Person(2, "Gina", "James", "Green", 18, false);

           Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);

           Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            person2.DisplayPersonInfo();

            Console.Write(person3.ToString());

            person1.ChangeFavoriteColor();

            person1.DisplayPersonInfo();

            person4.GetAgeInTenYears();

            Relation relation1 = new Relation("Sister", person2, "Sister", person4);
            Relation relation2 = new Relation("Brother", person1, "Brother", person3);

            Console.Write(relation1.ToString());
            Console.Write(relation2.ToString());

            List<Person> list = new List<Person>();

            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            list.Add(person4);

            int totalAge = 0;
            for (int i=0; i< list.Count; i++)
            {
               totalAge += list[i].Age;
            }
            double averageAge = (double) totalAge / list.Count;
            Console.Write("The average age of the people is " + averageAge + "\n\n");

            int minimumAge = list[0].Age;
            int maximumAge = list[0].Age;
            String youngestPerson = "";
            String oldestPerson = "";
            for (int i=0; i< list.Count; i++)
            {
                if (list[i].Age < minimumAge)
                {
                    minimumAge = list[i].Age;
                    youngestPerson = list[i].FirstName;
                }
                if (list[i].Age > maximumAge)
                {
                    maximumAge = list[i].Age;
                    oldestPerson = list[i].FirstName;
                }
            }
            Console.Write("The youngest person is " + youngestPerson + "\n\n");
            Console.Write("The oldest person is " +oldestPerson + "\n\n");

            for (int i=0; i < list.Count; i++)
            {
                if (list[i].FirstName[0] == 'M')
                {
                    Console.Write(list[i].ToString());
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FavoriteColour == "Blue")
                {
                    Console.Write(list[i].ToString());
                }
            }
        }
    }
}
