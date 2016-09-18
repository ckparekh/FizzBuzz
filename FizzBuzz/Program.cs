using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace FizzBuzz
{
  class Program
  {
    
    static void Main(string[] args)
    {
            //read FizzBuzz from Config, can be extended
            var numberValues1 = ConfigurationManager.GetSection("NumberValues") as Hashtable;
            var numberValues = numberValues1.Cast<DictionaryEntry>().ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                .OrderBy(kvp => kvp.Key);

            for (int counter = 1; counter <=100; counter++)
            {
                string result = string.Empty;
                foreach (var item in numberValues)
                {
                    //modulus and string replace
                    result = DivideAndReplace(counter, int.Parse((string)item.Key), (string)item.Value, result);
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



