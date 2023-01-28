// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Write("Введите размер массива - ");
int size = Int32.Parse(Console.ReadLine());

void ArrayDiff( int [] array )
{
    for (int index = 0; index < size; index = index + 1)
    {
        array [index] = new Random().Next(1 , 10000);
    }
}

int[] array = new int[size];
ArrayDiff(array);
Console.WriteLine(string.Join("," , array));

int maxNum = 0;
int minNum = array[1];
int index = 0;
while (index < size)
{   
if (array[index] > maxNum){
    
     maxNum = array[index];
}
     if (array[index] < minNum)
{
    minNum = array[index];
}
    index = index + 1;
}
Console.WriteLine("Минимальное число массива " + $" { minNum} ");
Console.WriteLine("Максимльное число массива " + $"{maxNum}" );

int resultDiff = maxNum - minNum;

Console.WriteLine("Разница между максимальным и минимальным числом массива " + $"{resultDiff}");