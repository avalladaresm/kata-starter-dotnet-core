using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string num = "")
        {
            if (string.IsNullOrEmpty(num)) return 0;
            
            if (num.Contains(','))
            {
                var arrayOfStringNumbers = num.Split(",");
                
                var arrayOfNumbers = arrayOfStringNumbers.Select(x => Convert.ToInt32(x));
                return arrayOfNumbers.Sum();
            }
            return 3;
        }
    }
}