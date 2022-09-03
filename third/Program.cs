// Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int [] array = {1,4,6,8,9};
int maxx = array[0];
int minn = array[0];
for(int i=1; i<array.Length;i++)
{
    if(maxx<array[i])
    {
        maxx = array[i];
        
    }
    if(minn>array[i])
    {
         minn = array[i];
        

    }
    
}
Console.WriteLine(minn);
Console.WriteLine(maxx);
int result = maxx - minn;
Console.WriteLine(result);