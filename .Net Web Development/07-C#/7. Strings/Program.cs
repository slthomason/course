#region 1
using System.Text;
{
    // declare a string Name using
    // "System.String" class
    System.String Name;

    // initialization of String
    Name = "StartupHakk";


    // declare a string id using
    // using an alias(shorthand)
    // "String" of System.String
    // class
    String id;

    // initialization of String
    id = "33";

    // declare a string mrk using
    // string keyword
    string mrk;

    // initialization of String
    mrk = "97";

    // Declaration and initialization of
    // the string in a single line
    string rank = "1";

    // Displaying Result
    Console.WriteLine("Name: {0}", Name);
    Console.WriteLine("Id: {0}", id);
    Console.WriteLine("Marks: {0}", mrk);
    Console.WriteLine("Rank: {0}", rank);

}

#endregion

#region 2

{
    // If you use the below commented
    // the part then this will give
    // Unrecognized escape sequence error
    // string S1 = "\\welcome \to Startup Hakk \ portal \";
    // Console.WriteLine("String 1 is :{0}", S1);

    // By using @ in the given string 
    // it runs smoothly because
    // @ symbol tells the compiler to
    // ignore all escape sequences
    string S2 = @"\\welcome \to Startup Hakk \ portal \";
    Console.WriteLine("String 2 is: {0}", S2);

    // printing new line character in string literal
    // but it will make the string to break  
    // into a new line, see output
    string S3 = "This is \n C# non verbatim string";
    Console.WriteLine("String 3 is :{0}", S3);

    // By using @ symbol /n does not processed
    string S4 = @"This is \n C# verbatim string";
    Console.WriteLine("String 4 is :{0}", S4);

    // printing a string literal contains 
    // tabs and new line without using 
    // any escape sequence
    Console.WriteLine(@"Without Tab Sequence and New Line Character
                               C          C++      Java       Python");
}
#endregion

#region 3
{

    {
        string str = "Startup Hakk";

        // using Chars[Int32] & Length property
        for (int i = 0; i <= str.Length - 1; i++)
            Console.Write("{0} ", str[i]);
    }


    #region Contains

    {
        // string type
        String str = "Startup Hakk";
        String substr1 = "up";
        String substr2 = "Up";

        // using String.Contains() Method
        Console.WriteLine(str.Contains(substr1));

        // Here case-sensitive comparison
        // And substr2 value is 'Up'
        // So its return false
        Console.WriteLine(str.Contains(substr2));

    }
    #endregion

    #region endsWith
    {
        // Input two string
        string str1 = "Sudo Placement++";
        string str2 = "Sudo Placement++";
        bool x, y;

        // Implement EndsWith() method
        x = str1.EndsWith("++");
        y = str2.EndsWith("--");

        // Return  match string "True"
        Console.WriteLine(x.ToString());

        // Return no match string "False"
        Console.WriteLine(y.ToString());
    }
    #endregion


    #region IndexOf 
    {
        string str = "Startup";

        // Finding the index of character
        // which is present in string
        // this will show the value 1
        int index1 = str.IndexOf('t', 0);


        Console.WriteLine("The Index Value of character 't' " +
                          "with start index 1 is " + index1);
    }
    #endregion


    #region LastIndexOf 
    {
        string str = "Startup";

        // Finding the index of character
        // which is present in string
        // this will show the value 2
        int index1 = str.LastIndexOf('t', 0);


        Console.WriteLine("The Index Value of character 't' " +
                          "with start index 2 is " + index1);
    }
    #endregion


    #region IsNullOrWhiteSpace & IsNullOrWhiteSpace
    {
        Console.WriteLine(string.IsNullOrEmpty(null));

        Console.WriteLine(string.IsNullOrEmpty(""));

        Console.WriteLine(string.IsNullOrEmpty("  "));

        Console.WriteLine(string.IsNullOrWhiteSpace("  "));
    }
    #endregion


    #region StartsWith
    {
        Console.WriteLine("Startup".StartsWith("start"));
    }
    #endregion


    #region Trim
    {
        // with trim
        Console.WriteLine("Startup    ".Trim() + "Hakk");

        // without trim
        Console.WriteLine("Startup    " + "Hakk");
    }
    #endregion

}

#endregion

#region 4
{

    StringBuilder s = new StringBuilder("HELLO ");

    s.Append("Startup");

    // after printing "GEEKS"
    // a new line append
    s.AppendLine("Hakk");

    s.Append(".");
    Console.WriteLine(s.ToString());
}
#endregion