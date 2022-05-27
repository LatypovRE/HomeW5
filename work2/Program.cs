/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] arr = new int[8];
int sum = 0; 
Random rand = new Random();
for(int i =0; i < arr.Length; i++)
{
    arr[i] =rand.Next(20); 
    Console.Write("{0} ", arr[i]);
}
Console.WriteLine();
for(int i = 0; i<arr.Length; i++)
{
    if( i % 2 == 1)
     i++;
    else
     sum = sum +arr[i];

}
Console.WriteLine();
Console.WriteLine( "Cумма не четных элементов {1}", sum);










