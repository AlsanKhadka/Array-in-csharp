//sort the jagged array numbers inside 1D array
public class Person
{
    public static void Main()
    {
        int[][] num = new int[3][]
        {
            new int[] { 1, 20, 3 },
            new int[] { 14, 5, 16, 70 },
            new int[] { 112, 112 }
        };

        int a = 0, b = 0, c = 0, d = 0;

        // Count total elements in the jagged array
        while (a < num.Length)
        {
            b = num[a++].Length + b;
        }

        int temp = b; // Total number of elements
        b--;          // Last index (for comparison)
        a = 0;        // Reset a for reuse

        // Sorting logic
        while (temp != d)
        {
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    c = 0;
                    for (int k = 0; k < num.Length; k++)
                    {
                        for (int l = 0; l < num[k].Length; l++)
                        {
                            if (num[i][j] < num[k][l])
                            {
                                c++;
                            }
                        }
                    }
                    if (b == 1)
                    {
                        b--;
                    }
                    if (b == c)
                    {
                        if (b != 0)
                        {
                            b--;
                        }
                        d++;
                        Console.Write($"{num[i][j]} ");
                    }
                }
            }
        }
    }
}
