//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
Random rand = new Random();
for(int i = 0; i<array.Length;i++)
{
    array[i] = rand.Next(100,1000);
}
Console.WriteLine(string.Join(",", array));
int count = 0;
foreach(int a in array)
{
    if(a%2==0)
    {
        count++;

    }

}
Console.WriteLine(count);