using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_september01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter logical equation:");
            string str = Console.ReadLine();

            try
            {
                string strOne = null;
                string strTwo = null;
                string sign = null;
                int index = 0;


                // Design Bug: because of first while condition
                // whole string copied into first number

                while (Char.IsDigit(str[index]))
                    strOne += str[index++];
                if (strOne == null) throw new Exception("There is no first number");

                if (index >= str.Length) throw new Exception("There is no sign");
                while (!(Char.IsDigit(str[index])))
                        sign += str[index++];
                if (sign == null) throw new Exception("There is no sign");

                while (index < str.Length)
                {
                    if (Char.IsDigit(str[index]))
                        strTwo += str[index++];
                }
                if (strTwo == null) throw new Exception("There is no second number");


                int numOne = Convert.ToInt32(strOne);
                int numTwo = Convert.ToInt32(strTwo);

                bool res = false;

                switch (sign)
                {
                    case "<":
                        res = numOne < numTwo;
                        break;
                    case ">":
                        res = numOne > numTwo;
                        break;
                    case "<=":
                        res = numOne <= numTwo;
                        break;
                    case ">=":
                        res = numOne >= numTwo;
                        break;
                    case "==":
                        res = numOne == numTwo;
                        break;
                    case "!=":
                        res = numOne != numTwo;
                        break;
                    default:
                        throw new Exception("Entered invalid sign.");
                        break;
                }

                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            Console.ReadLine();
        }
    }
}
