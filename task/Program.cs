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
                array=Random_matrix_int(m,n);
                Console.WriteLine("Исходный массив");
                Write_matrix_int(array,m,n);
                Console.WriteLine();
                Matrix_Row_MaxToMin(array,m,n);
                Console.WriteLine("Новый массив");
                Write_matrix_int(array,m,n);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }


        static void Task2(){
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
                array=Random_matrix_int(m,n);
                Console.WriteLine("Исходный массив");
                Write_matrix_int(array,m,n);
                Seach_min_row(array,m,n);
            }
  
            
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Task3(){
            Console.WriteLine();
            Console.WriteLine();
            
            int col1=3;
            int col2=2;
            int row1=2;
            int row2=3;
            int[,] matrix1=new int[row1,col1];
            int[,] matrix2=new int[row2,col2];
            int[,] matrix_result=new int[row1,col2];
            matrix1=Random_matrix_int(row1,col1);
            matrix2=Random_matrix_int(row2,col2);
            Console.WriteLine("Матрица 1");
            Write_matrix_int(matrix1,row1,col1);
            Console.WriteLine("Матрица 2");
            Write_matrix_int(matrix2,row2,col2);
            
            Console.WriteLine();
            matrix_result=Multiplication_matrix(matrix1,matrix2);
            Console.WriteLine("Результат умножения двух матриц");
            Write_matrix_int(matrix_result,matrix_result.GetLength(0),matrix_result.GetLength(1));
            
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Task4(){
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Введите размерность трехмерного массива plane, row, col  (через пробел)");
            string str=Console.ReadLine();
            string[] str_arr=str.Split(' ');
            int size=str_arr.Length;
            if(size!=3){
                return;
            }            
            if(Int32.TryParse(str_arr[0], out int plane) && Int32.TryParse(str_arr[1], out int row) && Int32.TryParse(str_arr[2], out int col)){
                int[,,] array=new int[plane,row,col];
                Filling_3d_array(array,plane,row,col);
                Write_3d_array_and_index(array,plane,row,col);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }


        static void Task5(){
            Console.WriteLine();
            Console.WriteLine();
            
            int row=4;
            int col=4;
            int[,] matrix=new int[row,col];
            Filling_matrix_spiral(matrix,row,col);
            Write_matrix_int(matrix,row,col);
            
            Console.WriteLine();
            Console.WriteLine();
        }

        static int[,] Random_matrix_int(int row, int col){
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
                Sorted_array(arr,i,col);
            }
        }

        static void Sorted_array(int[,] arr, int numRow, int size){
            for (int j = 0; j < size; j++)
            {
                int max=arr[numRow,j];
                int index=j;
                for (int i = j; i < size; i++)
                {
                    if(max<arr[numRow,i]){
                        max=arr[numRow,i];
                        index=i;
                    }
                }
                int temp=arr[numRow,j];
                arr[numRow,j]=arr[numRow,index];
                arr[numRow,index]=temp;
            }
        }

        static void Seach_min_row(int[,] arr, int row, int col){
            int[] summa_el_row=new int[row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    summa_el_row[i]+=arr[i,j];
                }
            }
            int min=summa_el_row[0];
            int index=0;
            for (int i = 0; i < row; i++)
            {
                if(min>summa_el_row[i]){
                    min=summa_el_row[i];
                    index=i;
                }
            }
            Console.WriteLine($"Индекс строки с минимальной суммой элементов равен {index}");
        }

        static void Filling_3d_array(int[,,] arr, int plane, int row, int col){
            int el=0;
            for (int i = 0; i < plane; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    for (int k = 0; k < col; k++)
                    {
                        arr[i,j,k]=el;
                        el++;
                    }
                }
            }
        }

        static void Write_3d_array_and_index(int[,,] arr, int plane, int row, int col){
            int el=0;
            for (int i = 0; i < plane; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    for (int k = 0; k < col; k++)
                    {
                        Console.Write(arr[i,j,k] + " " + $"({i},{j},{k})  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static int[,] Multiplication_matrix(int[,] mat1, int[,] mat2){ 
            int[,] result = new int[mat1.GetLength(0),mat2.GetLength(1)];
            for (int k = 0; k < mat1.GetLength(0); k++)
            {
               for (int i = 0; i < mat2.GetLength(1); i++)
                {
                    for (int j = 0; j < mat2.GetLength(0); j++)
                    {
                        result[k,i]+=mat1[k,j]*mat2[j,i];
                    }
                } 
            }
            return result;
        }

        static void Filling_matrix_spiral(int[,] mat,int row, int col){
            int size=row*col;
            int el=1;
            int index_col_min=0;
            int index_row_min=0;
            int index_col_max=col-1;
            int index_row_max=row-1;
            while(el<size){
                for (int j = index_col_min; j <= index_col_max; j++)
                {
                    mat[index_row_min,j]=el;
                    el++;
                    Console.WriteLine(mat[index_row_min,j] + $"  ({index_row_min},{j})");
                }
                for (int i = index_row_min+1; i <= index_row_max; i++)
                {
                    mat[i,index_col_max]=el;
                    el++;
                    Console.WriteLine(mat[i,index_col_max] + $"  ({i},{index_col_max})");
                }
                index_col_max--;
                for(int j = index_col_max; j >= index_col_min; j--){
                    mat[index_row_max,j]=el;
                    el++;
                    Console.WriteLine(mat[index_row_max,j] + $"  ({index_row_max},{j})");
                }
                index_row_max--;
                index_row_min++;
                for (int i=index_row_max; i >= index_row_min; i--)
                {
                    mat[i,index_col_min]=el;
                    el++;                    
                    Console.WriteLine(mat[i,index_col_min] + $"  ({i},{index_col_min})");
                }
                index_col_min++;
            }
        }

    }
}
