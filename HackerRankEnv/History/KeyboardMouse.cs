using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        //determine the most expensive computer keyboard and USB drive that can be purchased with given budget.
        //int keyboards[n]: the keyboard prices
        //int drives[m]: the drive prices
        //int b: the budget

        var maximumPossibleSpend = -1; // default not able to buy both items

        var sortedArrayKeyboards = keyboards.OrderByDescending(x => x).ToArray();
        var sortedArrayDrives = drives.OrderByDescending(x => x).ToArray();

        //first comparison
        var keyboardCondition = -1;
        var matchFound = false;

        foreach (var item in sortedArrayKeyboards)
        {
            //test if bigger then budget
            if (!matchFound)
            {
                if (item < b)
                {
                    foreach (var drive in sortedArrayDrives)
                    {
                        if (drive + item < b)
                        {
                            keyboardCondition = drive + item;
                            matchFound = true;
                        }
                    }
                }

            }
        }

        var usbCondition = -1;
        var usbMatchFound = false;

        foreach (var item in sortedArrayDrives)
        {
            //test if bigger then budget
            if (!usbMatchFound)
            {
                if (item < b)
                {
                    foreach (var keyB in sortedArrayKeyboards)
                    {
                        if (keyB + item < b)
                        {
                            usbCondition = keyB + item;
                            usbMatchFound = true;
                        }
                    }
                }
            }

            if(usbCondition > keyboardCondition){
                maximumPossibleSpend = usbCondition;
            }else{
                 maximumPossibleSpend = keyboardCondition;
            }
        }
        return maximumPossibleSpend;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
