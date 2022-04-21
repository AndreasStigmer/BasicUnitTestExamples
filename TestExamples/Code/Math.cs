using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExamples.Code
{
   public class Math
   {
        public int Add(int a, int b) { return a + b; }

        public int Subtract(int a, int b) { return a - b; }

        public double Multiply(double a, double b) { return a * b; }

        public float Divide(float a, float b) { return a / b; }

        public int Max(int a, int b) {
            /*
            if(a>b)
            {
                return a;
            }
            return b;
            */
            return a > b ? a:b; 
        }
        public int Min(int a, int b)
        {
            /*
            if(a<b)
            {
                return a;
            }
            return b;
            */
            return a < b ? a : b;
        }

        public int[] GetOddNumbers(int limit){ 
            int[] numbers = new int[limit/2];
            int number = 1;
            for(int i=0;number<limit;i++){
                numbers[i] = number;
                number+=2;
            }
            return numbers; 
        }
    }
}
