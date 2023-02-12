# csharp_extra

## Задача
Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа.  
Первоначальный массив можно ввести с клавиатура, либо задать на старте выполнения алгоритма.  
При решении не рекомендуется пользоваться коллекциями, лучше обойтися исключительно массивами.

### Примеры
```
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
```

## Использованный алгоритм решения
Решено выполнинить задачу в 2 этапа:  
1. Проанализировать полученный массив, получив количество подходящих по длинне элементов
2. Создать результирующий массив и заполнить его подходящими элементами
