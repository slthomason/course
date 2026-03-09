#region 1

{
    int x = 1;

    // Exit when x becomes greater than 4
    while (x <= 4)
    {
        Console.WriteLine("StartupHakk " + x.ToString());

        // Increment the value of x for
        // next iteration
        x++;
    }

}
#endregion

#region 2
{
    int x = 21;
    do
    {
        // The line will be printed even
        // if the condition is false
        Console.WriteLine("StartupHakk " + x.ToString());
        x++;
    }
    while (x < 25);
}
#endregion


#region 3

// for loop begins when x=1
// and runs till x <=4
for (int x = 1; x <= 4; x++)
{
    Console.WriteLine("StartupHakk " + x.ToString());
}

#endregion


#region 4

// StartupHakk is printed only 2 times
// because of break statement
for (int i = 1; i < 4; i++)
{
    if (i == 3)
    {
        break;
    }

    Console.WriteLine("StartupHakk " + i.ToString());
}

// This will skip 4 to print
for (int i = 1; i <= 10; i++)
{

    // if the value of i becomes 4 then
    // it will skip 4 and send the
    // transfer to the for loop and
    // continue with 5
    if (i == 4)
    {
        continue;
    }

    Console.WriteLine(i);
}

#endregion


#region 5
{
    // loop within loop printing StartupHakk
    for (int i = 2; i < 4; i++)
    {
        Console.WriteLine("StartupHakk - i: {0}", i);
        for (int j = 1; j < i; j++)
        {
            Console.WriteLine("StartupHakk - i: {0}, j: {1} ", i, j );
        }
    }
}
#endregion