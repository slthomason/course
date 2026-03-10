#region 1

{
    int number = 30;
    switch (number)
    {
        case 10:
            Console.WriteLine("case 10");
            break;
        case 20:
            Console.WriteLine("case 20");
            break;
        case 30:
            Console.WriteLine("case 30");
            break;
        default:
            Console.WriteLine("None matches");
            break;
    }
}

#endregion

#region 2
{
    int j = 5;

    switch (j)
    {
        case 5:
            Console.WriteLine(5);
            switch (j - 1)
            {
                case 4:
                    Console.WriteLine(4);
                    switch (j - 2)
                    {
                        case 3:
                            Console.WriteLine(3);
                            break;
                    }
                    break;
            }
            break;
        case 10:
            Console.WriteLine(10);
            break;
        case 15:
            Console.WriteLine(15);
            break;
        default:
            Console.WriteLine(100);
            break;
    }
}
#endregion