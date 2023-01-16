using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stoyanka
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> parking = new Stack<int>();
            bool stop = false;

            while (!stop)
            {
                Console.WriteLine("Для размещения заказа введите: въехать на стоянку ");
                Console.WriteLine("Для выполнения заказа введите: покинуть стоянку ");
                Console.WriteLine("Для выхода из программы введите: выход ");
                string command = Console.ReadLine();
                if (command == "въехать на стоянку" & parking.Count < 5)        //  Задаем размер стека
                {
                    Console.WriteLine("Введите номер борта: ");
                    string inputNumber = Console.ReadLine();

                    if (Int32.TryParse(inputNumber, out int numberBort))
                    {
                        parking.Push(numberBort);                         // Добавляем заказ в стек
                        Console.WriteLine("Количество самолетов на стоянке {0}", parking.Count);  // Выводим размер стека
                        Console.WriteLine("Готов покинуть стоянку борт №{0}", parking.Peek());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(">>> Некорректный ввод номера! <<<");
                    }
                }
                else if (command == "покинуть стоянку")
                {
                    if (parking.Count == 0) { Console.WriteLine("Стоянка пуста."); }
                    else
                    {
                        var v = parking.Pop();     //  Удаляем заказ из очереди

                        Console.WriteLine("Борт №{0} покинул стоянку", v);   //  Выводим удаленный элемент на экран
                        Console.WriteLine();
                        if (parking.Count == 0) { Console.WriteLine("Стоянка пуста."); }
                        else
                        {
                            Console.WriteLine("Готов покинуть стоянку борт №{0}", parking.Peek());//  Выводим следующий элемент на экран
                            Console.WriteLine();
                        }
                        
                    }
                }
                else if (command == "выход")
                {
                    stop = true;
                }
                else if (parking.Count >= 5)
                {
                    Console.WriteLine("Стоянка заполнена, мест нет. СОВСЕМ НЕТ!!!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(">>> Вы ввели некорректное значение. <<<");
                    Console.WriteLine();
                }
            }
        }
    }
}
