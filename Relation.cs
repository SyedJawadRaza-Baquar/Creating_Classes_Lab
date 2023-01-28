using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Classes_Lab
{
    internal class Relation
    {
        private string person1Relation;
        private Person person1;

        private string person2Relation;
        private Person person2;

        public string Person1relation { get { return person1Relation; } }
        public string Person2relation { get { return person2Relation; } }

        public Relation(string person1Relation, Person person1, string person2Relation, Person person2)
        {
            this.person1Relation = person1Relation;
            this.person1 = person1;
            this.person2Relation = person2Relation;
            this.person2 = person2;
        }

        public override string ToString()
        {
            string formatted;

            formatted = person1.FirstName + " is a " + person1Relation + "\n";
            formatted += person2.FirstName + " is a " + person2Relation + "\n";

            return formatted;
        }
    }
}
