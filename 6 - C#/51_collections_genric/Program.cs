#region 1


using _13_collections_genric;

using System.Collections;


{
    Hashtable numberNames1 = new Hashtable();
    numberNames1.Add(1, "One"); //adding a key/value using the Add() method
    numberNames1.Add(2, "Two");
    numberNames1.Add(3, "Three");

    //The following throws run-time exception: key already added.
    //numberNames.Add(3, "Three"); 

    foreach (DictionaryEntry de in numberNames1)
    { 
        Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
    }

    //creating a Hashtable using collection-initializer syntax
    var cities = new Hashtable(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};

    foreach (DictionaryEntry de in cities)
    { 
        Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
    }
}

{

    // Creates and initializes a new Queue.
    Queue myQ = new Queue();
    myQ.Enqueue("Hello");
    myQ.Enqueue("World");
    myQ.Enqueue("!");

    // Displays the properties and values of the Queue.
    Console.WriteLine("myQ");
    Console.WriteLine("\tCount:    {0}", myQ.Count);
    Console.Write("\tValues:");

    foreach (Object obj in myQ)
    { 
        Console.Write("    {0}", obj);
    }
    Console.WriteLine();

}

{
    // Creates and initializes a new Stack.
    Stack myStack = new Stack();
    myStack.Push("Hello");
    myStack.Push("World");
    myStack.Push("!");

    // Displays the properties and values of the Stack.
    Console.WriteLine("myStack");
    Console.WriteLine("\tCount:    {0}", myStack.Count);
    Console.Write("\tValues:");
    foreach (Object obj in myStack)
    {
        Console.Write("    {0}", obj);
    }
}

#endregion


#region 2
// instance of string type
GenricExample<string> name = new GenricExample<string>();
name.value = "GeeksforGeeks";

// instance of float type
GenricExample<float> version = new GenricExample<float>();
version.value = 5.0F;

// display GeeksforGeeks
Console.WriteLine(name.value);

// display 5
Console.WriteLine(version.value);
#endregion

#region 3

#region dictionary
{
    // Creating a dictionary
    // using Dictionary<TKey,TValue> class
    Dictionary<int, string> My_dict1 = new Dictionary<int, string>();

    // Adding key/value pairs 
    // in the Dictionary
    // Using Add() method
    My_dict1.Add(1123, "Welcome");
    My_dict1.Add(1124, "to");
    My_dict1.Add(1125, "start up hakk");

    // Using Remove() method 
    My_dict1.Remove(1124);

    foreach (KeyValuePair<int, string> ele1 in My_dict1)
    {
        Console.WriteLine("{0} and {1}",
                  ele1.Key, ele1.Value);
    }
    Console.WriteLine();

    // Creating another dictionary
    // using Dictionary<TKey,TValue> class
    // adding key/value pairs without
    // using Add method
    Dictionary<string, string> My_dict2 = new Dictionary<string, string>(){
            {"a.1", "Dog"},
            {"a.2", "Cat"},
            {"a.3", "Pig"} };

    // Using ContainsKey() method to check
    // the specified key is present or not
    if (My_dict2.ContainsKey("a.1") == true)
    {
        Console.WriteLine("Key is found...!!");
    }

    else
    {
        Console.WriteLine("Key is not found...!!");
    }

    foreach (KeyValuePair<string, string> ele2 in My_dict2)
    {
        Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
    }



    // Using ContainsValue() method to check
    // the specified value is present or not
    if (My_dict2.ContainsValue("Cat") == true)
    {
        Console.WriteLine("Value is found...!!");
    }

    else
    {
        Console.WriteLine("Value is not found...!!");
    }


}

#endregion

#region List
{
    List<int> primeNumbers = new List<int>();
    primeNumbers.Add(1); // adding elements using add() method
    primeNumbers.Add(3);
    primeNumbers.Add(5);
    primeNumbers.Add(7);
    primeNumbers.Remove(5);


    primeNumbers.Contains(3); // returns true
    primeNumbers.Contains(9); // returns false
    primeNumbers.Insert(1, 3);// inserts 3 at 1st index

    var cities = new List<string>();
    cities.Add("New York");
    cities.Add("London");
    cities.Add("Mumbai");
    cities.Add("Chicago");
    cities.Add(null);// nulls are allowed for reference type list

}
#endregion

