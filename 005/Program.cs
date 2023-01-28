// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Write("Введите размер массива - ");
int size = Int32.Parse(Console.ReadLine());
void SumArray(int[] array )
{
    int length = array.Length;
    for (int index = 0; index < length; index = index + 1)
    {
        array[index] = new Random().Next(1,100);
    }
}

int[] array = new int[size];
SumArray(array);
Console.WriteLine(string.Join("," , array));


int sumPlus = 0;
int index = 0; 
while (size > index)
{
    sumPlus = sumPlus + array[index];
    index = index + 2;
}
Console.WriteLine(sumPlus);