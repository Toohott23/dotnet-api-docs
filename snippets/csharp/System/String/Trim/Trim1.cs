﻿using System;

public class Example
{
    public static void Main()
    {
        // <Snippet1>
        char[] charsToTrim = { '*', ' ', '\''};
        string banner = "*** Much Ado About Nothing ***";
        string result = banner.Trim(charsToTrim);
        Console.WriteLine("Trimmed\n   {0}\nto\n   '{1}'", banner, result);

        // The example displays the following output:
        //       Trimmed
        //          *** Much Ado About Nothing ***
        //       to
        //          'Much Ado About Nothing'
        // </Snippet1>
    }
}
