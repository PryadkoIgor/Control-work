Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно вводить с клавиатуры, либо задать на старте выполнения алгоритма. При решении задачи не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":)"] -> ["2", ":)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

Решение задачи:
Согласно условию задания, первоначальный массив вводися либо с клавиатуры, либо он задается на старте. Ввод массива реализован методом ввода с клавиатуры "Yes" или "No".
При вводе "Yes" сначала вводим количество строк массива (ввод реализован в виде функции "InputNumbers"), затем заполняем этот массив.
При вводе "No" первоначальный массив имеет значение: ["hello", "2", "world", ":-)"]
Переменная "lengthLimit" - согласно заданию равна 3.

"CheckArray" - Это метод подсчёта количества элементов, размер которых меньше "lengthLimit"
Подсчёт осуществляется перебором элементов массива "arrayOnStrings" и сравнением их количества с переменной "lengthLimit".
Результат выводим в переменную "numbersItems".
Инициализируем новый массив строк "newArrayOnStrings", размером, равным переменной "numbersItems".

"FillNewArray" - Это метод формирования нового массива строк.
Формирование осуществляем перебором элементов массива "arrayOfStrings", сравнением количества элементов с переменной "lengthLimit" и добавлением в массив "newArrayOfStrings" элемента, удовлетворяющего условию.
На выходе метода получается заполненный массив строк "newArrayOfStrings", удовлетворяющий условию, что является решением задачи.
С помощью "PrintArray" выводим на экран.