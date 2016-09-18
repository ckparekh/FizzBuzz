using System;
using System.Collections.Generic;

namespace FizzBuzz
{
  class Program
  {
    static Dictionary<int, string>  NumberValues = new Dictionary<int,string>(){{3,"Fizz"}, {5, "Buzz"}};

    static void Main(string[] args)
    {

            for (int counter = 1; counter <=100; counter++)
            {
                string result = string.Empty;
                foreach (var item in NumberValues)
                {
                    result = DivideAndReplace(counter, item.Key, item.Value, result);
                }
                
                result = string.IsNullOrEmpty(result) ? counter.ToString() : result;
                Console.WriteLine(result);
            }
            Console.ReadLine();

        }

    private static string DivideAndReplace(int counter, int denominator,string replaceString, string result)
    {
         var output = counter % denominator;
         return (output == 0 ? result + replaceString : result);
    }

  }
}


