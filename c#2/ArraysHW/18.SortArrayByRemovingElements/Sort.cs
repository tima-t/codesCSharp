//Write a program that reads an array of integers and removes from it a 
//minimal number of elements in such way that the remaining array is sorted 
//in increasing order. Print the remaining sorted array. Example:
//	{6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}
using System;
using System.Collections.Generic;

class Sort
{
    static void Main()
    {
        int[] array = EnterArray();
        List<int> sortedArray = new List<int>();
        SortArrayByRemovingElements(array, sortedArray);
    }

    private static void SortArrayByRemovingElements(int[] array, List<int> sortedArray)
    {
        for (int i = 0; i < array.Length; i++) //i pokazva kolko 1 ima dvoi4noto 4islo.. kudeto bita e raven na 1, tazi poziciq premahvame
        {                                      // purvo 6te se razgleda 000 za6toto tq e s 0 edinici v dvoi4niq si kod, sled tova 001, 010, 100 i t.n. za6toto te sa s 1 edinica v dvoi4niq si kod 
            for (int j = 0; j < Math.Pow(2, array.Length) - 1; j++) //j < Math.Pow(2, array.Length) - 1, za6toto ako masiva ni e dulag 3 elementa, 2^3 = 8, 4isloto 8 - 1 = 7 ima 3 bita s stoinost 1 a nas tova ne ni trbva(da premahnem celiq masiv i da ne ostane ni6to) za tova nai star6ata kombinaciq e 8 - 2 = 6 (dvoi4en kod 110)
            {
                int resultCounter = 0; // broi kolko bita s stoinost 1 ima v 4isloto
                for (int k = 0; k < array.Length; k++) //k e 4islo koeto pokazva poziciqta na teku6tiq izsledvan bit. Meni se ot [0 , n),ako masiva ni e dulag 3 elementa 6te izsledvame bitove s pozicii 0, 1 i 2
                {
                    int mask = 1 << k;
                    int result = (j & mask) >> k;
                    if (result == 1)
                    {
                        resultCounter++; //broi kolko sa bitovete 1
                    }
                    else if (result == 0)
                    {
                        sortedArray.Add(array[k]); // kudeto bita e 0 dobavqme elementa  v list koito po kusno 6te proverim dali e sortiran
                    }
                }
                if (resultCounter == i) // ako sme premahnali tolkova bitove kolkoto iskame proverqvame lista dali e sortiran
                {
                    bool isSorted = true;
                    if (sortedArray.Count > 1)
                    {
                        for (int k = 0; k < sortedArray.Count - 1; k++)
                        {
                            if (sortedArray[k] > sortedArray[k + 1])
                            {
                                isSorted = false;
                                break;
                            }
                        }
                    }
                    if (isSorted)
                    {
                        Console.WriteLine("The sorted array: ");
                        foreach (int num in sortedArray)
                        {
                            Console.WriteLine(num);
                        }
                        return;
                    }
                }
                sortedArray.Clear();
            }
        }
    }

    private static int[] EnterArray()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());//3

        int[] array = new int[length]; //1 5 7
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}