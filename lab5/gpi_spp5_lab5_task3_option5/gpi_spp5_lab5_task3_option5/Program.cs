/*
Лаб 5

В задании 3 ЛР №4, где возможно,
заменить объявления суперклассов объявлениями абстрактных классов или интерфейсов.

Лаб 4

Задание 3
Построить модель программной системы с применением отношений
(обобщения, агрегации, ассоциации, реализации) между классами.
Задать атрибуты и методы классов.
Реализовать (если необходимо) дополнительные классы.
Продемонстрировать работу разработанной системы.

Вариант 5
Система Библиотека. Читатель оформляет Заказ на Книгу.
Система осуществляет поиск в Каталоге.
Библиотекарь выдает Читателю Книгу на абонемент или в читальный зал.
При невозвращении Книги Читателем он может быть занесен Администратором в <<черный список>>. 
*/

namespace gpi_spp5_lab5_task3_option5_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            gpi_Library obj = new gpi_Library();
            obj.gpi_main();
        }
    }
}