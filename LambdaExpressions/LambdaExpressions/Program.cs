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
        }
    }
}
