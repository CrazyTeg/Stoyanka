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
            Stack<int> camp = new Stack<int>();
            bool stop = false;

            while (!stop)
            {

                Console.WriteLine("Для размещения заказа введите: въехать на стоянку ");
                Console.WriteLine("Для выполнения заказа введите: покинуть стоянку ");
                Console.WriteLine("Для выхода из программы введите: выход ");
                var command = Console.ReadLine();
                if (command == "въехать на стоянку" & camp.Count < 5)        //  Задаем лимит очереди
                {
                    Console.WriteLine("Введите номер борта: ");
                    Fond2:
                    var nomer = Console.ReadLine();

                    if (Int32.TryParse(nomer, out int numz)) { }
                    else
                    {
                        Console.WriteLine(">>> Некорректный ввод, введите номер: <<<");
                        goto Fond2;
                    }
                    camp.Push(numz);                         // Добавляем заказ в очередь
                    Console.WriteLine("Количество самолетов на стоянке {0}", camp.Count);  // Выводим размер очереди
                    Console.WriteLine("Готов покинуть стоянку борт №{0}", camp.Peek());
                    Console.WriteLine();
                }
                else if (command == "покинуть стоянку")
                {
                    if (camp.Count == 0) { Console.WriteLine("Стоянка пуста."); }
                    else
                    {
                        var v = camp.Pop();     //  Удаляем заказ из очереди

                        Console.WriteLine("Борт №{0} покинул стоянку", v);   //  Выводим удаленный элемент на экран
                        Console.WriteLine();
                        if (camp.Count == 0) { Console.WriteLine("Стоянка пуста."); }
                        else
                        {
                            Console.WriteLine("Готов покинуть стоянку борт №{0}", camp.Peek());//  Выводим следующий элемент на экран
                            Console.WriteLine();
                        }
                        
                    }
                }
                else if (command == "выход")
                {
                    stop = true;
                }
                else if (camp.Count >= 5)
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
