## Task

> **Цель работы**:
> приобрести базовые навыки работы с файловой системой в Java.
>
> ### Задание 1
>
> Напишите программу,
> выполняющую чтение текстовых данных из файла и их последующую обработку:
> 
> **Вариант 5**.
> Напишите программу, которая cчитывает текст и печатает таблицу,
> показывающую, сколько раз в этом тексте встречаются однобуквенные слова,
> двухбуквенные слова, трехбуквенные слова и т.д.
> 
> ### Задание 2
> 
> Написать консольную утилиту, обрабатывающую ввод пользователя и дополнительные ключи.
> Проект упаковать в jar-файл, написать bat-файл для запуска.
> 
> **Вариант 5**.
> Утилита `cp` осуществляет копирование файла из одного каталога в другой.
> Исходный файл остаётся неизменным, имя созданного файла может быть таким же,
> как у исходного, или измениться.
> 
> Формат использования: `cp [-f][-i][-n] исходный_файл целевой_файл`
> - `-f` Разрешает удаление целевого файла,
> в который производится копирование,
> если он не может быть открыт для записи.
> - `-i` Утилита будет запрашивать, следует ли перезаписывать конечный файл,
> имя которого совпадает с именем исходного.
> Для того, чтобы перезаписать файл,
> следует ввести y или его эквивалент.
> Ввод любого другого символа приведёт к отмене перезаписи данного файла.
> - `-n` Не перезаписывать существующий файл (отменяет предыдущий параметр `-i` ).
> 
> Пример использования: `cp -fn src.txt dest.txt`.
> 
> Копирует содержимое из `src.txt` в `dest.txt` с ключами `-f` и `-n`.
> 