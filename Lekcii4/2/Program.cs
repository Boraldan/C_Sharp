// Сортировка массива от минимального к максимальному. 

int [] arr = new [] {7, 3, 0, 1, 8, 9, 5, 1, 10, 0, 15, -2};

void PrintArr (int [] arrtemp) {
    
    for (int i = 0; i < arrtemp.Length; i++)
    {
      Console.Write(arrtemp[i] + " ");  
    }
}

PrintArr(arr);

void sortArr (int[] arrtemp) {
    
    for (int i = 0; i < arrtemp.Length - 1; i++) {
     int iMin = i;

     for (int j = i+1; j < arrtemp.Length; j++)
     {
       if (arrtemp[iMin] > arrtemp[j] )  iMin = j; 


       int itemp  = arrtemp[i];
       arrtemp[i] = arrtemp[iMin];
       arrtemp[iMin] = itemp;
       
    }
    }
}

Console.WriteLine(" ");  
sortArr(arr);
PrintArr(arr);
