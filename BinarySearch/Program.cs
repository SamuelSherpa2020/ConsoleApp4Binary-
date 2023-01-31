namespace BinarySearch;
class Program
{
    static void Main(string[] args)
    {
        int searchingFor;
        int[] array = { 1, 2, 6, 8, 13, 55, 56, 73, 84, 104, 156 };

        Console.Write("The numbers in array are:  ");
        array.ToList().ForEach(i => Console.Write(i.ToString() + " "));
        Console.WriteLine();
        Console.Write(" Enter a number to find it's position: ");

        searchingFor = int.Parse(Console.ReadLine());

        BinarySearchMethod(searchingFor, array);
    }

    public static void BinarySearchMethod(int searchingFor, int[] array)
    {
        int start = 0;
        int end = array.Length - 1;
        int midPoint = (end + start) / 2;

        bool foundIt = false;

        while (!foundIt)
        {
            Console.WriteLine($"Start index: {start}, End index: {end}");
            if (array[midPoint] == searchingFor)
            {
                foundIt = true;
            }
            if (array[midPoint] > searchingFor)
            {
                end = midPoint - 1;
            }
            else if (array[midPoint] < searchingFor)
            {
                start = midPoint + 1;
            }
            midPoint = (start + end) / 2;
        }
        Console.WriteLine($"The {searchingFor} was found in {midPoint} index of array");

    }
}
