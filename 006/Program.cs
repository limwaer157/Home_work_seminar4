// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Введите размер массива  - ");
    int size = Int32.Parse(Console.ReadLine());
    int index1 = size;
    int summ = 1;
    int i = 0;
void ArrayRandom( int [] array )
   {
        for (int index = 0; index < size ; index = index + 1)
    {
        array [index] = new Random().Next(1 , 10);
    }
    
    while (i <= size / 2)
    {
         summ = array[i] * array[size - 1] ; 
         size = size -1;
         i++;
        Console.WriteLine(summ);
 }

   }
int[] array = new int[size];
ArrayRandom(array);
Console.WriteLine(string.Join("," , array));
 

