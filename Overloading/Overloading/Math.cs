using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Math
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            if(!int.TryParse(a, out int aInt))
            {
                throw new ArgumentException("Argument must be number.", "a");
            }
            if (!int.TryParse(b, out int bInt))
            {
                throw new ArgumentException("Arguement must be a number.", "b");
            }

            return (aInt + bInt).ToString();
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public float Subtract(float a, float b)
        {
            return a - b;
        }

        public string Substract(string a, string b)
        {
            if (!int.TryParse(a, out int aInt))
            {
                throw new ArgumentException("Argument must be number.", "a");
            }
            if (!int.TryParse(b, out int bInt))
            {
                throw new ArgumentException("Arguement must be a number.", "b");
            }

            return (aInt - bInt).ToString();
        }


        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public float Multiply(float a, float b)
        {
            return a * b;
        }

        public string Multiply(string a, string b)
        {
            if (!int.TryParse(a, out int aInt))
            {
                throw new ArgumentException("Argument must be number.", "a");
            }
            if (!int.TryParse(b, out int bInt))
            {
                throw new ArgumentException("Arguement must be a number.", "b");
            }

            return (aInt * bInt).ToString();
        }


        public int Divide(int a, int b)
        {
            return a / b;
        }

        public float Divide(float a, float b)
        {
            return a / b;
        }

        public string Divide(string a, string b)
        {
            if (!int.TryParse(a, out int aInt))
            {
                throw new ArgumentException("Argument must be number.", "a");
            }
            if (!int.TryParse(b, out int bInt))
            {
                throw new ArgumentException("Arguement must be a number.", "b");
            }

            return (aInt / bInt).ToString();
        }
    }
}
