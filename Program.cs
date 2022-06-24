
Console.WriteLine("Inverse Number Pyramid");
Console.Write("Number of rows: ");

int rows = Int32.Parse(Console.ReadLine());

for (int i = rows; i >= 1; i--)
 {   
 for (int j = i; j >= 1; j--)
     {
         Console.Write(j + " ");
     }
        Console.WriteLine();
 }

Console.WriteLine("\nEnd of Program");