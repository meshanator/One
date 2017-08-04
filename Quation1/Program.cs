using System;
using System.Linq;

namespace Question1
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. You can't
        solve the task using a built-in formatting function that can accomplish the whole
        task on its own.

        Assume: 0 <= n < 1000000000

        1 -> "R 1"
        10 -> "R 10"
        100 -> "R 100"
        1000 -> "R 1,000"
        10000 -> "R 10,000"
        100000 -> "R 100,000"
        1000000 -> "R 1,000,000"
        35235235 -> "R 35,235,235"
     */

    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new long[] { 1, 10, 100, 1000, 10000, 100000, 1000000, 35235235 };

            Console.WriteLine("Welcome to Question 1");
            Console.WriteLine();
            Console.WriteLine("Your inputs are:");
            Console.WriteLine();

            foreach (var input in inputs)
            {
                Console.WriteLine(input);
            }

            /*
             * Code here
             */

            Console.WriteLine();
            Console.WriteLine("Your formatted numbers are:");
            Console.WriteLine();
			
			foreach (var input in inputs)
            {
	            Console.WriteLine(SanitizeToMoneyFormat(input));
            }
        }


		//The idea here is to reverse the number then add a comma
		//after every 3rd character
	    static string SanitizeToMoneyFormat(long input)
	    {
			var inputAsArray = string.Concat(input.ToString().Reverse());
		    var numberAsString = string.Empty;

		    for (var i = inputAsArray.Length; i > 0; i--)
		    {
			    if (i != inputAsArray.Length)
			    {
				    if (i % 3 == 0)
					    numberAsString += ",";
			    }
			    numberAsString += inputAsArray[i - 1];
		    }
		    return $"R {numberAsString}";
	    }
    }
}
