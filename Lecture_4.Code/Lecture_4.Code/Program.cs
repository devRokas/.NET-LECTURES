using System;
using System.Text;

 

namespace Lecture04
{
    class Program
    {
        static void Main(string[] args)
        {
            //ANTRA UZDUOTIS

 

            Console.Write("Kiek skaiciu norite ivesti: ");

 

            var numIter = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[numIter];

         

            for (var i = 0; i < numIter; i++)
            {
                Console.Write("Iveskite skaiciu: ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

 

            Console.Write("Pradinis masyvas: ");
            ToPrint(arr);

 

            Console.WriteLine($"Ivestu skaiciu suma: {CalcSum(arr)}");
            Console.WriteLine($"Ivestu skaiciu vidurkis: {CalcAverage(arr)}");
            Console.WriteLine($"Didziausias ivestas skaicius: {FindMax(arr)}");
            Console.WriteLine($"Maziausias ivestas skaicius: {FindMin(arr)}");

 

            Console.Write("Apverstas masyvas: ");
            ToPrint(ReverseArr(arr));

 

            Console.Write("Didejimo tvarka isdestytas masyvas: ");
            ToPrint(SortAsc(DublicateArr(arr)));

 

            Console.Write("Mazejimo tvarka isdestytas masyvas: ");
            ToPrint(SortDes(DublicateArr(arr)));

 

            Console.Write("Pradinis masyvas liko nepakites: ");
            ToPrint(arr);
            
        }

 

        //ANTRA UZDUOTIS
        private static double CalcSum(double[] arr)
        {
            double sum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }





 

        private static double CalcAverage(double[] arr)
        {
            var average = CalcSum(arr) / arr.Length;

 

            return average;
        }

 

        private static double FindMax(double[] arr)
        {
            double max = arr[0];

 

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

 

            return max;
        }

 

        private static double FindMin(double[] arr)
        {
            double min = arr[0];

 

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

 

            return min;
        }

 

        private static double[] ReverseArr(double[] arr)
        {
            double[] arrNew = new double[arr.Length];

 

            for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
            {
                arrNew[j] = arr[i];
            }

 

            return arrNew;
        }

 

        private static double[] DublicateArr(double[] arr)
        {
            double[] arrNew = new double[arr.Length];

 

            for (var i = 0; i < arr.Length; i++)
            {
                arrNew[i] = arr[i];
            }

 

            return arrNew;
        }

 

        private static double[] SortAsc(double[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

 

            return arr;
        }

 

        private static double[] SortDes(double[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

 

            return arr;
        }

 

        private static void ToPrint(double[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

 

    }
}