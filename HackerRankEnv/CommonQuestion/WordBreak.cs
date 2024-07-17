using System;
using System.Collections.Generic;

class Solution
{
    /*
     * Complete the WordBreak function below.
     Implement the WordBreak function to check if the input string can be segmented into a sequence of dictionary words.

            The Main method reads the input string and the dictionary words from the console.
            The WordBreak function is called with the input string and the list of dictionary words.
            The result is written to the console output, which will be either true or false.
            Test Cases:
            Input:

            String: "leetcode"
            Dictionary: ["leet", "code"]
            Expected Output: true
            Input:

            String: "applepenapple"
            Dictionary: ["apple", "pen"]
            Expected Output: true
            Input:

            String: "catsandog"
            Dictionary: ["cats", "dog", "sand", "and", "cat"]
            Expected Output: false
     */
    static bool WordBreak(string s, IList<string> wordDict)
    {
        // Your implementation here
        var doesWork = true;

        // do a string dot remove if it cant then we know it fails.

        foreach(var word in wordDict){

               if(s.Contains(word)){
                    Console.WriteLine(word);
                   s = s.Replace( word , "");
               }else{
                doesWork = false;
               } 
        } 
        return doesWork;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check if it can be segmented into words from the dictionary:");

        string inputString = Console.ReadLine();

        Console.WriteLine("Enter words for the dictionary, separated by spaces:");

        string[] dictionaryWords = Console.ReadLine().Split(' ');

        bool result = WordBreak(inputString, new List<string>(dictionaryWords));

        Console.WriteLine(result ? "true" : "false");
    }
}
