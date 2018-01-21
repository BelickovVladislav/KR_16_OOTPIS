using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_16_OOTPIS
{
    class Program
    {
        /*вариант 16.
1. Разработать класс реализующий список (однонаправленная очередь). Элемент
списка содержит информацию о товаре на складе фирмы. Элемент очереди
содержит наименование товара, цену, количество и дату поставки. В классе
реализовать методы поставки на склад, отгрузки со склада и формирования
информации по выбранному товару.
2. Создать несколько объектов (например, a и b) разработанного класса. Класс –
вектор (одномерный массив). Реализовать для объектов данного класса перегрузку
операции () (a(i)=k и k=b(i)). Содержимое объектов (a,b их векторов), до и после
выполнения операции, вывести на экран.
3. Создать иерархию классов представляющих простое наследование. Базовый
класс – квадратная матрица (динамическая (int **mt или int* или int *mt[константа])).
Производный класс – методы, работающие с данными базового класса. Реализовать
в производном классе метод – поэлементной замены местами элементов главной и
побочной диагоналей.

    */
        static void Main(string[] args)
        {
            ProductList productList = new ProductList();
            //Добавление на склад
            productList.Add(new Product("Апельсин", "21.12.2017", 1.5, 200));
            productList.Add(new Product("Мандарин", "21.12.2017", 2, 200));
            productList.Add(new Product("Ананас", "21.12.2017", 3, 201));
            productList.Add(new Product("Санки", "25.01.2017", 350, 500));
            productList.Add(new Product("Абрикос", "21.12.2017", 1, 200));
            productList.Add(new Product("Манго", "21.12.2017", 4, 208));
            productList.Add(new Product("Конфеты", "21.12.2017", 8, 222));

            Console.WriteLine(productList);
            //Выгрузка со склада
            productList.Unloading(4, 2000);
            Console.WriteLine(productList);
            Product k = new Product();

            //Демонстрация перегрузки индексатора
            Console.WriteLine();
            productList[0] = k;
            Console.WriteLine(productList);

            Console.WriteLine("==================================================");
            Matrix matrix = new Matrix(5);
            Console.WriteLine(matrix);
            matrix.ReplaceDiagonals();
            Console.WriteLine(matrix);
            Console.ReadKey();
        }
    }
}
