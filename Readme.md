## Студент: Маслаков Роман 
## Курс Разработчик

***

### **Итоговая проверочная работа первого блока обучения**

**Задача:** написать программу, которая из имеющегося массива формирует массив из строк, длина которых меньше, либо равна 3 символам.

---

### **Решение:** 
Для решения нам нужны 3 метода:
* MakeArray() - метод выводит на экран сообщение для пользователя и принимает от него строки. Далее идет проверка на содержимое, если строка пустая, значение не принимается, в положительном исходе метод добавляет строку в массив, если идет команда Stop, метод прекращает свою работу и возвращает созданный массив
*  SortArray() - метод принимает на вход массив строк, далее создается новый массив, в который метод добавляет те строки из принятого массива, которые прошли проверку. Обработав все значения метод возвращает новый массив
* ConvertArray() - преобразовывает массив в строку

**Действия:**

1. Создаем массив с помощью метода MakeArray()
2. Вывод заданного массива и его отсортированную с помощью SortArray версию, после того как преобразуем оба массива в строку с помощью ConvertArray 