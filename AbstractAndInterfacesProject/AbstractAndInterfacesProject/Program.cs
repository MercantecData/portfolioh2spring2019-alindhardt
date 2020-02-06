using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfacesProject
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var triangle = new Models.Triangle();
            //Abstract method from Shape.cs
            triangle.Draw();

            //Abstract method from ICopyAndPastetable.cs
            triangle.Copy();


            //IComparable Test
            var people = new List<Models.Person>
            {
                new Models.Person{Name = "Bo", Age = 51, IsMale = true},
                new Models.Person{Name = "Frank", Age = 8, IsMale = true},
                new Models.Person{Name = "Marie", Age = 33, IsMale = false},
                new Models.Person{Name = "Jens", Age = 52, IsMale = true},
                new Models.Person{Name = "Mathilde", Age = 70, IsMale = false},
                new Models.Person{Name = "Anders", Age = 2, IsMale = true},
                new Models.Person{Name = "Sven", Age = 22, IsMale = true},
                new Models.Person{Name = "Eva", Age = 23, IsMale = false},
                new Models.Person{Name = "Emilie", Age = 5, IsMale = false},
                new Models.Person{Name = "Ib", Age = 45, IsMale = true},
            };

            people.Sort();

            foreach (var person in people)
            {
                Console.WriteLine("Age: {0}, Sex: {1}, Name: {2}", person.Age, person.IsMale ? "Male" : "Female", person.Name);
            }
        }
    }
}
