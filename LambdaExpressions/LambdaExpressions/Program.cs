using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public delegate int MultiplyDelegate(int input);
    public delegate float SumOfFloatsDelegate(float num1, float num2, float num3);
    public delegate string TextMakerDelegate();

    public delegate int MyIntDelegate(int x1, int x2);
    public delegate float MyFloatDelegate(float x1, float x2);
    public delegate string MyStringDelegate(string x1, string x2);
    class Program
    {
        static void Main(string[] args)
        {
            //- Lav en Lambda Expression der tager imod en int og returnerer tallet fordoblet. Gem i en passende delegate, og kør.
            MultiplyDelegate del1 = x => x * 2;
            Console.WriteLine(del1(50));


            // - Lav en Lambda Expression der tager imod 3 floats og returnerer summen. Gem i en passende delegate, og kør.
            SumOfFloatsDelegate del2 = (x1, x2, x3) => x1 + x2 + x3;
            Console.WriteLine(del2(12.1F, 1.5F, 2.7F));

            //- Lav en Lambda Expression der ikke tager imod noget og returnerer "Hello World". Gem i en passende delegate og kør.
            TextMakerDelegate del3 = () => "Hello World";
            Console.WriteLine(del3());


            //Udfordring
            //addition
            MyFloatDelegate floatDelAddition = (num1, num2) => num1 + num2;
            Console.WriteLine(floatDelAddition(2.2f, 40f));

            //substraction
            MyFloatDelegate floatDelSubstration = (num1, num2) => num1 - num2;
            Console.WriteLine(floatDelSubstration(99.1f, 30.3f));

            //division
            MyIntDelegate intDelDivision = (num1, num2) => num1 / num2;
            Console.WriteLine(intDelDivision(10, 5));

            //Multiply
            MyStringDelegate stringDelMultiply = (text1, text2) => 
            {
                if (!int.TryParse(text1, out int int1))
                {
                    throw new ArgumentException("Argument must be number.", "text1");
                }
                if (!int.TryParse(text2, out int int2))
                {
                    throw new ArgumentException("Arguement must be a number.", "text2");
                }

                return (int1 * int2).ToString();
            };
            Console.WriteLine(stringDelMultiply("10", "20"));
        }
    }
}
