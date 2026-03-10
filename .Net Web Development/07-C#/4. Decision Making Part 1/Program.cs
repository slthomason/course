#region 1
{
    string name = "Startup";
    if (name == "Startup")
    {
        Console.WriteLine("you are learning decision making on Startup Hakk");
    }
}
#endregion

#region 2

{
    string name = "Startup";
    if (name == "startup")
    {
        Console.WriteLine("you are learning decision making on Startup Hakk");
    }
    else
    {
        Console.WriteLine("Good Luck");
    }
}

#endregion

#region 3
{
    int i = 0;

    if (i == 10)
    {
        Console.WriteLine("i is 10");
    }
    else if (i == 15)
    {
        Console.WriteLine("i is 15");
    }
    else if (i == 20)
    {
        Console.WriteLine("i is 20");
    }
    else
    {
        Console.WriteLine("i is not present");
    }
}
#endregion


#region 4

{
    int i = 10;

    if (i == 10)
    {
        // Nested - if statement
        // Will only be executed if statement
        // above it is true
        if (i < 12)
        {
            Console.WriteLine("i is smaller than 12 too");
        }
        else
        {
            Console.WriteLine("i is greater than 15");
        }
    }
}
#endregion