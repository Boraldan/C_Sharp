// Найти масимум и поставить его на любое нужное место

int [] arr = new [] {2, 3, 0, 1, 8, 9, 5, 20, 10, 0, 15, -2};

void PrintArr (int [] arrtemp) {
    
    for (int i = 0; i < arrtemp.Length; i++)
    {
      Console.Write(arrtemp[i] + " ");  
    }
}

PrintArr(arr);

void sortArr (int[] arrtemp, int k) {
    int iMin = arrtemp[0];

    for (int i = 0; i < arrtemp.Length; i++) {
    
       if (arrtemp[iMin] < arrtemp[i] )  iMin = i; 
    }
       int itemp  = arrtemp[k];
       arrtemp[k] = arrtemp[iMin];
       arrtemp[iMin] = itemp;
    
    
}

Console.WriteLine(" ");  

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

sortArr(arr, N-1);
PrintArr(arr);

