using System;
using System.Linq;

class CountingSortExample
{
    public static void CountingSort(int[] inputArray)
    {
        // الخطوة 1: تحديد الحد الأقصى للقيم في المصفوفة
        int max = FindMax(inputArray);

        // إنشاء مصفوفة المساعدة countArray
        int[] countArray = new int[max + 1];

        // الخطوة 2: حساب تكرار كل عنصر
        for (int i = 0; i < inputArray.Length; i++)
        {
            countArray[inputArray[i]]++;
        }

        // الخطوة 3: حساب المجموع التراكمي
        for (int i = 1; i < countArray.Length; i++)
        {
            countArray[i] += countArray[i - 1];
        }

        // الخطوة 4: إنشاء مصفوفة الإخراج
        int[] outputArray = new int[inputArray.Length];

        // ملء مصفوفة الإخراج عبر المرور العكسي
        for (int i = inputArray.Length - 1; i >= 0; i--)
        {
            outputArray[countArray[inputArray[i]] - 1] = inputArray[i];
            countArray[inputArray[i]]--;
        }

        // نسخ القيم من مصفوفة الإخراج إلى الأصلية
        for (int i = 0; i < inputArray.Length; i++)
        {
            inputArray[i] = outputArray[i];
        }
    }

    // دالة مساعد للعثور على الحد الأقصى
    private static int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }

    // الدالة الرئيسية
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n         *********<< Counting Sort 0_0 >>*********\n");
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Enter the numbers to be sorted, separated by spaces:");
        string input = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.DarkYellow;

        // تحويل الإدخال إلى مصفوفة أعداد صحيحة
        int[] array = input.Split(' ')
                           .Select(int.Parse)
                           .ToArray();

        Console.WriteLine("\nOriginal Array :)");
        Console.WriteLine(string.Join(", ", array));
        Console.ForegroundColor = ConsoleColor.Cyan;


        CountingSort(array);

        Console.WriteLine("\nSorted Array :)");
        Console.WriteLine(string.Join(", ", array));
        Console.ForegroundColor = ConsoleColor.Magenta;
    }
}
