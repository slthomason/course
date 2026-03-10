
#region Arrays 1
//Create an Array
using System.Collections;

string[] cards;

string[] carList = { "Volvo", "BMW", "Ford", "Mazda" };

int[] myNum = { 10, 20, 30, 40 };

//Access the Elements of an Array

Console.WriteLine(carList[0]);

// changing the array element 
carList[0] = "Opel";

//Example: two - dimensional Array
int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };



int[,] arr2d_example2 = {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                };

#endregion


#region Jagged Array 2

//Example 1: Using the Direct Method

int[][] jagged_arr = new int[][]
{
    new int[] {1, 2, 3, 4},
    new int[] {11, 34, 67},
    new int[] {89, 23},
    new int[] {0, 45, 78, 53, 99}
};

//Example 2: Using Short-hand Method

int[][] jagged_arr_example_2 =
{
    new int[] {1, 2, 3, 4},
    new int[] {11, 34, 67},
    new int[] {89, 23},
    new int[] {0, 45, 78, 53, 99}
};

#endregion


#region  Array properties 3

// array of fixed size or not
Console.WriteLine("Result: " + carList.IsFixedSize);

// array  IsReadOnly
Console.WriteLine("Result: " + carList.IsReadOnly);

// array is synchronized (thread safe)
// or not
Console.WriteLine("Result: " + carList.IsSynchronized);

// using Length property
Console.Write(carList.Length);

// using LongLengthLength property
Console.Write(carList.LongLength);

// using Rank Property
Console.WriteLine("Dimension of carList array: "
                               + carList.Rank);


#endregion

#region array methods 4

// taking an 1-D Array
int[] arr = new int[7] { 1, 5, 7, 4, 6, 2, 3 };

// for this method array
// must be sorted
Array.Sort(arr);


Console.WriteLine(Array.BinarySearch(arr, 7));

Array.Reverse(arr);

Array.Clear(arr, 0, arr.Length);



Console.WriteLine(Array.IndexOf(arr,7));


Console.WriteLine(Array.LastIndexOf(arr, 7));

#endregion


#region ArrayList 5

// Creating ArrayList
ArrayList My_array = new ArrayList();

// Adding elements in the
// My_array ArrayList
// This ArrayList contains elements
// of different types
My_array.Add(12.56);
My_array.Add("Start up Hakk");
My_array.Add(null);
My_array.Add('G');
My_array.Add(1234);

// Accessing the elements
// of My_array ArrayList
// Using foreach loop
foreach (var elements in My_array)
{
    Console.WriteLine(elements);
}

Console.ReadLine();
#endregion