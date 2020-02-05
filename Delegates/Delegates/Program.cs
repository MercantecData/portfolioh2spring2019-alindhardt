using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void SomethingDelegate();
    public delegate float Something2Delegate();
    public delegate void AppendAndPrintInputsDelegate(string x1, string x2, string x3);

    public delegate int MyIntDelegate(int x1, int x2);
    public delegate float MyFloatDelegate(float x1, float x2);
    public delegate string MyStringDelegate(string x1, string x2);
    class Program
    {
        static void Main(string[] args)
        {
            //- Lav en delegate som returnerer void og tager imod ingen parametre. Kald denne.
            SomethingDelegate del1 = PrintHello;
            del1();

            //- Lav en anden delegate som returnerer float og tager imod ingen parametre. Kald denne.
            Something2Delegate del2 = GetHourOfTheDay;
            Console.WriteLine(del2());

            //- Lav en anden delegate som returnerer void og tager imod 3 parametere. Kald denne.
            AppendAndPrintInputsDelegate del3 = MasterAppender;
            del3("Rip", "Rap", "Rup");


            //Udfordring:
            var math = new Math();

            //int eksempel
            MyIntDelegate intDel = math.Add;
            Console.WriteLine(intDel(2,3));

            //float eksempel
            MyFloatDelegate floatDelegate = math.Divide;
            Console.WriteLine(floatDelegate(12,2));

            //string eksempel
            MyStringDelegate stringDelegate = math.Multiply;
            Console.WriteLine(stringDelegate("10", "10"));
        }

        public static void PrintHello()
        {
            Console.WriteLine("HelloWorld");
        }

        public static float GetHourOfTheDay()
        {
            return (float)DateTime.Now.Hour;
        }

        public static void MasterAppender(string text1, string text2, string text3)
        {
            Console.WriteLine("{0} {1} {2}", text1.Trim(), text2.Trim(), text2.Trim());
        }

    }
}