#region Queue
Queue<int> callerIds = new Queue<int>();
callerIds.Enqueue(1);
callerIds.Enqueue(2);
callerIds.Enqueue(3);
callerIds.Enqueue(4);

foreach (var id in callerIds)
{ 
    Console.Write(id); //prints 1234
}

#endregion

#region sortedList
SortedList<int, string> numberNames = new SortedList<int, string>();
numberNames.Add(3, "Three");
numberNames.Add(1, "One");
numberNames.Add(2, "Two");
numberNames.Add(4, null);
numberNames.Add(10, "Ten");
numberNames.Add(5, "Five");

//The following will throw exceptions
//numberNames.Add("Three", 3); //Compile-time error: key must be int type
//numberNames.Add(1, "One"); //Run-time exception: duplicate key
//numberNames.Add(null, "Five");//Run-time exception: key cannot be null

foreach (var kvp in numberNames)
{ 
    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
}
#endregion

#region hashSet

HashSet<int> evenNumbers = new HashSet<int>();
HashSet<int> oddNumbers = new HashSet<int>();

for (int i = 0; i < 5; i++)
{
    // Populate numbers with just even numbers.
    evenNumbers.Add(i * 2);

    // Populate oddNumbers with just odd numbers.
    oddNumbers.Add((i * 2) + 1);
}

Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
DisplaySet(evenNumbers);

Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
DisplaySet(oddNumbers);

// Create a new HashSet populated with even numbers.
HashSet<int> numbers = new HashSet<int>(evenNumbers);
Console.WriteLine("numbers UnionWith oddNumbers...");
numbers.UnionWith(oddNumbers);

Console.Write("numbers contains {0} elements: ", numbers.Count);
DisplaySet(numbers);

void DisplaySet(HashSet<int> collection)
{
    Console.Write("{");
    foreach (int i in collection)
    {
        Console.Write(" {0}", i);
    }
    Console.WriteLine(" }");
}

/* This example produces output similar to the following:
* evenNumbers contains 5 elements: { 0 2 4 6 8 }
* oddNumbers contains 5 elements: { 1 3 5 7 9 }
* numbers UnionWith oddNumbers...
* numbers contains 10 elements: { 0 2 4 6 8 1 3 5 7 9 }
*/


#endregion

#region Linked List
{
    // Creating a linkedlist
    // Using LinkedList class
    LinkedList<String> my_list = new LinkedList<String>();

    // Adding elements in the LinkedList
    // Using AddLast() method
    my_list.AddLast("Zoya");
    my_list.AddLast("Shilpa");
    my_list.AddLast("Rohit");
    my_list.AddLast("Rohan");
    my_list.AddLast("Juhi");
    my_list.AddLast("Zoya");

    // Initial number of elements
    Console.WriteLine("Best students of XYZ " +
                     "university initially:");

    // Accessing the elements of 
    // Linkedlist Using foreach loop
    foreach (string str in my_list)
    {
        Console.WriteLine(str);
    }

    // After using Remove(LinkedListNode)
    // method
    Console.WriteLine("Best students of XYZ" +
                     " university in 2000:");

    my_list.Remove(my_list.First);

    foreach (string str in my_list)
    {
        Console.WriteLine(str);
    }

    // After using Remove(T) method
    Console.WriteLine("Best students of XYZ" +
                     " university in 2001:");

    my_list.Remove("Rohit");

    foreach (string str in my_list)
    {
        Console.WriteLine(str);
    }

    // After using RemoveFirst() method
    Console.WriteLine("Best students of XYZ" +
                     " university in 2002:");

    my_list.RemoveFirst();

    foreach (string str in my_list)
    {
        Console.WriteLine(str);
    }

    // After using RemoveLast() method
    Console.WriteLine("Best students of XYZ" +
                     " university in 2003:");

    my_list.RemoveLast();

    foreach (string str in my_list)
    {
        Console.WriteLine(str);
    }

    // After using Clear() method
    my_list.Clear();
    Console.WriteLine("Number of students: {0}",
                                 my_list.Count);
}


#endregion

#endregion