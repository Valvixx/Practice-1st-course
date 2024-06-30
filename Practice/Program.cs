﻿namespace Practice;

class Program
{
    //метод для обмена элементов
    static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }

    static int[] ShellSort(int[] array)
    {
        //расстояние между элементами, которые сравниваются
        var d = array.Length / 2;
        while (d >= 1)
        {
            for (var i = d; i < array.Length; i++)
            {
                var j = i;
                while ((j >= d) && (array[j - d] > array[j]))
                {
                    Swap(ref array[j], ref array[j - d]);
                    j = j - d;
                }
            }

            d = d / 2;
        }

        return array;
    }
    
    static void Main(string[] args)
    {
    }
}