#region code raising the exception
using _14_exception_handling;
{
    // Declare an array of max index 4
    int[] arr = { 1, 2, 3, 4, 5 };

    // Display values of array elements
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }

    // Try to access invalid index of array
    //Console.WriteLine(arr[7]);
    // An exception is thrown upon executing
    // the above line
}
#endregion

#region try catch example
{
    // Declare an array of max index 4
    int[] arr = { 1, 2, 3, 4, 5 };

    // Display values of array elements
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }

    try
    {
        // Try to access invalid index of array
        Console.WriteLine(arr[7]);
        // An exception is thrown upon executing
        // the above line
    }
    catch (IndexOutOfRangeException e)
    {
        // The Message property of the object
        // of type IndexOutOfRangeException
        // is used to display the type of exception
        // that has occurred to the user.
        Console.WriteLine("An Exception has occurred : {0}", e.Message);
    }
}

#endregion

#region finally example

{

    int[] arr = { 19, 0, 75, 52 };

    try
    {
        // Try to generate an exception
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] / arr[i + 1]);
        }
    }
    // Catch block for invalid array access
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine("An Exception has occurred : {0}", e.Message);
    }
    // Catch block for attempt to divide by zero
    catch (DivideByZeroException e)
    {
        Console.WriteLine("An Exception has occurred : {0}", e.Message);
    }
    // Catch block for value being out of range
    catch (ArgumentOutOfRangeException e)
    {
        Console.WriteLine("An Exception has occurred : {0}", e.Message);
    }
    // Finally block
    // Will execute irrespective of the above catch blocks
    finally
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" {0}", arr[i]);
        }
    }
}

#endregion

#region custom exception

calculator obj = new calculator();
double num = 9, den = 0, quotient;
try
{
    // Code block that may cause an exception
    quotient = obj.DivisionOperation(num, den);
    Console.WriteLine("Quotient = {0}", quotient);
}
// Catch block to catch the generic exception
catch (Exception e)
{
    // Message property of exception object e
    // will give the specific type of the exception
    Console.Write(e.Message);
}

#endregion