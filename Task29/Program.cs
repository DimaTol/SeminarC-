// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
Array(array);

void Array(int[] numbers)
 {
    for(int index = 0; index < numbers.Length; index++)
     {
        numbers[index] = new Random().Next(0,8); 
        Console.Write (numbers[index] + ",");
        
     }
 }

