using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Lav et dictionary der kan gemme tal, og bruge strings som key. Gem 10 forskellige værdier heri.
            var textNumberDictionary = new Dictionary<string, int>()
            {
                { "Ti", 10},
                { "Tyve", 20},
                { "Tredive", 30},
                { "Fyrre", 40},
                { "Halvtreds", 50},
                { "Tres", 60},
                { "Halvfjerds", 70},
                { "Firs", 80},
                { "Halvfems", 90},
                { "Hundrede", 100}
            };

            //- Lav et dictionary der kan gemme booleans og bruge float som key. Gem 10 forskellige værdier heri.
            var floatBooleanDictionary = new Dictionary<float, bool>()
            {
                { 1.1F, true},
                { 1.2F, false},
                { 1.3F, true},
                { 1.4F, false},
                { 1.5F, true},
                { 1.6F, false},
                { 1.7F, true},
                { 1.8F, false},
                { 1.9F, true},
                { 2.0F, false},
            };

            // - BONUS: Lav en klasse der kan gemme et navn og en alder på en person. Lav et dictionary som bruger denne klasse som key. 
            var h2ObjectOrientedProg = new Dictionary<Person, Role>()
            {
                { new Person("Andreas", 25), Role.Student},
                { new Person("Aputsiaq", 27), Role.Student},
                { new Person("Kasper", 20), Role.Student},
                { new Person("Mads", 29), Role.Teacher}
            };
        }
    }
}
