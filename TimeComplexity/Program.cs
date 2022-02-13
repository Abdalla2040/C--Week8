//KYGM 
//Debugging Excercise

//maintain max as 999 and # of elements at 30
int[] lint = GenListInt(999, 30);

//disp list of ints
foreach(var a in lint)
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
    return test2;
}

int search = System.Console.Read();

int[] outArray = binarySearch(lint, search);

string binarySearch(int[] inputArray, int key)
{
    int min = 0;
    int max = inputArray.Length;
    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (key == inputArray[mid])
        {
            return (mid++).ToString();
        }
        else if (key <= inputArray[mid])
        {
            max -= 2;
        }
        else
        {
            min += 1;
        }
    }
    return "No Element Found";
}
