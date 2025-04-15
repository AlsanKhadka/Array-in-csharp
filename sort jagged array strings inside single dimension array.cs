//sort jagged array strings inside single dimension array
public class Program
{
    public static void Main()
    {
        string[][] names = new string[2][]
        {
            new string[] {"Alsan","Prajwol","Akhilesh"},
            new string[]{"Ankit","Amina"}
        };
        int a = 0, b = 0,c=0;
        while (names.Length != c) 
        {
            b = names[a++].Length + b;
            c++;
        }
        a = 0;
        string[] array1 = new string[b];
        for(int i = 0; i < names.Length; i++)
        {
            for(int j = 0; j < names[i].Length; j++)
            {
                array1[a++] = names[i][j];
            }
        }
        Array.Sort(array1);
        a = 0;
        for(int i = 0; i < names.Length; i++)
        {
            for(int j = 0; j < names[i].Length; j++)
            {
                names[i][j] = array1[a++];
                Console.Write($"{names[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}
