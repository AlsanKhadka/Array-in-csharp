//convert 2D array to 1D array
public class Program
{
    public static void Main()
    {
        int row, column;
        Console.Write("Enter your length of row");
        row = int.Parse(Console.ReadLine());
        Console.Write("Enter your length of column");
        column = int.Parse(Console.ReadLine());
        int[,] array1 = new int[row, column];
        int[] array2 = new int[row * column];
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write($"Enter [{i},{j}] index value ");
                array1[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        int a = 0;
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                Console.WriteLine($"array1[{i},{j}]={array1[i, j]}");
                


                    array2[a] = array1[i, j];
                a++;
              
            }
        }
        Console.WriteLine();
        Console.WriteLine("2D array to 1D array is ");
      for(int i=0;i< array2.Length; i++)
        {
            Console.Write($"{array2[i]} ");
        }
    }
}