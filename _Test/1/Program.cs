int Sun(int n) {
    if (n == 1) return 1;
    else  return n * Sun (n-1);
}

Console.WriteLine(Sun(5));



// int [] newArr = new int [] {1, 2, 3, 4, 5};

// PrintArr(newArr);
// int [] newArr2 = ReverseArray2(newArr);
// PrintArr(newArr2);

// void ReverseArray2(int[] result) {     ////  не работает
 
//     int N = result.Length; 
//     for(int i=0; i < N/2; i++)
//     {   int temp = result[i];
//         result[i] = result[N -1 -i];
//         result[N -1 -i] = temp;
//     }
//   }



// void PrintArr(int[] a) 
// {
//     Console.Write ("[ ");
//     for (int i = 0; i < a.Length; i++) {
//         if (i < a.Length-1)   {
//         Console.Write ($"{a[i]}, ");    }
//         else  {
//             Console.Write (a[i]);       } 
//   }
//     Console.Write (" ]");
//     Console.WriteLine("  ");
// }

