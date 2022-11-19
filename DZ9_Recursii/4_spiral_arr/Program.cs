Console.Clear();     
                                              
    Console.Write("Введите количество строк массива: ");
    int n = int.Parse(Console.ReadLine());

    int[,] array = new int[n, n];

    PrintArray(Round(array, 0, 0, 1));


    int [,] Round (int [,] arrya4, int i, int j, int temp) 
    {
            arrya4[i, j] = temp;

        if (temp == arrya4.GetLength(0) * arrya4.GetLength(1))  return arrya4;
                    
            if (i <= j + 1 && i + j < arrya4.GetLength(1) - 1)
            return Round (arrya4, i, j+1, temp+1);
            else if (i < j && i + j >= arrya4.GetLength(0) - 1)
            return Round (arrya4, i+1, j, temp+1);
            else if (i >= j && i + j > arrya4.GetLength(1) - 1)
            return Round (arrya4, i, j-1, temp+1);
            else
            return Round (arrya4, i-1, j, temp+1);
    }

    void PrintArray(int [,] inArray)
    {
         for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i,j]}\t");
            }
            Console.WriteLine();
        }
    }
