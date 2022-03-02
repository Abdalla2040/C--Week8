using System.Text;

//KYGM 
//Debugging Excercise

//maintain max as 999 and # of elements at 30
int[] lint = GenListInt(255, 30);

//disp list of ints
foreach (var a in lint)
{
    Console.WriteLine(a);
}

int[] GenListInt(int max, int num)
{
    int Min = 0;
    int Max = max;
    Random randNum = new Random();
    int[] test2 = Enumerable
        .Repeat(0, num)
        .Select(i => randNum.Next(Min, Max))
        .ToArray();
    //test2 = BubbleSort(test2);
    Array.Sort(test2);
    return test2;
}
Console.WriteLine("enter a character");
int search = System.Console.Read();

//Console.Write("find value: ");
while (search != 0)
{
    
    string outArray = binarySearch(lint, search);
    Console.WriteLine(outArray);
    //Console.WriteLine("enter a character");
    //Console.ReadLine();
    //search = System.Console.Read();
    
    //Console.WriteLine(outArray);
lint = GenListInt(255, 30);
    foreach (var a in lint)
    {
        Console.WriteLine(a);
    }
    
    search = System.Console.Read();
} 

//Console.WriteLine("search: " + search);
//int.TryParse(Console.ReadLine(), out search);



string binarySearch(int[] inputArray, int key)
{
    int min = 0;
    int max = inputArray.Length;
    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (key == inputArray[mid])
        {
            return (mid).ToString();
        }
        else if (key <= inputArray[mid])
        {
            max = mid-1;
            //mid = (min + max) / 2;
            //binarySearch(inputArray, key);
        }
        else
        {
            min = mid+1;
            //mid = (max + min) / 2;
            //binarySearch(inputArray, key);
        }
    }
    return "No Element Found";
}

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