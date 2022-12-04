using System;

namespace work14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];//задаем количество элементов целочисленного массива
            Random r = new Random(); //рандомая переменная

            Console.WriteLine("Изначальный массив"); //вывод на консоль
            for (int a = 0; a < mass.Length; ++a) //цикл, пока верно условие
            {
                mass[a] = r.Next(0, 100); //задание массива
                Console.Write(mass[a] + " "); //вывод на консоль массива
            }

            int b; //объявление целочисленной переменной

            for (int i = 0; i < mass.Length - 1; i++) //цикл, пока верно условие, задан элемент массива i
            {
                for (int j = i + 1; j < mass.Length; j++) //цикл, пока верно условие, задается следующий после i элемент массива
                {
                    if ((mass[i] % 2 != 0) && (mass[j] % 2 != 0) && (mass[i] > mass[j])) //выполняется, если верно условие
                    {
                        b = mass[i]; //присвоение b значения элемента i
                        mass[i] = mass[j];  //присвоения значение элементу j
                        mass[j] = b; //присвоение значения элементу j
                    }
                }
            }

            Console.WriteLine("");//
            Console.WriteLine("Отсортированный массив(нечетные числа)");  // вывод на консоль
            for (int i = 0; i < mass.Length; i++) //цикл, пока верно условие
            {
                Console.Write(mass[i] + " "); //вывод массива
            }
            Console.ReadLine(); //программа ждет нажатия клавиши для завершения отладки
        }
    }
}