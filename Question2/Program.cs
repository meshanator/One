using System;
using System.IO;
using System.Linq;

namespace Question2
{
    /*
        Devise a function that gets one word as parameter and returns all the anagrams for it from the file
        wordlist.txt.

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        You can not use permutations to generate the possible words.

        anagrams("horse") should return:
        ['heros', 'horse', 'shore']
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Question 2");
            Console.WriteLine();
            Console.WriteLine("Please enter a word:");
            Console.WriteLine();
            var input = Console.ReadLine();

            Console.WriteLine();

            var wordList = File.ReadAllLines("wordlist.txt");

            Console.WriteLine("The anagrams for " + input + " are:");
            Console.WriteLine();

            /*
             * Code here
             */

	        if (string.IsNullOrWhiteSpace(input))
		        return;

	        foreach (var word in wordList)
	        {
		        if(IsAnagram(input, word))
					Console.WriteLine(word);
			}
        }

	    static bool IsAnagram(string firstWord, string secondWord)
	    {
			//If the words are not the same length they are not anagrams
		    if (firstWord.Length != secondWord.Length)
			    return false;

		    var sortedFirstWord = string.Concat(firstWord.OrderBy(x => x));
			var sortedSecondWord = string.Concat(secondWord.OrderBy(x => x));

			//If the words, ordered by character for each, are not equal
			//they are not anagrams
		    if (sortedFirstWord != sortedSecondWord)
			    return false;

		    return true;
	    }
	}
}