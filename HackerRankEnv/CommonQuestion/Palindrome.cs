using System;
using System.IO;

class Solution
{

    /*
        Input: "A man a plan a canal Panama"
        Expected Output: true
        Input: "race car"
        Expected Output: true
    */

    /*
     * Complete the IsPalindrome function below.
     */
    static bool IsPalindrome(string s)
    {
       var isPalindrome = false;
        // Your implementation here

        // remove all spaces in string
        s = s.Replace(" ", "");
        // string reverse

        var newx = new string(s.Reverse().ToArray());
        var newStringLinq = new string(s.Reverse().ToArray());

       /* char[] charArray =  s.ToCharArray();
        var arrayToCompare = charArray.Reverse();
        string newString = "";

        foreach(var x in arrayToCompare){
            Console.WriteLine(x);
              newString += x;
        }

        // string compare */
        //Console.WriteLine(newString);
        if (s == newStringLinq){
            return true;
        }
        
        return isPalindrome;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check if it is a palindrome:");

        string inputString = Console.ReadLine();

        bool result = IsPalindrome(inputString);

        Console.WriteLine(result ? "true" : "false");
    }
}

