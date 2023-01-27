// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void ArrayNumbers( int[] array, int sumPositiv = 0,
 int sumNegativ = 0)
 {
 int length = array.Length;
 

for (int index = 0; index < length; index = index + 1)
{
    array[index] = new Random().Next(100,999);
    int result =  array[index] % 2;
    if (result == 0 ) sumPositiv = sumPositiv + 1;
    else if (result > 0 ) sumNegativ = sumNegativ + 1;
}
Console.WriteLine( $"{ sumNegativ}" + " не четных числе в массиве "   );
Console.WriteLine( $"{ sumPositiv}" + "  четных числе в массиве "   );
 }
 int[] array = new int[999];
 ArrayNumbers(array);
 