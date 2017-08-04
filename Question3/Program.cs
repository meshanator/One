using System;
using System.Collections.Generic;
using System.Linq;

namespace Question3
{
    /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1
     */

    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<int[]>
            {
                new int[] { 1, 2, 3, 4, 5, 7, 8, 10, 12 },
				//Total = 52, Halfway = 26, there is no equivalence index. Closes is index 5.


                new int[] { 2, 2, 3, 4, 3, 74, 8, 10, 12 }
	            //Total = 118, Halfway = 59, there is no equivalence index. Closest is index 4.
            };

            Console.WriteLine("Welcome to Question 3");
            Console.WriteLine();

            foreach (var input in inputs)
            {
                var equivalenceIndex = -1;
                Console.WriteLine("Input : [" + string.Join(", ", input) + "]");

                /*
                 * Code here
                 */

	            equivalenceIndex = FindEquivalenceIndex(input);

				Console.WriteLine("Result: " + equivalenceIndex);
                Console.WriteLine();
            }

            Console.ReadLine();

        }

		//Basic idea is to total the array and save the half value.
		//Then iterate through the array while keeping a rolling sum.
		//If, for the current loop, the rolling sum matches the half, we have the equivalence index.

		//NB. The current 2 arrays dont have an equivalence index.
		static int FindEquivalenceIndex(int[] input)
		{
			var equivalenceIndex = -1;
			var total = input.ToList().Sum();
		    var half = total / 2;
		    var rollingSum = 0;

		    for (var i = 0; i < input.Length; i++)
		    {
			    rollingSum += input[i];
			    if (rollingSum == half)
				    equivalenceIndex = i;
		    }

			return equivalenceIndex;
		}
    }
}
