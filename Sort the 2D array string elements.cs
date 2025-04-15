//Sort the 2D array string elements 
public class Program
{
    public static void Main()
    {
        string[,] names = new string[3, 2]
        {
            {"alsan","bibas" },
            {"akhilesh","aminal" },
            {"anikit","bibek" }
        };
        int a = 0;
        string[] single1 = new string[names.Length];
        for(int i = 0; i < names.GetLength(0); i++)
        {
            for(int j = 0; j < names.GetLength(1); j++)
            {
                single1[a++] = names[i, j];
            }
        }
        Array.Sort(single1);
        a = 0;
        for(int i = 0; i < names.GetLength(0); i++)
        {
            for(int j = 0; j < names.GetLength(1); j++)
            {
                names[i, j] = single1[a++];
                Console.Write($"{names[i, j]} ");
            }
            Console.WriteLine();
        }
        
    }
}