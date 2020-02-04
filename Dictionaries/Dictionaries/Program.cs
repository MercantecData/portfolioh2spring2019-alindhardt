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

            var h2ObjectOrientedProg = new Dictionary<string, int>()
            {
                { "Andreas", 25},
                { "Aputsiaq", 27},
                { "Kasper", 20},
                { "Mads", 29}
            };
        }
    }
}
