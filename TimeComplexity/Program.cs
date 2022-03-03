
//KYGM 
//Debugging Excercise

//maintain max as 999 and # of elements at 30
int[] lint = GenListInt(999, 30);

//disp list of ints
foreach (var a in lint)
{
    Console.WriteLine(a);
}

int[] GenListInt(int max, int num)
{
    //min = 0;
    int Min = 97;
    int Max = max;
    Random randNum = new Random();
    int[] test2 = Enumerable
        .Repeat(0, num)
        .Select(i => randNum.Next(Min, Max))
        .ToArray();
    //test2 = BubbleSort(test2);

    /// <summary>
    /// Array was not initally sorted once test2 is generated, so I used
    /// Array.Sort method to sort. 
    /// For Binary Search to work, the array or list must be sorted.
    /// </summary>
    Array.Sort(test2);
    return test2;
}
while (true)
{
    Console.Write("enter a character: ");
    int search = System.Console.Read();
    Console.Read();
    Console.Read();
    Console.WriteLine("value: " + search.ToString());

    /// <summary>
    /// outArray data type was initially set to an array of int.
    /// BinarySearch function returns a string, so I changed the variable
    /// outArray to string.
    /// </summary>
    //int[] outArray = binarySearch(lint, search);
    string outArray = binarySearch(lint, search);
    
    Console.WriteLine("index: " + outArray);
    Console.WriteLine("*******************************************");
    Array.Clear(lint);

    /// <summary>
    /// GenListInt takes two parameters, max and num. max is the MaxValue for the 
    /// randNum object's Next() method. You initially set it at 999, which includes
    /// Unicode characters and most of them cannot be converted or recognized by
    /// the standard ASCII code. So, to not end up with 'no element found', I made
    /// the minValue and MaxValue of the randNum.Next() to start at 97 and max out at
    /// 122. This way, it can find the ASCII code in my keyboard (a-z) 
    /// which starts a=97 to z=122. num is the count or the length required by the Repeat method.
    /// </summary>
    // int[] lint = GenListInt(999, 30);
    lint = GenListInt(122, 30);
    foreach (var a in lint)
    {
        Console.WriteLine(a);
    }
}

string binarySearch(int[] inputArray, int key)
{
    int min = 0;
    int max = inputArray.Length;
    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (key == inputArray[mid])
        {
            /// <summary>
            /// if the key is equal to the item we're searching, we want to return
            /// the index and changed it to string because our function returns a string.
            /// Initially, this was returning m++ which is adding the index one more.
            /// </summary>
            // return (mid++).ToString();
            return (mid).ToString();
        }
        else if (key <= inputArray[mid])
        {
            /// <summary>
            /// if the key is less than or equal to our item, we want to set our max
            /// or the last item to search to be one less than the middle of the array,
            /// so we can disregard the other half of the array as the item will not be there.
            /// Initially we were setting the max to be 2 less than what it was.
            /// </summary>
            // max -= 2;
            max = mid-1;
        }
        else
        {
            /// <summary>
            /// if the item is still not found, then we need to set our min or the start 
            /// of the array to be one more than the mid or one more than the halfway of
            /// the array, as the item does not exist in the first half of the array.
            /// Initially we were adding 1 to our min.
            /// </summary>
            // min += 1;
            min = mid+1;
        }
    }
    return "No Element Found";
}

/// <summary>
/// This part is me fooling around. I took my BubbleSort function from last week
/// to see if I can use it to sort the Array. It works, but the Array.Sort() method is
/// better.
/// </summary>

//My Bubble Sort Function
//int[] BubbleSort(int[] numbers)
//{
//    int temp;  //O(1)
//    for (int i = 0; i < numbers.Length; i++) // O(n)
//    {
//        for (int j = 0; j < numbers.Length - 1; j++) // O(n)
//        {
//            if (numbers[j] > numbers[j + 1]) // O(1)
//            {
//                temp = numbers[j]; // O(1)
//                numbers[j] = numbers[j + 1]; // O(1)
//                numbers[j + 1] = temp; // O(1)
//                // example: 5, 2, 6, 8, 4, 3
//            }
//        }
//    }
//    return numbers; // O(1)
//} //O(2 + n)