using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfacesProject.Models
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }

        public int CompareTo(Person other)
        {
            ////Sort by Age
            //return Age.CompareTo(other.Age);

            //Sort Name, Age, Sex
            var result = Name.CompareTo(other.Name);
            if (result == 0) result = Age.CompareTo(other.Age);
            if (result == 0) result = IsMale.CompareTo(other.IsMale);

            return result;
        }
    }
}
