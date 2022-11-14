// // Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


Console.WriteLine("Введите целое число: ");
int numberM = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите целое число: ");
int numberN = Convert.ToInt32 (Console.ReadLine());

int SummElements (int numM, int numN)
{
    
    int summ = default;
    // if (numM <= numN)
    // {
    //     // // Console.Write($"{numM} ");
    //     // return summ = summ + numM + SummElements(numM -1, numN);
    // }

   
    
        // Console.Write($"{numM} ");
        
        if (numM <= numN)
        return summ = summ + numM + SummElements(numM+1, numN);

        else return summ;

}




// bool Element(int numbM, int numbN)
// {
//     {
//         return (numM <= numN);
//     }
// }

// bool element = Element (numberM, numberN);
if (numberN <= numberM)
{
int summ = SummElements (numberN, numberM);

Console.WriteLine(summ);
}

else
{
int summ1 = SummElements (numberM, numberN);
Console.WriteLine(summ1);
}
