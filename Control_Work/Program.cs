﻿string[] ar = new string[] {"730", "jump","game", "92","ant"};
string[] ar2 = new string[ar.Length];
void SAr(string[] ar, string[] ar2)
{
    int c = 0;
    for (int i = 0; i < ar.Length; i++)
    {
    if(ar[i].Length <= 3)
        {
        ar2[c] = ar[i];
        c++;
        }
    }
}
void PAr(string[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar2[i]} ");
    }
    Console.WriteLine();
}
SAr(ar, ar2);
PAr(ar2);