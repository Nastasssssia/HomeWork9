using MyLib;
namespace HomeWork9;

class Program
{
    static void Main(string[] args)
    {
        //Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
       
       void Task64()
       {
            void Recursion64(int i, int n)
            {
                if(i > n) return;
                if (i % 3 == 0) Console.Write($"{i} ");
                Recursion64(i+1, n);
        }
        
        int m = MyLibClass.Input("Ведите начальную точку промежутка:");
        int n = MyLibClass.Input("Ведите конечную точку промежутка:");
        Recursion64(m, n);
        
       }
       
       void Task66()
       {
            //Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
            int Recursion66(int currentNum,int n)
            {
                if(currentNum > n) return 0;
                return currentNum + Recursion66(currentNum+1,n);
            }
        
        int m = MyLibClass.Input("Ведите начальную точку промежутка:");
        int n = MyLibClass.Input("Ведите конечную точку промежутка:");
        Console.Write($"Сумма чисел в промежутке от {m} до {n} = {Recursion66(m, n)}");
        }


       void Task68()
       {
            //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

            int Akkerman( int m,  int n)
            {
            
                if (m < 0 || n < 0) return 0;
                else if (m == 0) return n + 1;
                else if (n == 0) return Akkerman(m - 1, 1);
                else if (m > 0 && n >0) return Akkerman(m-1, Akkerman(m, n-1));

                return 0;
           }

            
           
            int m = MyLibClass.Input("введите число m:");
            int n = MyLibClass.Input("введите число n:");
            Console.WriteLine($"{Akkerman(m,n)}");
            
       }

       Task68();
        
    }
}
