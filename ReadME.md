**Задача:**
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

1. Решение задачи кодом, в папке SolutionCOD
2. Алгоритм метода файл algorithm

**Описание решения:**
*Объявляем два массива: изначальный и второй (такой же длины). Создаем метод, в котором цикл соразмерный длине массива, внутри цикла проверка условия  <=3 , если да, то элемент первого массива, заносится в count элемент второго массива. После присвоения увеличивается переменная count на 1 и возвращается к циклу for, в котором i увеличивается на 1. И так до конца.*
