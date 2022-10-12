//  В конце каждого блока сase должен ставиться один из операторов перехода

string text = "В конце каждого блока сase должен ставиться один из операторов перехода";

string M1(string text, char oldk, char newK)
{   
    string res = String.Empty;
    int length = text.Length;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldk)
        res = res + $"{newK}";
         else
         res = res + $"{text[i]}";
           
    }
    
    return res;
}
    
string retext = M1(text, ' ', '|');  
    Console.Write(retext);

Console.WriteLine("  ");

retext = M1(retext, 'о', 'О'); 

Console.Write(retext);
