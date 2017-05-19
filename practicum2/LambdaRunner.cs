using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicum2
{
    class LambdaRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            // methode TimesThree herschreven als lambda-expressie
            // Func<int, int> timesThree = x => 3 * x;
            // output.AppendFormat("x => 3 * x, met x={0} = {1}\n", num1, timesThree(num1));

            // methode AddNumber herschreven als lambda-expressie
            Func<int, int, int, int> addNumbers = (x, y, z) => x + y + z;
            output.AppendFormat("AddNumbers({0},{1},{2}) = {3}\n", num1, num2, num3, addNumbers(num1, num2, num3));

            // methode IsEven herschreven als lambda-expressie
            Predicate<int> isEven = x => x % 2 == 0;
            output.AppendFormat("IsEven({0}) = {1}\n", num1, isEven(num1));


            // methode num2String herschreven als lambda-expressie
            Func<int, string> num2String = x =>
            {
                switch (x)
                {
                    case 0:
                        return "zero";
                    case 1:
                        return "one";
                    case 2:
                        return "two";
                    case 3:
                        return "three";
                    case 4:
                        return "four";
                    case 5:
                        return "five";
                    case 6:
                        return "six";
                    case 7:
                        return "seven";
                    case 8:
                        return "eight";
                    case 9:
                        return "nine";
                    default:
                        return "undefined";
                }
            };
            output.AppendFormat("Num2String({0}) = {1}\n", num1, num2String(num1));
            
            // methode InBetween herschreven als lambda-expressie
            Func<int, int, int, bool> inBetween = (x, y, z) => (x < y && y < z) || (z < y && y < x);
            output.AppendFormat("InBetween({0},{1},{2}) = {3}\n", num1, num2, num3, inBetween(num1, num2, num3));

            // methode ResetName herschreven als lambda-expressie
            Action<Person> resetName = x => x.Name = null;
            Person p = new Person { Name = "Jan" };
            resetName(p);
            output.AppendFormat("ResetName, daarna (Name == null) = {0}\n", p.Name == null);
            return output.ToString();
        }
    }
}
