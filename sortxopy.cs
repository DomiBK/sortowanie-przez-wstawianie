


class Program
{
 
    static void Main(string[] args)
    {
        // Generowanie tablicy stu liczb losowych
        Random random = new Random();
        int[] array = new int[100];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 1000); // Liczby od 1 do 1000
        }

        // Wyświetlanie zawartości tablicy przed sortowaniem
        Console.WriteLine("Tablica przed sortowaniem:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Sortowanie tablicy za pomocą InsertionSort
        sorting(array);

        // Wyświetlanie zawartości tablicy po sortowaniu
        Console.WriteLine("Tablica po sortowaniu:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Sprawdzanie poprawności sortowania
        int[] arraySorted = (int[])array.Clone();
        Array.Sort(arraySorted);

        bool isSorted = true;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != arraySorted[i])
            {
                isSorted = false;
                break;
            }
        }

        Console.WriteLine("Poprawność sortowania: " + (isSorted ? "Tak" : "Nie"));
    }

    public static void sorting(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int wstawianyElement = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > wstawianyElement)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = wstawianyElement;
        }
    }
}
