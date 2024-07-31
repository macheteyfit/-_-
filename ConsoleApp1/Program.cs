using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "5+6+1-3/3*10";
            string[] numberStrings = input.Split(new char[] { '+', '-', '*', '/' },
            StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numberStrings[i]);
            }

            int result = numbers[0];
            int j = 1;
            for (int i = 0; i < input.Length; i++)
            {
                char operatorSymbol = input[i];
                switch (operatorSymbol)
                {
                    case '+':   //'(+-)' '(*/)' 
                        result += numbers[j];
                        j++;
                        break;
                    case '-':
                        result -= numbers[j];
                        j++;
                        break;
                    case '*':
                        result *= numbers[j];
                        j++;
                        break;
                    case '/':
                        if (numbers[j] == 0)
                        {
                            Console.WriteLine("Ошибка: Деление на ноль");
                            return;
                        }
                        result /= numbers[j];
                        j++;
                        break;
                }
            }
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}

