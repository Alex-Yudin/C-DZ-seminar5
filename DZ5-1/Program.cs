// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GenerateArray(int length, int minValue, int maxValue)  // функция генерирует массив с заданными параметрами (длина, максимальное и 
// минимальное значение)
{
    int[] result = new int[length];   // создаем массива с длиной length
    Random rnd = new Random();   // Создание генератора случайных чисел
    for (int i = 0; i < result.Length; i++)   // цикл заполнения результирующего массива случайными числами из диапазона между minValue и maxValue
   // инициализируем i индекс для первого элемента массива. Пока этот индекс будет меньше длины массива, будем крутить цикл. В конце цикла увеличим i на один.
    {
        result[i] = rnd.Next(minValue, maxValue + 1); // присваиваем случайное число элементу массива
    }
    return result; // возвращаем массив из функции

}
void ShowArray(int[] array)  // вывод массива
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine();
}

int ChetDigits(int[] array)
{
    int countDigits = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) countDigits++;
    }
    return countDigits;
}

int size = 10;
int minValue = 100;
int maxValue = 999;
int [] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);
System.Console.WriteLine($"количество четных чисел в массиве равно {ChetDigits(array)}");