using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while(true){
                Console.WriteLine("Задача 1. \nЗадайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива");
                Console.WriteLine("Задача 2. \nЗадайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
                Console.WriteLine("Задача 3. \nЗадайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
                Console.WriteLine("Задача 4. \nСформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента");
                Console.WriteLine("Задача 5. \nНапишите программу, которая заполнит спирально массив 4 на 4.");
                Console.WriteLine("Введите номер задачи, которую необходимо решить. Если хотите выйти из программы, напишите 0.\n");
                int num=Convert.ToInt32(Console.ReadLine());
                switch (num){
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        return;
                        break;
                }
            }
        }

        static void Task1(){
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Введите размерность двухмерного массива m на n (через пробел)");
            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int size=str_arr.Length;
            if(size!=2){
                return;
            }            
            if(Int32.TryParse(str_arr[0], out int m) && Int32.TryParse(str_arr[1], out int n)){
                int[,] array=new int[m,n];
                int[,] array_new=new int[m,n];
                array=Random_array_int(m,n);
                Console.WriteLine("Исходный массив");
                Write_matrix_int(array,m,n);
                Console.WriteLine();
                array_new=Matrix_Row_MaxToMin(array,m,n);
                Console.WriteLine("Новый массив");
                Write_matrix_int(array_new,m,n);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }


        static void Task2(){
            Console.WriteLine();
            Console.WriteLine();
            
            // Console.WriteLine("Введите размерность двухмерного массива m на n (через пробел)");
            // string str=Console.ReadLine();
            // string[] str_arr=str.Split(' ');
            // int size=str_arr.Length;
            // if(size!=2){
            //     return;
            // }            
            // if(Int32.TryParse(str_arr[0], out int m) && Int32.TryParse(str_arr[1], out int n)){
            //     int[,] array=new int[m,n];
            //     array=Random_array_int(m,n);
            //     Console.WriteLine("Исходный массив");
            //     Write_matrix_int(array,m,n);

            // }
            int[,] array=new int[,] {{0,1,2,3,4,5,6,7,8}, {0,1,2,3,4,5,6,7,8} };
            Matrix_Row_MaxToMin(array,array.GetLength(0),array.GetLength(0));
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Task3(){
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Введите размерность двухмерного массива m на n (через пробел)");
            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int size=str_arr.Length;
            if(size!=2){
                return;
            }            
            if(Int32.TryParse(str_arr[0], out int m) && Int32.TryParse(str_arr[1], out int n)){
                double[,] array=new double[m,n];
                //array=Random_array_double(m,n);
                //Write_matrix_double(array,m,n);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Task4(){
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Введите размерность двухмерного массива m на n (через пробел)");
            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int size=str_arr.Length;
            if(size!=2){
                return;
            }            
            if(Int32.TryParse(str_arr[0], out int m) && Int32.TryParse(str_arr[1], out int n)){
                double[,] array=new double[m,n];
                //array=Random_array_double(m,n);
                //Write_matrix_double(array,m,n);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }


        static void Task5(){
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Введите размерность двухмерного массива m на n (через пробел)");
            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int size=str_arr.Length;
            if(size!=2){
                return;
            }            
            if(Int32.TryParse(str_arr[0], out int m) && Int32.TryParse(str_arr[1], out int n)){
                double[,] array=new double[m,n];
                //array=Random_array_double(m,n);
                //Write_matrix_double(array,m,n);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }

        static int[,] Random_array_int(int row, int col){
            int[,] arr=new int[row,col];
            var rnd=new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j]=rnd.Next(1,10);
                }
            }
            return arr;
        }

        static void Write_matrix_int(int[,] arr, int str, int col){
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Matrix_Row_MaxToMin(int[,] arr, int row, int col){
            for (int i = 0; i < row; i++)
            {
                Sorted_array(arr[i],col);
            }
        }

        static void Sorted_array(int[] arr, int size){
            for (int j = 0; j < size; j++)
            {
                int max=arr[j];
                int index=j;
                for (int i = j; i < size; i++)
                {
                    if(max<arr[i]){
                        max=arr[i];
                        index=i;
                    }
                }
                int temp=arr[j];
                arr[j]=arr[index];
                arr[index]=temp;
            }
        }

    }
}
