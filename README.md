####Условие задачи: 

Дано слово, определить, сколько различных букв в нем.

Программа работает на языке C#. Входным данным является строка s, которая представляет собой слово. С помощью функции ToCharArray() преобразуем исходное слово в массив элементов Unicode. Для этого заводим переменную s1 типа char. Далее, заводим переменную s2 типа char и с помощью функции Distinct() удаляем все повторные элементы из массива s1. Теперь нам необходимо посчитать количество элементов массива s2, содержащего неповторные элементы. Это осуществляется с помощью функции Count().

####Примечания:

1. Строка s должна являться словом.
2. Не допускается ввод чисел и иных символов.
