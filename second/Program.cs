﻿// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int [] array = new int[6];
Random rand = new Random();
for(int i = 0; i<array.Length; i++)
{
    array[i] = rand.Next(-15, 15);
}
Console.WriteLine(string.Join(",", array));


int result =0;
for(int i=0; i<array.Length; i++)
{
    if(i%2!=0)
    {
        result +=array[i];
        i++;
    }
}
Console.WriteLine(result);
