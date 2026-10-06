using System;

namespace PracticalWork3
{
    class Program
    {
        static void Main(string[] args)
        {         
            switch (taskNumber)
            {
                case 1:
                    {
                        // 1. Пользователь вводит целое число. Проверить, является ли оно положительным.
                        Console.Write("Введите целое число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number > 0)
                            Console.WriteLine("Число положительное.");
                        else
                            Console.WriteLine("Число не является положительным.");
                        break;
                    }
                case 2:
                    {
                        // 2. Пользователь вводит целое число. Проверить, является ли оно четным.
                        Console.Write("Введите целое число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 2 == 0)
                            Console.WriteLine("Число четное.");
                        else
                            Console.WriteLine("Число нечетное.");
                        break;
                    }
                case 3:
                    {
                        // 3. Даны два целых числа. Вывести наибольшее из них.
                        Console.Write("Введите первое целое число: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("Введите второе целое число: ");
                        int b = int.Parse(Console.ReadLine());

                        if (a > b)
                            Console.WriteLine("Наибольшее число: " + a);
                        else
                            Console.WriteLine("Наибольшее число: " + b);
                        break;
                    }
                case 4:
                    {
                        // 4. Даны два числа с плавающей точкой. Вывести наименьшее.
                        Console.Write("Введите первое число: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double b = double.Parse(Console.ReadLine());

                        if (a < b)
                            Console.WriteLine("Наименьшее число: " + a);
                        else
                            Console.WriteLine("Наименьшее число: " + b);
                        break;
                    }
                case 5:
                    {
                        // 5. Проверить, делится ли введенное число нацело на 5.
                        Console.Write("Введите число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 5 == 0)
                            Console.WriteLine("Число делится на 5 без остатка.");
                        else
                            Console.WriteLine("Число не делится на 5 без остатка.");
                        break;
                    }
                case 6:
                    {
                        // 6. Проверить, оканчивается ли введенное целое число нулем.
                        Console.Write("Введите целое число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 10 == 0)
                            Console.WriteLine("Число оканчивается нулем.");
                        else
                            Console.WriteLine("Число не оканчивается нулем.");
                        break;
                    }
                case 7:
                    {
                        // 7. Пользователь вводит температуру воздуха. Если она ниже нуля, вывести: «На улице мороз, наденьте шапку».
                        Console.Write("Введите температуру воздуха: ");
                        double temperature = double.Parse(Console.ReadLine());

                        if (temperature < 0)
                            Console.WriteLine("На улице мороз, наденьте шапку");
                        break;
                    }
                case 8:
                    {
                        // 8. Дано число. Если оно больше 100, уменьшить его на 20, иначе увеличить на 10.
                        Console.Write("Введите число: ");
                        double number = double.Parse(Console.ReadLine());

                        if (number > 100)
                            number = number - 20;
                        else
                            number = number + 10;

                        Console.WriteLine("Результат: " + number);
                        break;
                    }
                case 9:
                    {
                        // 9. Ввести два числа. Если они равны, вывести «Числа равны», иначе вывести их произведение.
                        Console.Write("Введите первое число: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double b = double.Parse(Console.ReadLine());

                        if (a == b)
                            Console.WriteLine("Числа равны");
                        else
                            Console.WriteLine("Произведение: " + (a * b));
                        break;
                    }
                case 10:
                    {
                        // 10. Пользователь вводит свой возраст. Если возраст от 18 и старше, вывести «Доступ разрешен», иначе «Доступ запрещен».
                        Console.Write("Введите возраст: ");
                        int age = int.Parse(Console.ReadLine());

                        if (age >= 18)
                            Console.WriteLine("Доступ разрешен");
                        else
                            Console.WriteLine("Доступ запрещен");
                        break;
                    }
                case 11:
                    {
                        // 11. Ввести число. Если оно трехзначное, вывести «Да», иначе «Нет».
                        Console.Write("Введите число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number >= 100 && number <= 999)
                            Console.WriteLine("Да");
                        else
                            Console.WriteLine("Нет");
                        break;
                    }
                case 12:
                    {
                        // 12. Проверить, делится ли число на 3 без остатка.
                        Console.Write("Введите число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 3 == 0)
                            Console.WriteLine("Число делится на 3 без остатка.");
                        else
                            Console.WriteLine("Число не делится на 3 без остатка.");
                        break;
                    }
                case 13:
                    {
                        // 13. Даны координаты точки на числовой прямой X. Определить, лежит ли точка правее нуля.
                        Console.Write("Введите координату X: ");
                        double x = double.Parse(Console.ReadLine());

                        if (x > 0)
                            Console.WriteLine("Точка лежит правее нуля.");
                        else
                            Console.WriteLine("Точка не лежит правее нуля.");
                        break;
                    }
                case 14:
                    {
                        // 14. Ввести баланс счета. Если баланс отрицательный, вывести «Задолженность!».
                        Console.Write("Введите баланс счета: ");
                        double balance = double.Parse(Console.ReadLine());

                        if (balance < 0)
                            Console.WriteLine("Задолженность!");
                        break;
                    }
                case 15:
                    {
                        // 15. Пользователь вводит пароль (целое число). Если введен 1234, вывести «Вход выполнен», иначе «Неверный пароль».
                        Console.Write("Введите пароль: ");
                        int password = int.Parse(Console.ReadLine());

                        if (password == 1234)
                            Console.WriteLine("Вход выполнен");
                        else
                            Console.WriteLine("Неверный пароль");
                        break;
                    }
                case 16:
                    {
                        // 16. Проверить, является ли введенное число отрицательным.
                        Console.Write("Введите число: ");
                        double number = double.Parse(Console.ReadLine());

                        if (number < 0)
                            Console.WriteLine("Число отрицательное.");
                        else
                            Console.WriteLine("Число не является отрицательным.");
                        break;
                    }
                case 17:
                    {
                        // 17. Даны два числа. Вывести разность большего и меньшего числа.
                        Console.Write("Введите первое число: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double b = double.Parse(Console.ReadLine());

                        if (a > b)
                            Console.WriteLine("Разность: " + (a - b));
                        else
                            Console.WriteLine("Разность: " + (b - a));
                        break;
                    }
                case 18:
                    {
                        // 18. Ввести сумму покупки. Если сумма превышает 1000 рублей, предоставить скидку 5% и вывести итоговую цену.
                        Console.Write("Введите сумму покупки: ");
                        double sum = double.Parse(Console.ReadLine());

                        double finalPrice;

                        if (sum > 1000)
                            finalPrice = sum * 0.95;
                        else
                            finalPrice = sum;

                        Console.WriteLine("Итоговая цена: " + finalPrice + " руб.");
                        break;
                    }
                case 19:
                    {
                        // 19. Ввести число. Если оно четное, разделить его на 2, если нечетное — умножить на 3.
                        Console.Write("Введите число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 2 == 0)
                            number = number / 2;
                        else
                            number = number * 3;

                        Console.WriteLine("Результат: " + number);
                        break;
                    }
                case 20:
                    {
                        // 20. Пользователь вводит скорость движения. Если скорость выше 90 км/ч, вывести сообщение о нарушении.
                        Console.Write("Введите скорость движения (км/ч): ");
                        double speed = double.Parse(Console.ReadLine());

                        if (speed > 90)
                            Console.WriteLine("Нарушение");
                        break;
                    }
                case 21:
                    {
                        // 21. Дано целое число. Проверить, равно ли оно нулю.
                        Console.Write("Введите целое число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number == 0)
                            Console.WriteLine("Число равно нулю.");
                        else
                            Console.WriteLine("Число не равно нулю.");
                        break;
                    }
                case 22:
                    {
                        // 22. Ввести два вещественных числа. Проверить, равны ли они с точностью до 0.001.
                        Console.Write("Введите первое число: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double b = double.Parse(Console.ReadLine());

                        if (Math.Abs(a - b) <= 0.001)
                            Console.WriteLine("Числа равны с точностью до 0.001.");
                        else
                            Console.WriteLine("Числа не равны с точностью до 0.001.");
                        break;
                    }
                case 23:
                    {
                        // 23. Проверить, делится ли число A на число B без остатка.
                        Console.Write("Введите число A: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("Введите число B: ");
                        int b = int.Parse(Console.ReadLine());

                        if (b == 0)
                        {
                            Console.WriteLine("Деление на ноль невозможно.");
                        }
                        else if (a % b == 0)
                        {
                            Console.WriteLine("A делится на B без остатка.");
                        }
                        else
                        {
                            Console.WriteLine("A не делится на B без остатка.");
                        }
                        break;
                    }
                case 24:
                    {
                        // 24. Даны два угла треугольника в градусах. Проверить, существует ли такой треугольник (сумма меньше 180).
                        Console.Write("Введите первый угол: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите второй угол: ");
                        double b = double.Parse(Console.ReadLine());

                        if (a + b < 180)
                            Console.WriteLine("Такой треугольник существует.");
                        else
                            Console.WriteLine("Такой треугольник не существует.");
                        break;
                    }
                case 25:
                    {
                        // 25. Ввести радиус круга и сторону квадрата. Определить, у какой фигуры площадь больше.
                        Console.Write("Введите радиус круга: ");
                        double radius = double.Parse(Console.ReadLine());

                        Console.Write("Введите сторону квадрата: ");
                        double side = double.Parse(Console.ReadLine());

                        double circleArea = Math.PI * radius * radius;
                        double squareArea = side * side;

                        if (circleArea > squareArea)
                            Console.WriteLine("Площадь круга больше.");
                        else if (squareArea > circleArea)
                            Console.WriteLine("Площадь квадрата больше.");
                        else
                            Console.WriteLine("Площади равны.");
                        break;
                    }
                case 26:
                    {
                        // 26. Ввести два числа. Вывести частное большего на меньшее (предусмотреть проверку деления на 0).
                        Console.Write("Введите первое число: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double b = double.Parse(Console.ReadLine());

                        double greater;
                        double smaller;

                        if (a > b)
                        {
                            greater = a;
                            smaller = b;
                        }
                        else
                        {
                            greater = b;
                            smaller = a;
                        }

                        if (smaller == 0)
                            Console.WriteLine("Деление на 0 невозможно.");
                        else
                            Console.WriteLine("Частное: " + (greater / smaller));
                        break;
                    }
                case 27:
                    {
                        // 27. Проверить, является ли последняя цифра числа семеркой.
                        Console.Write("Введите число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (Math.Abs(number) % 10 == 7)
                            Console.WriteLine("Последняя цифра — 7.");
                        else
                            Console.WriteLine("Последняя цифра не равна 7.");
                        break;
                    }
                case 28:
                    {
                        // 28. Дано число. Если оно нечетное и положительное, вывести «Да».
                        Console.Write("Введите число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number > 0 && number % 2 != 0)
                            Console.WriteLine("Да");
                        else
                            Console.WriteLine("Нет");
                        break;
                    }
                case 29:
                    {
                        // 29. Ввести объем свободного места на диске (в ГБ). Если места меньше 5 ГБ, вывести предупреждение.
                        Console.Write("Введите свободное место на диске (ГБ): ");
                        double freeSpace = double.Parse(Console.ReadLine());

                        if (freeSpace < 5)
                            Console.WriteLine("Предупреждение: мало свободного места на диске.");
                        break;
                    }
                case 30:
                    {
                        // 30. Пользователь вводит оценку (2, 3, 4, 5). Если оценка 4 или 5, вывести «Молодец», иначе «Нужно подтянуться».
                        Console.Write("Введите оценку (2, 3, 4, 5): ");
                        int mark = int.Parse(Console.ReadLine());

                        if (mark == 4 || mark == 5)
                            Console.WriteLine("Молодец");
                        else
                            Console.WriteLine("Нужно подтянуться");
                        break;
                    }
                case 31:
                    {
                        // 31. Даны два символа. Проверить, совпадают ли они.
                        Console.Write("Введите первый символ: ");
                        char a = char.Parse(Console.ReadLine());

                        Console.Write("Введите второй символ: ");
                        char b = char.Parse(Console.ReadLine());

                        if (a == b)
                            Console.WriteLine("Символы совпадают.");
                        else
                            Console.WriteLine("Символы не совпадают.");
                        break;
                    }
                case 32:
                    {
                        // 32. Ввести число. Если оно кратно и 2, и 7, вывести «Кратно 14».
                        Console.Write("Введите число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 2 == 0 && number % 7 == 0)
                            Console.WriteLine("Кратно 14");
                        else
                            Console.WriteLine("Не кратно 14");
                        break;
                    }
                case 33:
                    {
                        // 33. Ввести массу груза. Если масса превышает допустимые 3.5 тонны, вывести «Перегруз!».
                        Console.Write("Введите массу груза (тонн): ");
                        double mass = double.Parse(Console.ReadLine());

                        if (mass > 3.5)
                            Console.WriteLine("Перегруз!");
                        break;
                    }
                case 34:
                    {
                        // 34. Ввести текущее время (часы от 0 до 23). Если время от 6 до 12, вывести «Доброе утро».
                        Console.Write("Введите текущий час (0-23): ");
                        int hour = int.Parse(Console.ReadLine());

                        if (hour >= 6 && hour <= 12)
                            Console.WriteLine("Доброе утро");
                        break;
                    }
                case 35:
                    {
                        // 35. Ввести рост человека в см. Если рост больше 200 см, вывести «Очень высокий».
                        Console.Write("Введите рост (см): ");
                        double height = double.Parse(Console.ReadLine());

                        if (height > 200)
                            Console.WriteLine("Очень высокий");
                        break;
                    }
                case 36:
                    {
                        // 36. Дано двузначное число. Определить, какая из его цифр больше.
                        Console.Write("Введите двузначное число: ");
                        int number = int.Parse(Console.ReadLine());

                        int tens = number / 10;
                        int units = number % 10;

                        if (tens > units)
                            Console.WriteLine("Первая цифра больше.");
                        else if (units > tens)
                            Console.WriteLine("Вторая цифра больше.");
                        else
                            Console.WriteLine("Цифры равны.");
                        break;
                    }
                case 37:
                    {
                        // 37. Ввести стоимость товара. Если товар бесплатный (цена 0), вывести «Акция!».
                        Console.Write("Введите стоимость товара: ");
                        double price = double.Parse(Console.ReadLine());

                        if (price == 0)
                            Console.WriteLine("Акция!");
                        break;
                    }
                case 38:
                    {
                        // 38. Проверить, содержит ли введенное двузначное число одинаковые цифры.
                        Console.Write("Введите двузначное число: ");
                        int number = int.Parse(Console.ReadLine());

                        int tens = Math.Abs(number) / 10;
                        int units = Math.Abs(number) % 10;

                        if (tens == units)
                            Console.WriteLine("Цифры одинаковые.");
                        else
                            Console.WriteLine("Цифры разные.");
                        break;
                    }
                case 39:
                    {
                        // 39. Ввести уровень громкости (0–100). Если громкость превышает 80, вывести «Слишком громко для слуха».
                        Console.Write("Введите уровень громкости (0-100): ");
                        int volume = int.Parse(Console.ReadLine());

                        if (volume > 80)
                            Console.WriteLine("Слишком громко для слуха");
                        break;
                    }
                case 40:
                    {
                        // 40. Даны два числа. Если их сумма четная, вывести сумму, иначе вывести их разность.
                        Console.Write("Введите первое целое число: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("Введите второе целое число: ");
                        int b = int.Parse(Console.ReadLine());

                        int sum = a + b;

                        if (sum % 2 == 0)
                            Console.WriteLine("Сумма: " + sum);
                        else
                            Console.WriteLine("Разность: " + (a - b));
                        break;
                    }
                case 41:
                    {
                        // 41. Ввести количество страниц в документе. Если страниц больше 100, включить двухстороннюю печать.
                        Console.Write("Введите количество страниц: ");
                        int pages = int.Parse(Console.ReadLine());

                        if (pages > 100)
                            Console.WriteLine("Включить двухстороннюю печать.");
                        else
                            Console.WriteLine("Односторонняя печать.");
                        break;
                    }
                case 42:
                    {
                        // 42. Проверить, является ли введенное целое число полным квадратом (для проверки использовать Math.Sqrt).
                        Console.Write("Введите целое число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number >= 0)
                        {
                            double root = Math.Sqrt(number);

                            if (root == Math.Truncate(root))
                                Console.WriteLine("Число является полным квадратом.");
                            else
                                Console.WriteLine("Число не является полным квадратом.");
                        }
                        else
                        {
                            Console.WriteLine("Отрицательное число не является полным квадратом.");
                        }
                        break;
                    }
                case 43:
                    {
                        // 43. Ввести атмосферное давление. Если давление ниже 740 мм рт. ст., вывести «Пониженное давление».
                        Console.Write("Введите атмосферное давление (мм рт. ст.): ");
                        double pressure = double.Parse(Console.ReadLine());

                        if (pressure < 740)
                            Console.WriteLine("Пониженное давление");
                        break;
                    }
                case 44:
                    {
                        // 44. Ввести количество забитых мячей командами А и Б. Вывести победителя или сообщить о ничьей.
                        Console.Write("Введите количество голов команды А: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("Введите количество голов команды Б: ");
                        int b = int.Parse(Console.ReadLine());

                        if (a > b)
                            Console.WriteLine("Победила команда А.");
                        else if (b > a)
                            Console.WriteLine("Победила команда Б.");
                        else
                            Console.WriteLine("Ничья.");
                        break;
                    }
                case 45:
                    {
                        // 45. Дано число. Заменить его на абсолютную величину (модуль) без использования Math.Abs.
                        Console.Write("Введите число: ");
                        double number = double.Parse(Console.ReadLine());

                        if (number < 0)
                            number = -number;

                        Console.WriteLine("Модуль числа: " + number);
                        break;
                    }
                case 46:
                    {
                        // 46. Ввести показатель уровня сахара в крови. Если показатель выше 6.1 ммоль/л, вывести «Выше нормы».
                        Console.Write("Введите уровень сахара в крови (ммоль/л): ");
                        double sugar = double.Parse(Console.ReadLine());

                        if (sugar > 6.1)
                            Console.WriteLine("Выше нормы");
                        break;
                    }
                case 47:
                    {
                        // 47. Проверить, хватит ли пользователю средств на счете для оплаты проезда стоимостью 35 рублей.
                        Console.Write("Введите сумму на счете: ");
                        double balance = double.Parse(Console.ReadLine());

                        if (balance >= 35)
                            Console.WriteLine("Средств достаточно для оплаты проезда.");
                        else
                            Console.WriteLine("Средств недостаточно для оплаты проезда.");
                        break;
                    }
                case 48:
                    {
                        // 48. Ввести номер текущего этажа. Если этаж выше 10, вывести «Высотный этаж».
                        Console.Write("Введите номер этажа: ");
                        int floor = int.Parse(Console.ReadLine());

                        if (floor > 10)
                            Console.WriteLine("Высотный этаж");
                        break;
                    }
                case 49:
                    {
                        // 49. Ввести два слова. Проверить, одинаковы ли они по длине.
                        Console.Write("Введите первое слово: ");
                        string word1 = Console.ReadLine();

                        Console.Write("Введите второе слово: ");
                        string word2 = Console.ReadLine();

                        if (word1.Length == word2.Length)
                            Console.WriteLine("Слова имеют одинаковую длину.");
                        else
                            Console.WriteLine("Слова имеют разную длину.");
                        break;
                    }
                case 50:
                    {
                        // 50. Пользователь вводит целое число. Вывести строковое сообщение: «Число четное» либо «Число нечетное».
                        Console.Write("Введите целое число: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number % 2 == 0)
                            Console.WriteLine("Число четное");
                        else
                            Console.WriteLine("Число нечетное");
                        break;
                    }
                case 51:
                    {
                        // 51. Балл за тест: ECTS A (90-100), B (80-89), C (70-79), D (60-69), F (менее 60).
                        Console.Write("Введите балл за тест (0-100): ");
                        int score = int.Parse(Console.ReadLine());

                        if (score >= 90)
                            Console.WriteLine("A");
                        else if (score >= 80)
                            Console.WriteLine("B");
                        else if (score >= 70)
                            Console.WriteLine("C");
                        else if (score >= 60)
                            Console.WriteLine("D");
                        else
                            Console.WriteLine("F");
                        break;
                    }
                case 52:
                    {
                        // 52. Возраст: ребенок (0-12), подросток (13-17), взрослый (18-64), пожилой (65+).
                        Console.Write("Введите возраст: ");
                        int age = int.Parse(Console.ReadLine());

                        if (age <= 12)
                            Console.WriteLine("Ребенок");
                        else if (age <= 17)
                            Console.WriteLine("Подросток");
                        else if (age <= 64)
                            Console.WriteLine("Взрослый");
                        else
                            Console.WriteLine("Пожилой");
                        break;
                    }
                case 53:
                    {
                        // 53. Температура воды: Лед (<=0), Жидкость (0<t<100), Пар (>=100).
                        Console.Write("Введите температуру воды: ");
                        double temperature = double.Parse(Console.ReadLine());

                        if (temperature <= 0)
                            Console.WriteLine("Лед");
                        else if (temperature < 100)
                            Console.WriteLine("Жидкость");
                        else
                            Console.WriteLine("Пар");
                        break;
                    }
                case 54:
                    {
                        // 54. Заряд аккумулятора: Критический (<10), Низкий (10-20), Нормальный (21-80), Полный (81-100).
                        Console.Write("Введите заряд аккумулятора (%): ");
                        int charge = int.Parse(Console.ReadLine());

                        if (charge < 10)
                            Console.WriteLine("Критический");
                        else if (charge <= 20)
                            Console.WriteLine("Низкий");
                        else if (charge <= 80)
                            Console.WriteLine("Нормальный");
                        else
                            Console.WriteLine("Полный");
                        break;
                    }
                case 55:
                    {
                        // 55. Обороты двигателя: 0 — Заглушен, 1-900 — Холостой ход, 901-3500 — Рабочий, 3501+ — Красная зона.
                        Console.Write("Введите обороты двигателя (RPM): ");
                        int rpm = int.Parse(Console.ReadLine());

                        if (rpm == 0)
                            Console.WriteLine("Заглушен");
                        else if (rpm <= 900)
                            Console.WriteLine("Холостой ход");
                        else if (rpm <= 3500)
                            Console.WriteLine("Рабочий");
                        else
                            Console.WriteLine("Красная зона");
                        break;
                    }
                case 56:
                    {
                        // 56. Доход за год: до 2.4 млн — 13%, до 5 млн — 15%, выше 5 млн — 18%. Рассчитать налог.
                        Console.Write("Введите сумму дохода за год: ");
                        double income = double.Parse(Console.ReadLine());

                        double rate;

                        if (income <= 2400000)
                            rate = 0.13;
                        else if (income <= 5000000)
                            rate = 0.15;
                        else
                            rate = 0.18;

                        double tax = income * rate;

                        Console.WriteLine("Ставка: " + (rate * 100) + "%");
                        Console.WriteLine("Подоходный налог: " + tax + " руб.");
                        break;
                    }
                case 57:
                    {
                        // 57. Координата X при Y=0: ноль, положительная или отрицательная полуось.
                        Console.Write("Введите координату X: ");
                        double x = double.Parse(Console.ReadLine());

                        if (x == 0)
                            Console.WriteLine("Точка находится на нуле.");
                        else if (x > 0)
                            Console.WriteLine("Положительная полуось.");
                        else
                            Console.WriteLine("Отрицательная полуось.");
                        break;
                    }
                case 58:
                    {
                        // 58. ИМТ: дефицит (<18.5), норма (18.5-24.9), избыток (25-29.9), ожирение (30+).
                        Console.Write("Введите ИМТ: ");
                        double bmi = double.Parse(Console.ReadLine());

                        if (bmi < 18.5)
                            Console.WriteLine("Дефицит веса");
                        else if (bmi < 25)
                            Console.WriteLine("Норма");
                        else if (bmi < 30)
                            Console.WriteLine("Избыток");
                        else
                            Console.WriteLine("Ожирение");
                        break;
                    }
                case 59:
                    {
                        // 59. Скорость ветра: штиль (<0.2), легкий ветерок (0.2-5), умеренный (5.1-14), шторм (14.1-24), ураган (>24).
                        Console.Write("Введите скорость ветра (м/с): ");
                        double speed = double.Parse(Console.ReadLine());

                        if (speed < 0.2)
                            Console.WriteLine("Штиль");
                        else if (speed <= 5)
                            Console.WriteLine("Легкий ветерок");
                        else if (speed <= 14)
                            Console.WriteLine("Умеренный");
                        else if (speed <= 24)
                            Console.WriteLine("Шторм");
                        else
                            Console.WriteLine("Ураган");
                        break;
                    }
                case 60:
                    {
                        // 60. Стаж: <1 года — 0%, 1-5 лет — 5%, 6-10 лет — 10%, >10 лет — 15%.
                        Console.Write("Введите стаж работы (лет): ");
                        double experience = double.Parse(Console.ReadLine());

                        if (experience < 1)
                            Console.WriteLine("Надбавка: 0%");
                        else if (experience <= 5)
                            Console.WriteLine("Надбавка: 5%");
                        else if (experience <= 10)
                            Console.WriteLine("Надбавка: 10%");
                        else
                            Console.WriteLine("Надбавка: 15%");
                        break;
                    }
                case 61:
                    {
                        // 61. Час: 0-5 — Ночь, 6-11 — Утро, 12-17 — День, 18-23 — Вечер.
                        Console.Write("Введите текущий час (0-23): ");
                        int hour = int.Parse(Console.ReadLine());

                        if (hour <= 5)
                            Console.WriteLine("Ночь");
                        else if (hour <= 11)
                            Console.WriteLine("Утро");
                        else if (hour <= 17)
                            Console.WriteLine("День");
                        else if (hour <= 23)
                            Console.WriteLine("Вечер");
                        else
                            Console.WriteLine("Некорректный час");
                        break;
                    }
                case 62:
                    {
                        // 62. Толщина льда: <7 — Выход запрещен, 7-12 — Одиночный пешеход, 13-20 — Группа людей, >20 — Транспорт.
                        Console.Write("Введите толщину льда (см): ");
                        double ice = double.Parse(Console.ReadLine());

                        if (ice < 7)
                            Console.WriteLine("Выход запрещен");
                        else if (ice <= 12)
                            Console.WriteLine("Одиночный пешеход");
                        else if (ice <= 20)
                            Console.WriteLine("Группа людей");
                        else
                            Console.WriteLine("Транспорт");
                        break;
                    }
                case 63:
                    {
                        // 63. Три целых числа A, B, C. Найти максимальное каскадным условием.
                        Console.Write("A = ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("B = ");
                        int b = int.Parse(Console.ReadLine());

                        Console.Write("C = ");
                        int c = int.Parse(Console.ReadLine());

                        int max;

                        if (a >= b && a >= c)
                            max = a;
                        else if (b >= a && b >= c)
                            max = b;
                        else
                            max = c;

                        Console.WriteLine("Максимальное число: " + max);
                        break;
                    }
                case 64:
                    {
                        // 64. Даны три числа. Найти минимальное.
                        Console.Write("Введите первое число: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Введите третье число: ");
                        double c = double.Parse(Console.ReadLine());

                        double min;

                        if (a <= b && a <= c)
                            min = a;
                        else if (b <= a && b <= c)
                            min = b;
                        else
                            min = c;

                        Console.WriteLine("Минимальное число: " + min);
                        break;
                    }
                case 65:
                    {
                        // 65. Три числа. Определить количество положительных (0, 1, 2 или 3).
                        Console.Write("Введите первое число: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Введите третье число: ");
                        double c = double.Parse(Console.ReadLine());

                        int count = 0;

                        if (a > 0)
                            count++;

                        if (b > 0)
                            count++;

                        if (c > 0)
                            count++;

                        Console.WriteLine("Количество положительных чисел: " + count);
                        break;
                    }
                case 66:
                    {
                        // 66. Средний балл диплома: <4.5 — Без отличия, 4.5-4.74 — Претендент, >=4.75 — Красный диплом.
                        Console.Write("Введите средний балл диплома: ");
                        double average = double.Parse(Console.ReadLine());

                        if (average < 4.5)
                            Console.WriteLine("Без отличия");
                        else if (average < 4.75)
                            Console.WriteLine("Претендент на красный диплом");
                        else
                            Console.WriteLine("Красный диплом");
                        break;
                    }
                case 67:
                    {
                        // 67. Артериальное давление: <90 — гипотония, 90-120 — норма, 121-139 — предгипертензия, >=140 — гипертензия.
                        Console.Write("Введите систолическое давление: ");
                        int pressure = int.Parse(Console.ReadLine());

                        if (pressure < 90)
                            Console.WriteLine("Гипотония");
                        else if (pressure <= 120)
                            Console.WriteLine("Норма");
                        else if (pressure <= 139)
                            Console.WriteLine("Предгипертензия");
                        else
                            Console.WriteLine("Гипертензия");
                        break;
                    }
                case 68:
                    {
                        // 68. Рейтинг шахматиста Эло: <1400 — любитель, 1400-1999 — разрядник, 2000-2399 — мастер, >=2400 — гроссмейстер.
                        Console.Write("Введите рейтинг Эло: ");
                        int elo = int.Parse(Console.ReadLine());

                        if (elo < 1400)
                            Console.WriteLine("Любитель");
                        else if (elo < 2000)
                            Console.WriteLine("Разрядник");
                        else if (elo < 2400)
                            Console.WriteLine("Мастер");
                        else
                            Console.WriteLine("Гроссмейстер");
                        break;
                    }
                case 69:
                    {
                        // 69. Определить, сколькизначным является число.
                        Console.Write("Введите число: ");
                        long number = long.Parse(Console.ReadLine());

                        long n = Math.Abs(number);

                        if (n < 10)
                            Console.WriteLine("Однозначное число");
                        else if (n < 100)
                            Console.WriteLine("Двузначное число");
                        else if (n < 1000)
                            Console.WriteLine("Трехзначное число");
                        else
                            Console.WriteLine("Четырехзначное или более число");
                        break;
                    }
                case 70:
                    {
                        // 70. Такси: до 5 км — 200 руб, 5-15 км — 200 + 25 руб/км, свыше 15 км — 200 + 20 руб/км.
                        Console.Write("Введите дальность поездки (км): ");
                        double km = double.Parse(Console.ReadLine());

                        double cost;

                        if (km <= 5)
                            cost = 200;
                        else if (km <= 15)
                            cost = 200 + 25 * km;
                        else
                            cost = 200 + 20 * km;

                        Console.WriteLine("Стоимость поездки: " + cost + " руб.");
                        break;
                    }
                case 71:
                    {
                        // 71. Осадки за сутки: 0 — без осадков, 0.1-4 — слабый дождь, 4.1-15 — умеренный, >15 — сильный ливень.
                        Console.Write("Введите количество осадков (мм): ");
                        double rain = double.Parse(Console.ReadLine());

                        if (rain == 0)
                            Console.WriteLine("Без осадков");
                        else if (rain <= 4)
                            Console.WriteLine("Слабый дождь");
                        else if (rain <= 15)
                            Console.WriteLine("Умеренный");
                        else
                            Console.WriteLine("Сильный ливень");
                        break;
                    }
                case 72:
                    {
                        // 72. Выполнение плана продаж: <70 — план сорван, 70-99 — удовлетворительно, 100-119 — выполнен, >=120 — перевыполнен.
                        Console.Write("Введите процент выполнения плана: ");
                        double percent = double.Parse(Console.ReadLine());

                        if (percent < 70)
                            Console.WriteLine("План сорван");
                        else if (percent < 100)
                            Console.WriteLine("Удовлетворительно");
                        else if (percent < 120)
                            Console.WriteLine("Выполнен");
                        else
                            Console.WriteLine("Перевыполнен");
                        break;
                    }
                case 73:
                    {
                        // 73. Три числа. Упорядочить по возрастанию.
                        Console.Write("Введите первое число: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Введите третье число: ");
                        double c = double.Parse(Console.ReadLine());

                        double temp;

                        if (a > b)
                        {
                            temp = a;
                            a = b;
                            b = temp;
                        }

                        if (b > c)
                        {
                            temp = b;
                            b = c;
                            c = temp;
                        }

                        if (a > b)
                        {
                            temp = a;
                            a = b;
                            b = temp;
                        }

                        Console.WriteLine("По возрастанию: " + a + ", " + b + ", " + c);
                        break;
                    }
                case 74:
                    {
                        // 74. Кусочно-заданная функция: f(x)=x^2, если x>0; f(x)=0, если x=0; f(x)=-x, если x<0.
                        Console.Write("Введите X: ");
                        double x = double.Parse(Console.ReadLine());

                        double result;

                        if (x > 0)
                            result = x * x;
                        else if (x == 0)
                            result = 0;
                        else
                            result = -x;

                        Console.WriteLine("f(x) = " + result);
                        break;
                    }
                case 75:
                    {
                        // 75. Октановое число бензина: <92 — несоответствие, 92 — АИ-92, 95 — АИ-95, 98-100 — АИ-98/100, >100 — спорт/авиатопливо.
                        Console.Write("Введите октановое число бензина: ");
                        int octane = int.Parse(Console.ReadLine());

                        if (octane < 92)
                            Console.WriteLine("Несоответствие стандарту");
                        else if (octane == 92)
                            Console.WriteLine("АИ-92");
                        else if (octane == 95)
                            Console.WriteLine("АИ-95");
                        else if (octane <= 100)
                            Console.WriteLine("АИ-98/100");
                        else
                            Console.WriteLine("Спорт/авиатопливо");
                        break;
                    }
                case 76:
                    {
                        // 76. Кешбэк: до 10 000 — 1%, до 50 000 — 3%, свыше 50 000 — 5%.
                        Console.Write("Введите сумму покупок за месяц: ");
                        double sum = double.Parse(Console.ReadLine());

                        double rate;

                        if (sum <= 10000)
                            rate = 0.01;
                        else if (sum <= 50000)
                            rate = 0.03;
                        else
                            rate = 0.05;

                        double cashback = sum * rate;

                        Console.WriteLine("Кешбэк: " + cashback + " руб.");
                        break;
                    }
                case 77:
                    {
                        // 77. Глубина погружения: <40 — рекреационная, 40-100 — техническая, >100 — глубоководная.
                        Console.Write("Введите глубину погружения (м): ");
                        double depth = double.Parse(Console.ReadLine());

                        if (depth < 40)
                            Console.WriteLine("Рекреационная");
                        else if (depth <= 100)
                            Console.WriteLine("Техническая");
                        else
                            Console.WriteLine("Глубоководная");
                        break;
                    }
                case 78:
                    {
                        // 78. Штрафные баллы: 1-5 — Предупреждение, 6-10 — Временное ограничение, >10 — Лишение прав.
                        Console.Write("Введите количество штрафных баллов: ");
                        int points = int.Parse(Console.ReadLine());

                        if (points <= 0)
                            Console.WriteLine("Нет штрафных баллов");
                        else if (points <= 5)
                            Console.WriteLine("Предупреждение");
                        else if (points <= 10)
                            Console.WriteLine("Временное ограничение");
                        else
                            Console.WriteLine("Лишение прав");
                        break;
                    }
                case 79:
                    {
                        // 79. pH почвы: <6.0 — кислая, 6.0-7.2 — нейтральная, >7.2 — щелочная.
                        Console.Write("Введите pH почвы: ");
                        double ph = double.Parse(Console.ReadLine());

                        if (ph < 6.0)
                            Console.WriteLine("Кислая");
                        else if (ph <= 7.2)
                            Console.WriteLine("Нейтральная");
                        else
                            Console.WriteLine("Щелочная");
                        break;
                    }
                case 80:
                    {
                        // 80. Очки в игре: 1000-2499 — Бронзовая, 2500-4999 — Серебряная, 5000+ — Золотая, иначе без медали.
                        Console.Write("Введите количество очков: ");
                        int points = int.Parse(Console.ReadLine());

                        if (points >= 5000)
                            Console.WriteLine("Золотая медаль");
                        else if (points >= 2500)
                            Console.WriteLine("Серебряная медаль");
                        else if (points >= 1000)
                            Console.WriteLine("Бронзовая медаль");
                        else
                            Console.WriteLine("Без медали");
                        break;
                    }
                case 81:
                    {
                        // 81. Крепость напитка: 0 — безалкогольный, 0.1-8 — слабоалкогольный, 8.1-25 — среднеалкогольный, >25 — крепкий.
                        Console.Write("Введите крепость напитка (градусы): ");
                        double strength = double.Parse(Console.ReadLine());

                        if (strength == 0)
                            Console.WriteLine("Безалкогольный");
                        else if (strength <= 8)
                            Console.WriteLine("Слабоалкогольный");
                        else if (strength <= 25)
                            Console.WriteLine("Среднеалкогольный");
                        else
                            Console.WriteLine("Крепкий");
                        break;
                    }
                case 82:
                    {
                        // 82. Уровень шума: <40 — тихо, 40-60 — норма, 61-80 — шумно, >80 — вредно для здоровья.
                        Console.Write("Введите уровень шума (дБ): ");
                        double noise = double.Parse(Console.ReadLine());

                        if (noise < 40)
                            Console.WriteLine("Тихо");
                        else if (noise <= 60)
                            Console.WriteLine("Норма");
                        else if (noise <= 80)
                            Console.WriteLine("Шумно");
                        else
                            Console.WriteLine("Вредно для здоровья");
                        break;
                    }
                case 83:
                    {
                        // 83. Вес посылки: <2 — мелкий пакет, 2-10 — стандартная, 10.1-31.5 — тяжеловесная, >31.5 — крупногабарит.
                        Console.Write("Введите вес посылки (кг): ");
                        double weight = double.Parse(Console.ReadLine());

                        if (weight < 2)
                            Console.WriteLine("Мелкий пакет");
                        else if (weight <= 10)
                            Console.WriteLine("Стандартная");
                        else if (weight <= 31.5)
                            Console.WriteLine("Тяжеловесная");
                        else
                            Console.WriteLine("Крупногабарит");
                        break;
                    }
                case 84:
                    {
                        // 84. Количество комнат: 1 — студия/однокомнатная, 2 — двухкомнатная, 3 — трехкомнатная, 4+ — многокомнатная.
                        Console.Write("Введите количество комнат: ");
                        int rooms = int.Parse(Console.ReadLine());

                        if (rooms == 1)
                            Console.WriteLine("Студия/однокомнатная");
                        else if (rooms == 2)
                            Console.WriteLine("Двухкомнатная");
                        else if (rooms == 3)
                            Console.WriteLine("Трехкомнатная");
                        else if (rooms >= 4)
                            Console.WriteLine("Многокомнатная");
                        else
                            Console.WriteLine("Некорректное количество комнат");
                        break;
                    }
                case 85:
                    {
                        // 85. Процент заряда повербанка. Количество светодиодов (1-4) определяется по уровню заряда. В исходном условии точные границы не заданы, поэтому используются равные диапазоны по 25%.
                        Console.Write("Введите процент заряда повербанка: ");
                        int charge = int.Parse(Console.ReadLine());

                        if (charge <= 25)
                            Console.WriteLine("Светодиодов: 1");
                        else if (charge <= 50)
                            Console.WriteLine("Светодиодов: 2");
                        else if (charge <= 75)
                            Console.WriteLine("Светодиодов: 3");
                        else
                            Console.WriteLine("Светодиодов: 4");
                        break;
                    }
                case 86:
                    {
                        // 86. Выслуга лет военнослужащего. Вывести процент пенсионной надбавки. В исходном условии конкретная шкала процентов не указана. Ниже оставлена примерная шкала.
                        Console.Write("Введите выслугу лет: ");
                        double years = double.Parse(Console.ReadLine());

                        if (years < 5)
                            Console.WriteLine("Пенсионная надбавка: 0%");
                        else if (years < 10)
                            Console.WriteLine("Пенсионная надбавка: 5%");
                        else if (years < 20)
                            Console.WriteLine("Пенсионная надбавка: 10%");
                        else
                            Console.WriteLine("Пенсионная надбавка: 15%");
                        break;
                    }
                case 87:
                    {
                        // 87. Пинг: <20 — идеальный, 20-60 — хороший, 61-120 — посредственный, >120 — плохой.
                        Console.Write("Введите время отклика сервера (мс): ");
                        double ping = double.Parse(Console.ReadLine());

                        if (ping < 20)
                            Console.WriteLine("Идеальный");
                        else if (ping <= 60)
                            Console.WriteLine("Хороший");
                        else if (ping <= 120)
                            Console.WriteLine("Посредственный");
                        else
                            Console.WriteLine("Плохой");
                        break;
                    }
                case 88:
                    {
                        // 88. CO2: <800 — норма, 800-1200 — душно, >1200 — проветрить немедленно.
                        Console.Write("Введите концентрацию CO2 (ppm): ");
                        double co2 = double.Parse(Console.ReadLine());

                        if (co2 < 800)
                            Console.WriteLine("Норма");
                        else if (co2 <= 1200)
                            Console.WriteLine("Душно");
                        else
                            Console.WriteLine("Проветрить немедленно");
                        break;
                    }
                case 89:
                    {
                        // 89. Шаги: <5000 — гиподинамия, 5000-9999 — норма, 10000-14999 — активный день, >15000 — рекорд.
                        Console.Write("Введите количество шагов: ");
                        int steps = int.Parse(Console.ReadLine());

                        if (steps < 5000)
                            Console.WriteLine("Гиподинамия");
                        else if (steps < 10000)
                            Console.WriteLine("Норма");
                        else if (steps < 15000)
                            Console.WriteLine("Активный день");
                        else
                            Console.WriteLine("Рекорд");
                        break;
                    }
                case 90:
                    {
                        // 90. Диаметр диска: 13-14 — малолитражки, 15-16 — компактные авто, 17-19 — кроссоверы/бизнес, 20+ — внедорожники/спорт.
                        Console.Write("Введите диаметр диска (дюймы): ");
                        double diameter = double.Parse(Console.ReadLine());

                        if (diameter >= 13 && diameter <= 14)
                            Console.WriteLine("Малолитражки");
                        else if (diameter <= 16)
                            Console.WriteLine("Компактные авто");
                        else if (diameter <= 19)
                            Console.WriteLine("Кроссоверы/бизнес");
                        else if (diameter >= 20)
                            Console.WriteLine("Внедорожники/спорт");
                        else
                            Console.WriteLine("Диаметр вне заданных диапазонов");
                        break;
                    }
                case 91:
                    {
                        // 91. Влажность: <30 — сухой воздух, 30-60 — комфорт, >60 — повышенная влажность.
                        Console.Write("Введите влажность воздуха (%): ");
                        double humidity = double.Parse(Console.ReadLine());

                        if (humidity < 30)
                            Console.WriteLine("Сухой воздух");
                        else if (humidity <= 60)
                            Console.WriteLine("Комфорт");
                        else
                            Console.WriteLine("Повышенная влажность");
                        break;
                    }
                case 92:
                    {
                        // 92. Три числа: все разные, два равны или все три равны.
                        Console.Write("Введите A: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("Введите B: ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write("Введите C: ");
                        double c = double.Parse(Console.ReadLine());

                        if (a == b && b == c)
                            Console.WriteLine("Все три равны");
                        else if (a == b || a == c || b == c)
                            Console.WriteLine("Два равны");
                        else
                            Console.WriteLine("Все разные");
                        break;
                    }
                case 93:
                    {
                        // 93. Номер четверти координатной плоскости: 1 — X>0,Y>0; 2 — X<0,Y>0; 3 — X<0,Y<0; 4 — X>0,Y<0.
                        Console.Write("Введите номер четверти (1-4): ");
                        int quarter = int.Parse(Console.ReadLine());

                        if (quarter == 1)
                            Console.WriteLine("X > 0, Y > 0");
                        else if (quarter == 2)
                            Console.WriteLine("X < 0, Y > 0");
                        else if (quarter == 3)
                            Console.WriteLine("X < 0, Y < 0");
                        else if (quarter == 4)
                            Console.WriteLine("X > 0, Y < 0");
                        else
                            Console.WriteLine("Некорректный номер четверти");
                        break;
                    }
                case 94:
                    {
                        // 94. Температура процессора: <45 — холодный, 45-75 — нормальная нагрузка, >75 — троттлинг/перегрев.
                        Console.Write("Введите температуру процессора (°C): ");
                        double temperature = double.Parse(Console.ReadLine());

                        if (temperature < 45)
                            Console.WriteLine("Холодный");
                        else if (temperature <= 75)
                            Console.WriteLine("Нормальная нагрузка");
                        else
                            Console.WriteLine("Троттлинг/перегрев");
                        break;
                    }
                case 95:
                    {
                        // 95. Срок годности: <=2 — Срочно употребить, 3-30 — Нормально, >30 — Длительное хранение.
                        Console.Write("Введите остаток срока годности (дней): ");
                        int days = int.Parse(Console.ReadLine());

                        if (days <= 2)
                            Console.WriteLine("Срочно употребить");
                        else if (days <= 30)
                            Console.WriteLine("Нормально");
                        else
                            Console.WriteLine("Длительное хранение");
                        break;
                    }
                case 96:
                    {
                        // 96. Сумма кредита и срок. Рассчитать процентную ставку в зависимости от срока: до года, до трех лет, свыше трех лет. Конкретные проценты в исходном условии не указаны, поэтому используются примерные значения.
                        Console.Write("Введите сумму кредита: ");
                        double amount = double.Parse(Console.ReadLine());

                        Console.Write("Введите срок кредита (лет): ");
                        double years = double.Parse(Console.ReadLine());

                        double rate;

                        if (years <= 1)
                            rate = 10;
                        else if (years <= 3)
                            rate = 12;
                        else
                            rate = 15;

                        double interest = amount * rate / 100;

                        Console.WriteLine("Процентная ставка: " + rate + "%");
                        Console.WriteLine("Проценты за год: " + interest + " руб.");
                        break;
                    }
                case 97:
                    {
                        // 97. Частота обновления монитора: 60-75 — офис, 120-144 — базовый игровой, 165+ — киберспорт.
                        Console.Write("Введите частоту обновления монитора (Гц): ");
                        int hz = int.Parse(Console.ReadLine());

                        if (hz >= 60 && hz <= 75)
                            Console.WriteLine("Офис");
                        else if (hz >= 120 && hz <= 144)
                            Console.WriteLine("Базовый игровой");
                        else if (hz >= 165)
                            Console.WriteLine("Киберспорт");
                        else
                            Console.WriteLine("Не попадает в заданные категории");
                        break;
                    }
                case 98:
                    {
                        // 98. Расход топлива: <6 — экономичный, 6-10 — средний, >10 — прожорливый.
                        Console.Write("Введите расход топлива (л/100 км): ");
                        double fuel = double.Parse(Console.ReadLine());

                        if (fuel < 6)
                            Console.WriteLine("Экономичный");
                        else if (fuel <= 10)
                            Console.WriteLine("Средний");
                        else
                            Console.WriteLine("Прожорливый");
                        break;
                    }
                case 99:
                    {
                        // 99. Количество страниц: <48 — брошюра, 48-150 — повесть, 151-600 — роман, >600 — фолиант.
                        Console.Write("Введите количество страниц: ");
                        int pages = int.Parse(Console.ReadLine());

                        if (pages < 48)
                            Console.WriteLine("Брошюра");
                        else if (pages <= 150)
                            Console.WriteLine("Повесть");
                        else if (pages <= 600)
                            Console.WriteLine("Роман");
                        else
                            Console.WriteLine("Фолиант");
                        break;
                    }
                case 100:
                    {
                        // 100. Проверить, попадает ли число в интервалы [0;10], [20;30] или [50;100].
                        Console.Write("Введите число: ");
                        double number = double.Parse(Console.ReadLine());

                        if ((number >= 0 && number <= 10) ||
                            (number >= 20 && number <= 30) ||
                            (number >= 50 && number <= 100))
                        {
                            Console.WriteLine("Число попадает в один из заданных интервалов.");
                        }
                        else
                        {
                            Console.WriteLine("Число не попадает в заданные интервалы.");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Такого задания нет. Введите число от 1 до 100.");
                    break;
                // 101. Число принадлежит отрезку [10; 50]
                case 101:
                    {
                        int n = ReadInt();
                        Console.WriteLine(n >= 10 && n <= 50);
                        break;
                    }

                // 102. Положительное и четное
                case 102:
                    {
                        int n = ReadInt();
                        Console.WriteLine(n > 0 && n % 2 == 0);
                        break;
                    }

                // 103. Число вне диапазона [-10; 10]
                case 103:
                    {
                        int n = ReadInt();
                        Console.WriteLine(n < -10 || n > 10);
                        break;
                    }

                // 104. Логин и пароль
                case 104:
                    {
                        string login = Console.ReadLine()!;
                        string password = Console.ReadLine()!;

                        Console.WriteLine(
                            login == "admin" && password == "secret"
                                ? "Успех"
                                : "Ошибка");
                        break;
                    }

                // 105. Високосный год
                case 105:
                    {
                        int year = ReadInt();

                        bool leap =
                            (year % 4 == 0 && year % 100 != 0) ||
                            year % 400 == 0;

                        Console.WriteLine(leap);
                        break;
                    }

                // 106. I четверть
                case 106:
                    {
                        double x = ReadDouble();
                        double y = ReadDouble();

                        Console.WriteLine(x > 0 && y > 0);
                        break;
                    }

                // 107. II четверть
                case 107:
                    {
                        double x = ReadDouble();
                        double y = ReadDouble();

                        Console.WriteLine(x < 0 && y > 0);
                        break;
                    }

                // 108. III четверть
                case 108:
                    {
                        double x = ReadDouble();
                        double y = ReadDouble();

                        Console.WriteLine(x < 0 && y < 0);
                        break;
                    }

                // 109. IV четверть
                case 109:
                    {
                        double x = ReadDouble();
                        double y = ReadDouble();

                        Console.WriteLine(x > 0 && y < 0);
                        break;
                    }

                // 110. Прямоугольный треугольник
                case 110:
                    {
                        double a = ReadDouble();
                        double b = ReadDouble();
                        double c = ReadDouble();

                        double max = Math.Max(a, Math.Max(b, c));

                        bool valid =
                            a > 0 && b > 0 && c > 0 &&
                            a + b > c &&
                            a + c > b &&
                            b + c > a;

                        bool right =
                            valid &&
                            (
                                max * max == a * a + b * b + c * c - max * max
                            );

                        Console.WriteLine(right);
                        break;
                    }

                // 111. Равнобедренный треугольник
                case 111:
                    {
                        double a = ReadDouble();
                        double b = ReadDouble();
                        double c = ReadDouble();

                        bool valid =
                            a > 0 && b > 0 && c > 0 &&
                            a + b > c &&
                            a + c > b &&
                            b + c > a;

                        bool isosceles =
                            a == b || a == c || b == c;

                        Console.WriteLine(valid && isosceles);
                        break;
                    }

                // 112. Возраст и стаж для каршеринга
                case 112:
                    {
                        int age = ReadInt();
                        int experience = ReadInt();

                        Console.WriteLine(age >= 23 && experience >= 3);
                        break;
                    }

                // 113. Делится на 3 и 5
                case 113:
                    {
                        int n = ReadInt();

                        Console.WriteLine(n % 3 == 0 && n % 5 == 0);
                        break;
                    }

                // 114. Трехзначное и заканчивается на 5
                case 114:
                    {
                        int n = ReadInt();

                        Console.WriteLine(
                            n >= 100 &&
                            n <= 999 &&
                            n % 10 == 5);
                        break;
                    }

                // 115. Строгое возрастание
                case 115:
                    {
                        double a = ReadDouble();
                        double b = ReadDouble();
                        double c = ReadDouble();

                        Console.WriteLine(a < b && b < c);
                        break;
                    }

                // 116. Хотя бы одно четное
                case 116:
                    {
                        int a = ReadInt();
                        int b = ReadInt();
                        int c = ReadInt();

                        Console.WriteLine(
                            a % 2 == 0 ||
                            b % 2 == 0 ||
                            c % 2 == 0);
                        break;
                    }

                // 117. Ровно одно число равно нулю
                case 117:
                    {
                        int a = ReadInt();
                        int b = ReadInt();
                        int c = ReadInt();

                        int zeros = 0;

                        if (a == 0) zeros++;
                        if (b == 0) zeros++;
                        if (c == 0) zeros++;

                        Console.WriteLine(zeros == 1);
                        break;
                    }

                // 118. Гололедица
                case 118:
                    {
                        double temperature = ReadDouble();
                        double humidity = ReadDouble();

                        Console.WriteLine(
                            temperature <= 0 && humidity > 85
                                ? "Предупреждение: гололедица"
                                : "Опасность гололедицы отсутствует");
                        break;
                    }

                // 119. Точка внутри круга
                case 119:
                    {
                        double x = ReadDouble();
                        double y = ReadDouble();
                        double r = ReadDouble();

                        Console.WriteLine(x * x + y * y <= r * r);
                        break;
                    }

                // 120. Точка внутри прямоугольника
                case 120:
                    {
                        double x = ReadDouble();
                        double y = ReadDouble();
                        double x1 = ReadDouble();
                        double y1 = ReadDouble();
                        double x2 = ReadDouble();
                        double y2 = ReadDouble();

                        double minX = Math.Min(x1, x2);
                        double maxX = Math.Max(x1, x2);
                        double minY = Math.Min(y1, y2);
                        double maxY = Math.Max(y1, y2);

                        Console.WriteLine(
                            x >= minX &&
                            x <= maxX &&
                            y >= minY &&
                            y <= maxY);

                        break;
                    }

                // 121. Корректность даты
                case 121:
                    {
                        int day = ReadInt();
                        int month = ReadInt();

                        bool valid = false;

                        if (month >= 1 && month <= 12)
                        {
                            int daysInMonth;

                            switch (month)
                            {
                                case 2:
                                    daysInMonth = 29;
                                    break;

                                case 4:
                                case 6:
                                case 9:
                                case 11:
                                    daysInMonth = 30;
                                    break;

                                default:
                                    daysInMonth = 31;
                                    break;
                            }

                            valid = day >= 1 && day <= daysInMonth;
                        }

                        Console.WriteLine(valid);
                        break;
                    }

                // 122. Зимний месяц
                case 122:
                    {
                        int month = ReadInt();

                        Console.WriteLine(
                            month == 12 ||
                            month == 1 ||
                            month == 2);

                        break;
                    }

                // 123. Счастливый билет
                case 123:
                    {
                        int n = ReadInt();

                        if (n >= 1000 && n <= 9999)
                        {
                            int a = n / 1000;
                            int b = n / 100 % 10;
                            int c = n / 10 % 10;
                            int d = n % 10;

                            Console.WriteLine(a + b == c + d);
                        }
                        else
                        {
                            Console.WriteLine(false);
                        }

                        break;
                    }

                // 124. Среди трех чисел есть взаимно противоположная пара
                case 124:
                    {
                        double a = ReadDouble();
                        double b = ReadDouble();
                        double c = ReadDouble();

                        Console.WriteLine(
                            a == -b ||
                            a == -c ||
                            b == -c);

                        break;
                    }

                // 125. Датчики аварии и тумблер защиты
                case 125:
                    {
                        bool sensor1 = ReadBool();
                        bool sensor2 = ReadBool();
                        bool protection = ReadBool();

                        bool alarm =
                            (sensor1 || sensor2) &&
                            protection;

                        Console.WriteLine(
                            alarm ? "ТРЕВОГА" : "Тревоги нет");

                        break;
                    }

                // 126. X строго между A и B
                case 126:
                    {
                        double x = ReadDouble();
                        double a = ReadDouble();
                        double b = ReadDouble();

                        Console.WriteLine(
                            (a < x && x < b) ||
                            (b < x && x < a));

                        break;
                    }

                // 127. Одинаковый знак
                case 127:
                    {
                        int a = ReadInt();
                        int b = ReadInt();

                        bool sameSign =
                            (a > 0 && b > 0) ||
                            (a < 0 && b < 0);

                        Console.WriteLine(sameSign);
                        break;
                    }

                // 128. Угрожает ли ладья
                case 128:
                    {
                        int x1 = ReadInt();
                        int y1 = ReadInt();
                        int x2 = ReadInt();
                        int y2 = ReadInt();

                        Console.WriteLine(x1 == x2 || y1 == y2);
                        break;
                    }

                // 129. Угрожает ли слон
                case 129:
                    {
                        int x1 = ReadInt();
                        int y1 = ReadInt();
                        int x2 = ReadInt();
                        int y2 = ReadInt();

                        Console.WriteLine(
                            Math.Abs(x1 - x2) ==
                            Math.Abs(y1 - y2));

                        break;
                    }

                // 130. Угрожает ли ферзь
                case 130:
                    {
                        int x1 = ReadInt();
                        int y1 = ReadInt();
                        int x2 = ReadInt();
                        int y2 = ReadInt();

                        bool rook = x1 == x2 || y1 == y2;
                        bool bishop =
                            Math.Abs(x1 - x2) ==
                            Math.Abs(y1 - y2);

                        Console.WriteLine(rook || bishop);
                        break;
                    }

                // 131. Может ли конь сделать ход
                case 131:
                    {
                        int x1 = ReadInt();
                        int y1 = ReadInt();
                        int x2 = ReadInt();
                        int y2 = ReadInt();

                        int dx = Math.Abs(x1 - x2);
                        int dy = Math.Abs(y1 - y2);

                        Console.WriteLine(
                            (dx == 1 && dy == 2) ||
                            (dx == 2 && dy == 1));

                        break;
                    }

                // 132. Клетки одного цвета
                case 132:
                    {
                        int x1 = ReadInt();
                        int y1 = ReadInt();
                        int x2 = ReadInt();
                        int y2 = ReadInt();

                        Console.WriteLine(
                            (x1 + y1) % 2 ==
                            (x2 + y2) % 2);

                        break;
                    }

                // 133. Рост и вес космонавта
                case 133:
                    {
                        double height = ReadDouble();
                        double weight = ReadDouble();

                        Console.WriteLine(
                            height >= 160 &&
                            height <= 190 &&
                            weight >= 50 &&
                            weight <= 90);

                        break;
                    }

                // 134. Четное двузначное число
                case 134:
                    {
                        int n = ReadInt();

                        Console.WriteLine(
                            n >= 10 &&
                            n <= 99 &&
                            n % 2 == 0);

                        break;
                    }

                // 135. Нечетное трехзначное число
                case 135:
                    {
                        int n = ReadInt();

                        Console.WriteLine(
                            n >= 100 &&
                            n <= 999 &&
                            n % 2 != 0);

                        break;
                    }

                // 136. Зачисление по двум экзаменам
                case 136:
                    {
                        int math = ReadInt();
                        int informatics = ReadInt();

                        Console.WriteLine(
                            math + informatics >= 150 &&
                            math >= 50 &&
                            informatics >= 50);

                        break;
                    }

                // 137. Точка в круговом кольце
                case 137:
                    {
                        double x = ReadDouble();
                        double y = ReadDouble();
                        double r1 = ReadDouble();
                        double r2 = ReadDouble();

                        double distanceSquared = x * x + y * y;

                        Console.WriteLine(
                            distanceSquared >= r1 * r1 &&
                            distanceSquared <= r2 * r2);

                        break;
                    }

                // 138. Багаж и статус билета
                case 138:
                    {
                        bool ticketStatus = ReadBool();
                        bool baggage = ReadBool();

                        bool extraPayment =
                            !ticketStatus && baggage;

                        Console.WriteLine(
                            extraPayment
                                ? "Требуется дополнительная оплата багажа"
                                : "Дополнительная оплата не требуется");

                        break;
                    }

                // 139. Четырехзначное число-палиндром
                case 139:
                    {
                        int n = ReadInt();

                        if (n >= 1000 && n <= 9999)
                        {
                            int d1 = n / 1000;
                            int d2 = n / 100 % 10;
                            int d3 = n / 10 % 10;
                            int d4 = n % 10;

                            Console.WriteLine(
                                d1 == d4 &&
                                d2 == d3);
                        }
                        else
                        {
                            Console.WriteLine(false);
                        }

                        break;
                    }

                // 140. Стабильность сети
                case 140:
                    {
                        double voltage = ReadDouble();
                        double frequency = ReadDouble();

                        bool stable =
                            voltage >= 210 &&
                            voltage <= 230 &&
                            frequency >= 49 &&
                            frequency <= 51;

                        Console.WriteLine(
                            stable ? "Сеть стабильна" : "Сеть нестабильна");

                        break;
                    }

                // 141. Права + страховка + трезвость
                case 141:
                    {
                        bool license = ReadBool();
                        bool insurance = ReadBool();
                        bool sober = ReadBool();

                        Console.WriteLine(
                            license &&
                            insurance &&
                            sober
                                ? "Выезд разрешен"
                                : "Выезд запрещен");

                        break;
                    }

                // 142. Делится на 4 или 7, но не на 28
                case 142:
                    {
                        int n = ReadInt();

                        bool result =
                            (n % 4 == 0 || n % 7 == 0) &&
                            n % 28 != 0;

                        Console.WriteLine(result);
                        break;
                    }

                // 143. Летний месяц + температура ниже нуля
                case 143:
                    {
                        int month = ReadInt();
                        double temperature = ReadDouble();

                        bool summer =
                            month == 6 ||
                            month == 7 ||
                            month == 8;

                        Console.WriteLine(
                            summer && temperature < 0
                                ? "Аномалия"
                                : "Аномалии нет");

                        break;
                    }

                // 144. Мажоритарный клапан
                case 144:
                    {
                        bool a = ReadBool();
                        bool b = ReadBool();
                        bool c = ReadBool();

                        bool majority =
                            (a && b) ||
                            (a && c) ||
                            (b && c);

                        Console.WriteLine(majority);
                        break;
                    }

                // 145. Тупоугольный треугольник
                case 145:
                    {
                        double a = ReadDouble();
                        double b = ReadDouble();
                        double c = ReadDouble();

                        bool valid =
                            a > 0 && b > 0 && c > 0 &&
                            a + b > c &&
                            a + c > b &&
                            b + c > a;

                        double max = Math.Max(a, Math.Max(b, c));

                        bool obtuse =
                            valid &&
                            max * max >
                            a * a + b * b + c * c - max * max;

                        Console.WriteLine(obtuse);
                        break;
                    }

                // 146. Остроугольный треугольник
                case 146:
                    {
                        double a = ReadDouble();
                        double b = ReadDouble();
                        double c = ReadDouble();

                        bool valid =
                            a > 0 && b > 0 && c > 0 &&
                            a + b > c &&
                            a + c > b &&
                            b + c > a;

                        double max = Math.Max(a, Math.Max(b, c));

                        bool acute =
                            valid &&
                            max * max <
                            a * a + b * b + c * c - max * max;

                        Console.WriteLine(acute);
                        break;
                    }

                // 147. Тихий час 13:00 - 15:00
                case 147:
                    {
                        int hours = ReadInt();
                        int minutes = ReadInt();

                        int totalMinutes = hours * 60 + minutes;

                        Console.WriteLine(
                            totalMinutes >= 13 * 60 &&
                            totalMinutes <= 15 * 60);

                        break;
                    }

                // 148. Все цифры трехзначного числа различны
                case 148:
                    {
                        int n = ReadInt();

                        if (n >= 100 && n <= 999)
                        {
                            int a = n / 100;
                            int b = n / 10 % 10;
                            int c = n % 10;

                            Console.WriteLine(
                                a != b &&
                                a != c &&
                                b != c);
                        }
                        else
                        {
                            Console.WriteLine(false);
                        }

                        break;
                    }

                // 149. Две кнопки пульта
                case 149:
                    {
                        bool button1 = ReadBool();
                        bool button2 = ReadBool();

                        Console.WriteLine(
                            button1 && button2
                                ? "Станок запущен"
                                : "Станок не запускается");

                        break;
                    }

                // 150. Ниже прямой Y = 2X + 1 и выше параболы Y = X^2
                case 150:
                    {
                        double x = ReadDouble();
                        double y = ReadDouble();

                        bool result =
                            y < 2 * x + 1 &&
                            y > x * x;

                        Console.WriteLine(result);
                        break;
                    }
            }
                    // 151. Ввести номер дня недели (1–7). Вывести его словесное название на русском языке.
                    case 151:
                    {
                         Console.Write("Введите номер дня недели (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());
                    }
        switch (day)
        {
            case 1:
                Console.WriteLine("Понедельник");
                break;
            case 2:
                Console.WriteLine("Вторник");
                break;
            case 3:
                Console.WriteLine("Среда");
                break;
            case 4:
                Console.WriteLine("Четверг");
                break;
            case 5:
                Console.WriteLine("Пятница");
                break;
            case 6:
                Console.WriteLine("Суббота");
                break;
            case 7:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Ошибка: введите число от 1 до 7.");
                break;
                            }
                     // 152: Ввести номер дня недели (1–7). Вывести, является ли день рабочим («Будни») или нерабочим («Выходной»).
                     case 152:
                     {
        Console.Write("Введите номер дня недели (1-7): ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Будни");
                break;

            case 6:
            case 7:
                Console.WriteLine("Выходной");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 7");
                break;
        }
    }
                     // 153. Ввести номер месяца (1–12). Вывести название месяца.
                     case 153:
                   { 
                    Console.WriteLine("Введите номер дня недели (1-7): ");
                     int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 1:
                Console.WriteLine("Январь");
                break;
            case 2:
                Console.WriteLine("Февраль");
                break;
            case 3:
                Console.WriteLine("Март");
                break;
            case 4:
                Console.WriteLine("Апрель");
                break;
            case 5:
                Console.WriteLine("Май");
                break;
            case 6:
                Console.WriteLine("Июнь");
                break;
            case 7:
                Console.WriteLine("Июль");
                break;
            case 8:
                Console.WriteLine("Август");
                break;
            case 9:
                Console.WriteLine("Сентябрь");
                break;
            case 10:
                Console.WriteLine("Октябрь");
                break;
            case 11:
                Console.WriteLine("Ноябрь");
                break;
            case 12:
                Console.WriteLine("Декабрь");
                break;
            default:
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                break;
        }
    }
                   // 154. Ввести номер месяца (1–12). Вывести количество дней в этом месяце (для невисокосного года).
                   case 154:
                {  
                      Console.Write("Введите номер месяца (1-12): ");
                       int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("31 день");
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("30 дней");
                break;

            case 2:
                Console.WriteLine("28 дней");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                break;
        }
    }  
                // 155. Ввести номер месяца (1–12). Вывести название поры года («Зима», «Весна», «Лето», «Осень»).
                case 155:
                 {
                     Console.Write("Введите номер месяца (1-12): ");
                      int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Зима");
                break;

            case 3:
            case 4:
            case 5:
                Console.WriteLine("Весна");
                break;

            case 6:
            case 7:
            case 8:
                Console.WriteLine("Лето");
                break;

            case 9:
            case 10:
            case 11:
                Console.WriteLine("Осень");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                break;
        }
    }

              // 156. Ввести оценку студента (1–5). Вывести текстовое описание: 1 — «Очень плохо», 2 — «Неудовлетворительно», 3 — «Удовлетворительно», 4 — «Хорошо», 5 — «Отлично»
              case 156:
              {
                 Console.Write("Введите оценку студента (1-5): ");
                 int grade = int.Parse(Console.ReadLine());

        switch (grade)
        {
            case 1:
                Console.WriteLine("Очень плохо");
                break;

            case 2:
                Console.WriteLine("Неудовлетворительно");
                break;

            case 3:
                Console.WriteLine("Удовлетворительно");
                break;

            case 4:
                Console.WriteLine("Хорошо");
                break;

            case 5:
                Console.WriteLine("Отлично");
                break;

            default:
                Console.WriteLine("Ошибка: введите оценку от 1 до 5");
                break;
        }
    }

              // 157. Реализовать простой калькулятор: ввести два вещественных числа и символ арифметической операции (+, -, *, /). Через switch выполнить вычисление. Предусмотреть защиту от деления на ноль.
              case 157: 
              {
        Console.Write("Введите первое число: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine("Результат: " + (a + b));
                break;

            case '-':
                Console.WriteLine("Результат: " + (a - b));
                break;

            case '*':
                Console.WriteLine("Результат: " + (a * b));
                break;

            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                }
                else
                {
                    Console.WriteLine("Результат: " + (a / b));
                }
                break;

            default:
                Console.WriteLine("Ошибка: неизвестная операция!");
                break;
        }
    }

              // 158. Ввести букву направления света (N, S, W, E). Вывести название направления («Север», «Юг», «Запад», «Восток»).
              case 158:
              {
        Console.Write("Введите букву направления (N, S, W, E): ");
        char direction = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (direction)
        {
            case 'N':
                Console.WriteLine("Север");
                break;

            case 'S':
                Console.WriteLine("Юг");
                break;

            case 'W':
                Console.WriteLine("Запад");
                break;

            case 'E':
                Console.WriteLine("Восток");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестное направление");
                break;
        }
    }
             // 159. Ввести номер геометрической фигуры (1 — круг, 2 — прямоугольник, 3 — треугольник). Запросить соответствующие параметры фигуры и вычислить ее площадь.
             case 159:
              {
        Console.WriteLine("Выберите фигуру:");
        Console.WriteLine("1 — Круг");
        Console.WriteLine("2 — Прямоугольник");
        Console.WriteLine("3 — Треугольник");

        Console.Write("Введите номер фигуры: ");
        int figure = int.Parse(Console.ReadLine());

        switch (figure)
        {
            case 1:
                Console.Write("Введите радиус круга: ");
                double r = double.Parse(Console.ReadLine());

                double circleArea = Math.PI * r * r;
                Console.WriteLine("Площадь круга: " + circleArea);
                break;

            case 2:
                Console.Write("Введите длину прямоугольника: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Введите ширину прямоугольника: ");
                double b = double.Parse(Console.ReadLine());

                double rectangleArea = a * b;
                Console.WriteLine("Площадь прямоугольника: " + rectangleArea);
                break;

            case 3:
                Console.Write("Введите основание треугольника: ");
                double baseTriangle = double.Parse(Console.ReadLine());

                Console.Write("Введите высоту треугольника: ");
                double height = double.Parse(Console.ReadLine());

                double triangleArea = 0.5 * baseTriangle * height;
                Console.WriteLine("Площадь треугольника: " + triangleArea);
                break;

            default:
                Console.WriteLine("Ошибка: выберите число от 1 до 3");
                break;
        }
    }
            // 160. Ввести номер масти игральной карты (1 — пики, 2 — трефы, 3 — бубны, 4 — червы). Вывести название масти.
            case 160:
         {
        Console.Write("Введите номер масти (1-4): ");
        int suit = int.Parse(Console.ReadLine());

        switch (suit)
        {
            case 1:
                Console.WriteLine("Пики");
                break;

            case 2:
                Console.WriteLine("Трефы");
                break;

            case 3:
                Console.WriteLine("Бубны");
                break;

            case 4:
                Console.WriteLine("Червы");
                break;
 
            default:
                Console.WriteLine("Ошибка: введите число от 1 до 4");
                break;
        }
    }
            // 161. Ввести достоинство карты (числа от 6 до 14). Вывести название: 11 — Валет, 12 — Дама, 13 — Король, 14 — Туз, остальные — по номиналу.
            case 161: 
            {
        Console.Write("Введите достоинство карты (6-14): ");
        int card = int.Parse(Console.ReadLine());

        switch (card)
        {
            case 11:
                Console.WriteLine("Валет");
                break;

            case 12:
                Console.WriteLine("Дама");
                break;

            case 13:
                Console.WriteLine("Король");
                break;

            case 14:
                Console.WriteLine("Туз");
                break;

            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                Console.WriteLine("Карта достоинством " + card);
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 6 до 14");
                break;
        }
    }
              // 162. Ввести буквенное обозначение размера одежды (XS, S, M, L, XL, XXL). Вывести соответствующий российский размер (42, 44, 46, 48, 50, 52).
              case 162:
              {
        Console.Write("Введите размер одежды (XS, S, M, L, XL, XXL): ");
        string size = Console.ReadLine().ToUpper();

        switch (size)
        {
            case "XS":
                Console.WriteLine("Российский размер: 42");
                break;

            case "S":
                Console.WriteLine("Российский размер: 44");
                break;

            case "M":
                Console.WriteLine("Российский размер: 46");
                break;

            case "L":
                Console.WriteLine("Российский размер: 48");
                break;

            case "XL":
                Console.WriteLine("Российский размер: 50");
                break;

            case "XXL":
                Console.WriteLine("Российский размер: 52");
                break;

            default:
                Console.WriteLine("Ошибка: такого размера нет");
                break;
        }
    }
              // 163. Ввести номер единицы длины (1 — дециметр, 2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр) и длину отрезка в этих единицах. Перевести и вывести длину в метрах
              case 163:
              {
        Console.Write("Введите номер единицы длины (1-5): ");
        int unit = int.Parse(Console.ReadLine());

        Console.Write("Введите длину отрезка: ");
        double length = double.Parse(Console.ReadLine());

        double meters = 0;

        switch (unit)
        {
            case 1:
                // Дециметр
                meters = length / 10;
                break;

            case 2:
                // Километр
                meters = length * 1000;
                break;

            case 3:
                // Метр
                meters = length;
                break;

            case 4:
                // Миллиметр
                meters = length / 1000;
                break;

            case 5:
                // Сантиметр
                meters = length / 100;
                break;

            default:
                Console.WriteLine("Ошибка: введите номер от 1 до 5");
                return;
        }

        Console.WriteLine("Длина в метрах: " + meters);
    }
            // 164. Ввести номер единицы массы (1 — килограмм, 2 — миллиграмм, 3 — грамм, 4 — тонна, 5 — центнер) и массу. Вывести массу в килограммах.
            case 164:
            {
        Console.Write("Введите номер единицы массы (1-5): ");
        int unit = int.Parse(Console.ReadLine());

        Console.Write("Введите массу: ");
        double mass = double.Parse(Console.ReadLine());

        double kilograms = 0;

        switch (unit)
        {
            case 1:
                // Килограмм
                kilograms = mass;
                break;

            case 2:
                // Миллиграмм
                kilograms = mass / 1000000;
                break;

            case 3:
                // Грамм
                kilograms = mass / 1000;
                break;

            case 4:
                // Тонна
                kilograms = mass * 1000;
                break;

            case 5:
                // Центнер
                kilograms = mass * 100;
                break;

            default:
                Console.WriteLine("Ошибка: введите номер от 1 до 5");
                return;
        }

        Console.WriteLine("Масса в килограммах: " + kilograms);
    }

              // 165. Ввести код ошибки HTTP (200, 301, 400, 403, 404, 500, 502). Вывести текстовую расшифровку статуса
              case 165:
              {
        Console.Write("Введите код HTTP: ");
        int code = int.Parse(Console.ReadLine());

        switch (code)
        {
            case 200:
                Console.WriteLine("Успешный запрос");
                break;

            case 301:
                Console.WriteLine("Перемещено навсегда");
                break;

            case 400:
                Console.WriteLine("Неверный запрос");
                break;

            case 403:
                Console.WriteLine("Доступ запрещен");
                break;

            case 404:
                Console.WriteLine("Страница не найдена");
                break;

            case 500:
                Console.WriteLine("Внутренняя ошибка сервера");
                break;

            case 502:
                Console.WriteLine("Ошибка шлюза");
                break;

            default:
                Console.WriteLine("Неизвестный код ошибки");
                break;
        }
    }
             // 166. Ввести код валюты (USD, EUR, CNY, RUB). Вывести полное наименование («Доллар США», «Евро», «Китайский юань», «Российский рубль»).
             case 166:
              {
        Console.Write("Введите код валюты (USD, EUR, CNY, RUB): ");
        string currency = Console.ReadLine().ToUpper();

        switch (currency)
        {
            case "USD":
                Console.WriteLine("Доллар США");
                break;

            case "EUR":
                Console.WriteLine("Евро");
                break;

            case "CNY":
                Console.WriteLine("Китайский юань");
                break;

            case "RUB":
                Console.WriteLine("Российский рубль");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестный код валюты");
                break;
        }
    }
           // 167. Ввести символ клавиши управления движением персонажа (W, A, S, D в любом регистре). Вывести направление движения: вперед, влево, назад, вправо.
           case 167:
           {
        Console.Write("Введите клавишу (W, A, S, D): ");
        char key = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (key)
        {
            case 'W':
                Console.WriteLine("Вперед");
                break;

            case 'A':
                Console.WriteLine("Влево");
                break;

            case 'S':
                Console.WriteLine("Назад");
                break;

            case 'D':
                Console.WriteLine("Вправо");
                break;

            default:
                Console.WriteLine("Ошибка: нажмите W, A, S или D");
                break;
        }
    }

            // 168. Ввести номер цвета радуги (1–7). Вывести название цвета.
            case 168:
            {
        Console.Write("Введите номер цвета радуги (1-7): ");
        int color = int.Parse(Console.ReadLine());

        switch (color)
        {
            case 1:
                Console.WriteLine("Красный");
                break;
            case 2:
                Console.WriteLine("Оранжевый");
                break;
            case 3:
                Console.WriteLine("Желтый");
                break;
            case 4:
                Console.WriteLine("Зеленый");
                break;
            case 5:
                Console.WriteLine("Голубой");
                break;
            case 6:
                Console.WriteLine("Синий");
                break;
            case 7:
                Console.WriteLine("Фиолетовый");
                break;
            default:
                Console.WriteLine("Ошибка: введите число от 1 до 7");
                break;
        }
    }
            // 169. Ввести признак режима селектора АКПП (P, R, N, D, M). Вывести режим трансмиссии.
            case 169:
            {
        Console.Write("Введите режим АКПП (P, R, N, D, M): ");
        char mode = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (mode)
        {
            case 'P':
                Console.WriteLine("Парковка");
                break;

            case 'R':
                Console.WriteLine("Задний ход");
                break;

            case 'N':
                Console.WriteLine("Нейтраль");
                break;

            case 'D':
                Console.WriteLine("Движение вперед");
                break;

            case 'M':
                Console.WriteLine("Ручной режим");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестный режим");
                break;
        }
    }
            // 170. Ввести номер пальца руки (1 — большой, 2 — указательный, 3 — средний, 4 — безымянный, 5 — мизинец). Вывести название пальца.
            case 170:
            {
        Console.Write("Введите номер пальца (1-5): ");
        int finger = int.Parse(Console.ReadLine());

        switch (finger)
        {
            case 1:
                Console.WriteLine("Большой");
                break;

            case 2:
                Console.WriteLine("Указательный");
                break;

            case 3:
                Console.WriteLine("Средний");
                break;

            case 4:
                Console.WriteLine("Безымянный");
                break;

            case 5:
                Console.WriteLine("Мизинец");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 5");
                break;
        }
    }
            // 171. Ввести номер планеты от Солнца (1–8). Вывести название планеты Солнечной системы.
            case 171:
            {
        Console.Write("Введите номер планеты от Солнца (1-8): ");
        int planet = int.Parse(Console.ReadLine());

        switch (planet)
        {
            case 1:
                Console.WriteLine("Меркурий");
                break;

            case 2:
                Console.WriteLine("Венера");
                break;

            case 3:
                Console.WriteLine("Земля");
                break;

            case 4:
                Console.WriteLine("Марс");
                break;

            case 5:
                Console.WriteLine("Юпитер");
                break;

            case 6:
                Console.WriteLine("Сатурн");
                break;

            case 7:
                Console.WriteLine("Уран");
                break;

            case 8:
                Console.WriteLine("Нептун");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 8");
                break;
        }
    }
              // 172. Ввести код тарифа мобильной связи (1 — Базовый, 2 — Студенческий, 3 — Безлимит). Вывести абонентскую плату и включенные гигабайты.
              case 172:
               {
        Console.Write("Введите код тарифа (1-3): ");
        int tariff = int.Parse(Console.ReadLine());

        switch (tariff)
        {
            case 1:
                Console.WriteLine("Тариф: Базовый");
                Console.WriteLine("Абонентская плата: 300 рублей");
                Console.WriteLine("Включено: 10 ГБ");
                break;

            case 2:
                Console.WriteLine("Тариф: Студенческий");
                Console.WriteLine("Абонентская плата: 200 рублей");
                Console.WriteLine("Включено: 20 ГБ");
                break;

            case 3:
                Console.WriteLine("Тариф: Безлимит");
                Console.WriteLine("Абонентская плата: 600 рублей");
                Console.WriteLine("Включено: безлимитный интернет");
                break;

            default:
                Console.WriteLine("Ошибка: введите код от 1 до 3");
                break;
        }
    }
              // 173. Ввести номер квартала года (1–4). Вывести список входящих в него месяцев.
              case 173:
              {
        Console.Write("Введите номер квартала (1-4): ");
        int quarter = int.Parse(Console.ReadLine());

        switch (quarter)
        {
            case 1:
                Console.WriteLine("Январь, Февраль, Март");
                break;

            case 2:
                Console.WriteLine("Апрель, Май, Июнь");
                break;

            case 3:
                Console.WriteLine("Июль, Август, Сентябрь");
                break;

            case 4:
                Console.WriteLine("Октябрь, Ноябрь, Декабрь");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 4");
                break;
        }
    }
              // 174. Ввести букву оценки американской системы (A, B, C, D, F). Вывести эквивалент в пятибалльной системе РФ.
              case 174:
              {
        Console.Write("Введите оценку (A, B, C, D, F): ");
        char grade = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (grade)
        {
            case 'A':
                Console.WriteLine("5 — Отлично");
                break;

            case 'B':
                Console.WriteLine("4 — Хорошо");
                break;

            case 'C':
                Console.WriteLine("3 — Удовлетворительно");
                break;

            case 'D':
                Console.WriteLine("3 — Удовлетворительно");
                break;

            case 'F':
                Console.WriteLine("2 — Неудовлетворительно");
                break;

            default:
                Console.WriteLine("Ошибка: введите A, B, C, D или F");
                break;
        }
    }
              // 175. Ввести символ операции над множествами (U — объединение, I — пересечение, D — разность). Вывести расшифровку операции.
              case 175:
               {
        Console.Write("Введите символ операции (U, I, D): ");
        char operation = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (operation)
        {
            case 'U':
                Console.WriteLine("Объединение");
                break;

            case 'I':
                Console.WriteLine("Пересечение");
                break;

            case 'D':
                Console.WriteLine("Разность");
                break;

            default:
                Console.WriteLine("Ошибка: введите U, I или D");
                break;
        }
    }
                // 176. Ввести номер режима работы светофора (1 — Красный, 2 — Желтый, 3 — Зеленый, 4 — Мигающий желтый). Вывести предписание для водителя.
                case 176:
                {
        Console.Write("Введите номер режима светофора (1-4): ");
        int mode = int.Parse(Console.ReadLine());

        switch (mode)
        {
            case 1:
                Console.WriteLine("Стоп");
                break;

            case 2:
                Console.WriteLine("Внимание, приготовиться к движению");
                break;

            case 3:
                Console.WriteLine("Движение разрешено");
                break;

            case 4:
                Console.WriteLine("Внимание, двигаться с осторожностью");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 4");
                break;
        }
    }
                 // 177. Ввести цифру (0–9). Вывести ее словесное написание на русском языке.
                 case 177:
                 {
        Console.Write("Введите цифру (0-9): ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 0:
                Console.WriteLine("Ноль");
                break;

            case 1:
                Console.WriteLine("Один");
                break;

            case 2:
                Console.WriteLine("Два");
                break;

            case 3:
                Console.WriteLine("Три");
                break;

            case 4:
                Console.WriteLine("Четыре");
                break;

            case 5:
                Console.WriteLine("Пять");
                break;

            case 6:
                Console.WriteLine("Шесть");
                break;

            case 7:
                Console.WriteLine("Семь");
                break;

            case 8:
                Console.WriteLine("Восемь");
                break;

            case 9:
                Console.WriteLine("Девять");
                break;

            default:
                Console.WriteLine("Ошибка: введите цифру от 0 до 9");
                break;
        }
    }
                  // 178. Ввести римскую цифру (I, V, X, L, C, D, M). Вывести ее арабское значение.
                  case 178:
                   {
        Console.Write("Введите римскую цифру (I, V, X, L, C, D, M): ");
        char roman = char.ToUpper(char.Parse(Console.ReadLine()));

        switch (roman)
        {
            case 'I':
                Console.WriteLine("1");
                break;

            case 'V':
                Console.WriteLine("5");
                break;

            case 'X':
                Console.WriteLine("10");
                break;

            case 'L':
                Console.WriteLine("50");
                break;

            case 'C':
                Console.WriteLine("100");
                break;

            case 'D':
                Console.WriteLine("500");
                break;

            case 'M':
                Console.WriteLine("1000");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестная римская цифра");
                break;
        }
    }
                // 179. Ввести номер типа транспортного средства (1 — Мотоцикл, 2 — Легковой авто, 3 — Грузовой авто, 4 — Автобус). Вывести категорию водительского удостоверения (A, B, C, D).
                case 179:
                {
        Console.Write("Введите номер типа транспорта (1-4): ");
        int transport = int.Parse(Console.ReadLine());

        switch (transport)
        {
            case 1:
                Console.WriteLine("Категория водительского удостоверения: A");
                break;

            case 2:
                Console.WriteLine("Категория водительского удостоверения: B");
                break;

            case 3:
                Console.WriteLine("Категория водительского удостоверения: C");
                break;

            case 4:
                Console.WriteLine("Категория водительского удостоверения: D");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 4");
                break;
        }
    }
                // 180. Ввести тип двигателя (1 — Бензиновый, 2 — Дизельный, 3 — Гибридный, 4 — Электрический). Вывести вид используемого источника энергии.
                case 180:
                {
        Console.Write("Введите тип двигателя (1-4): ");
        int engine = int.Parse(Console.ReadLine());

        switch (engine)
        {
            case 1:
                Console.WriteLine("Источник энергии: бензин");
                break;

            case 2:
                Console.WriteLine("Источник энергии: дизельное топливо");
                break;

            case 3:
                Console.WriteLine("Источник энергии: бензин и электричество");
                break;

            case 4:
                Console.WriteLine("Источник энергии: электричество");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 4");
                break;
        }
    }
               // 181. Ввести номер операции в банкомате: 1 — Баланс, 2 — Снятие наличных, 3 — Пополнение, 4 — Перевод. Вывести сообщение о начале выбранной процедуры.
               case 181:
               {
        Console.Write("Введите номер операции (1-4): ");
        int operation = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Начало процедуры проверки баланса.");
                break;

            case 2:
                Console.WriteLine("Начало процедуры снятия наличных.");
                break;

            case 3:
                Console.WriteLine("Начало процедуры пополнения счета.");
                break;

            case 4:
                Console.WriteLine("Начало процедуры перевода.");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 4");
                break;
        }
    }
                // 182. Ввести расширение файла (txt, cs, html, png, mp3). Вывести тип содержимого: текстовый документ, исходный код C#, веб-страница, изображение, аудиофайл.
                case 182:
                {
        Console.Write("Введите расширение файла (txt, cs, html, png, mp3): ");
        string extension = Console.ReadLine().ToLower();

        switch (extension)
        {
            case "txt":
                Console.WriteLine("Текстовый документ");
                break;

            case "cs":
                Console.WriteLine("Исходный код C#");
                break;

            case "html":
                Console.WriteLine("Веб-страница");
                break;

            case "png":
                Console.WriteLine("Изображение");
                break;

            case "mp3":
                Console.WriteLine("Аудиофайл");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестное расширение файла");
                break;
        }
    }
                // 183. Ввести номер химического элемента из первых пяти таблицы Менделеева (1–5). Вывести название элемента и его символ.
                case 183:
                 {
        Console.Write("Введите номер химического элемента (1-5): ");
        int element = int.Parse(Console.ReadLine());

        switch (element)
        {
            case 1:
                Console.WriteLine("Водород (H)");
                break;

            case 2:
                Console.WriteLine("Гелий (He)");
                break;

            case 3:
                Console.WriteLine("Литий (Li)");
                break;

            case 4:
                Console.WriteLine("Бериллий (Be)");
                break;

            case 5:
                Console.WriteLine("Бор (B)");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 5");
                break;
        }
    }
               // 184. Ввести код статуса заказа в интернет-магазине (NEW, PAID, SHIPPED, DELIVERED, CANCELED). Вывести подсказку для клиента.
               case 184:
               {
        Console.Write("Введите статус заказа (NEW, PAID, SHIPPED, DELIVERED, CANCELED): ");
        string status = Console.ReadLine().ToUpper();

        switch (status)
        {
            case "NEW":
                Console.WriteLine("Заказ принят и ожидает оплаты.");
                break;

            case "PAID":
                Console.WriteLine("Заказ оплачен и готовится к отправке.");
                break;

            case "SHIPPED":
                Console.WriteLine("Заказ отправлен. Ожидайте доставку.");
                break;

            case "DELIVERED":
                Console.WriteLine("Заказ доставлен.");
                break;

            case "CANCELED":
                Console.WriteLine("Заказ отменен.");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестный статус заказа.");
                break;
        }
    }
               // 185. Ввести код системы счисления (2, 8, 10, 16) и перевести введенное десятичное число в выбранную систему (через методы класса Convert).
               case 185:
               {
        Console.Write("Введите десятичное число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Введите систему счисления (2, 8, 10, 16): ");
        int system = int.Parse(Console.ReadLine());

        string result;

        switch (system)
        {
            case 2:
                result = Convert.ToString(number, 2);
                break;

            case 8:
                result = Convert.ToString(number, 8);
                break;

            case 10:
                result = Convert.ToString(number, 10);
                break;

            case 16:
                result = Convert.ToString(number, 16).ToUpper();
                break;

            default:
                Console.WriteLine("Ошибка: выберите систему 2, 8, 10 или 16");
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
               // 186. Ввести номер курса колледжа (1–4). Вывести: «Первокурсник», «Второй курс», «Предвыпускной курс», «Выпускник».
               case 186:
                {
        Console.Write("Введите номер курса (1-4): ");
        int course = int.Parse(Console.ReadLine());

        switch (course)
        {
            case 1:
                Console.WriteLine("Первокурсник");
                break;

            case 2:
                Console.WriteLine("Второй курс");
                break;

            case 3:
                Console.WriteLine("Предвыпускной курс");
                break;

            case 4:
                Console.WriteLine("Выпускник");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 4");
                break;
        }
    }
               // 187. Ввести код климатической зоны
               case 187:
               {
        Console.Write("Введите код климатической зоны (1-5): ");
        int zone = int.Parse(Console.ReadLine());

        switch (zone)
        {
            case 1:
                Console.WriteLine("Арктическая — очень холодный климат, длительная зима, короткое лето.");
                break;

            case 2:
                Console.WriteLine("Субарктическая — холодная зима, прохладное короткое лето.");
                break;

            case 3:
                Console.WriteLine("Умеренная — выражены четыре времени года, умеренные температуры.");
                break;

            case 4:
                Console.WriteLine("Субтропическая — мягкая зима, жаркое лето.");
                break;

            case 5:
                Console.WriteLine("Тропическая — жарко круглый год, высокая температура.");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 5.");
                break;
        }
    }
                // 188. Ввести класс пожарной опасности (1–5). Вывести уровень угрозы и ограничения на посещение лесов.
                case 188:
                {
        Console.Write("Введите класс пожарной опасности (1-5): ");
        int danger = int.Parse(Console.ReadLine());

        switch (danger)
        {
            case 1:
                Console.WriteLine("Уровень угрозы: низкий.");
                Console.WriteLine("Посещение лесов разрешено.");
                break;

            case 2:
                Console.WriteLine("Уровень угрозы: небольшой.");
                Console.WriteLine("Посещение лесов разрешено с осторожностью.");
                break;

            case 3:
                Console.WriteLine("Уровень угрозы: средний.");
                Console.WriteLine("Посещение лесов ограничено.");
                break;

            case 4:
                Console.WriteLine("Уровень угрозы: высокий.");
                Console.WriteLine("Посещение лесов запрещено.");
                break;

            case 5:
                Console.WriteLine("Уровень угрозы: чрезвычайно высокий.");
                Console.WriteLine("Посещение лесов строго запрещено.");
                break;

            default:
                Console.WriteLine("Ошибка: введите класс от 1 до 5.");
                break;
        }
    }
               // 189. Ввести номер спортивного разряда (1 — Юношеский, 2 — Взрослый, 3 — КМС, 4 — МС, 5 — МСМК). Вывести расшифровку.
               case 189:
               {
        Console.Write("Введите номер спортивного разряда (1-5): ");
        int rank = int.Parse(Console.ReadLine());

        switch (rank)
        {
            case 1:
                Console.WriteLine("Юношеский");
                break;

            case 2:
                Console.WriteLine("Взрослый");
                break;

            case 3:
                Console.WriteLine("КМС — кандидат в мастера спорта");
                break;

            case 4:
                Console.WriteLine("МС — мастер спорта");
                break;

            case 5:
                Console.WriteLine("МСМК — мастер спорта международного класса");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 5.");
                break;
        }
    }
              // 190. Ввести код уровня доступа пользователя (G — Guest, U — User, M — Moderator, A — Administrator). Вывести перечень разрешенных действий.
              case 190:
              {
        Console.Write("Введите код уровня доступа (G, U, M, A): ");
        char access = char.ToUpper(Console.ReadLine()[0]);

        switch (access)
        {
            case 'G':
                Console.WriteLine("Guest — просмотр общедоступной информации.");
                break;

            case 'U':
                Console.WriteLine("User — просмотр и редактирование своих данных.");
                break;

            case 'M':
                Console.WriteLine("Moderator — управление пользователями и модерация контента.");
                break;

            case 'A':
                Console.WriteLine("Administrator — полный доступ ко всем функциям системы.");
                break;

            default:
                Console.WriteLine("Ошибка: введите G, U, M или A.");
                break;
        }
    }
              // 191. Ввести букву ноты (C, D, E, F, G, A, B). Вывести русское словесное обозначение (До, Ре, Ми, Фа, Соль, Ля, Си).
              case 191:
              {
        Console.Write("Введите букву ноты (C, D, E, F, G, A, B): ");
        char note = char.ToUpper(Console.ReadLine()[0]);

        switch (note)
        {
            case 'C':
                Console.WriteLine("До");
                break;

            case 'D':
                Console.WriteLine("Ре");
                break;

            case 'E':
                Console.WriteLine("Ми");
                break;

            case 'F':
                Console.WriteLine("Фа");
                break;

            case 'G':
                Console.WriteLine("Соль");
                break;

            case 'A':
                Console.WriteLine("Ля");
                break;

            case 'B':
                Console.WriteLine("Си");
                break;

            default:
                Console.WriteLine("Ошибка: введите букву от C до B.");
                break;
        }
    }
             // 192. Ввести номер типа кузова автомобиля (1 — Седан, 2 — Хэтчбек, 3 — Универсал, 4 — Купе, 5 — Внедорожник). Вывести описание вместимости и компоновки.
             case 192:
             {
        Console.Write("Введите номер типа кузова (1-5): ");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                Console.WriteLine("Седан — 4 двери, отдельный багажник, вместительный салон.");
                break;

            case 2:
                Console.WriteLine("Хэтчбек — компактный кузов, багажник объединён с салоном.");
                break;

            case 3:
                Console.WriteLine("Универсал — увеличенный багажник, просторный салон.");
                break;

            case 4:
                Console.WriteLine("Купе — обычно 2 двери, компактный салон, спортивная компоновка.");
                break;

            case 5:
                Console.WriteLine("Внедорожник — просторный салон, большой багажник, высокая посадка.");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 5.");
                break;
        }
    }
             // 193. Ввести код типа датчика охранной сигнализации: M (движение), D (открытие двери), S (дым), W (протечка воды). Вывести сообщение о типе угрозы.
             case 193:
             {
        Console.Write("Введите код датчика (M, D, S, W): ");
        char sensor = char.ToUpper(Console.ReadLine()[0]);

        switch (sensor)
        {
            case 'M':
                Console.WriteLine("Угроза: обнаружено движение.");
                break;

            case 'D':
                Console.WriteLine("Угроза: открыта дверь.");
                break;

            case 'S':
                Console.WriteLine("Угроза: обнаружен дым.");
                break;

            case 'W':
                Console.WriteLine("Угроза: обнаружена протечка воды.");
                break;

            default:
                Console.WriteLine("Ошибка: введите M, D, S или W.");
                break;
        }
    }
             // 194. Ввести номер фазы Луны (1 — Новолуние, 2 — Первая четверть, 3 — Полнолуние, 4 — Последняя четверть). Вывести характеристику фазы.
             case 194:
             {
        Console.Write("Введите номер фазы Луны (1-4): ");
        int phase = int.Parse(Console.ReadLine());

        switch (phase)
        {
            case 1:
                Console.WriteLine("Новолуние — Луна практически не видна с Земли.");
                break;

            case 2:
                Console.WriteLine("Первая четверть — видна половина лунного диска.");
                break;

            case 3:
                Console.WriteLine("Полнолуние — Луна полностью освещена Солнцем.");
                break;

            case 4:
                Console.WriteLine("Последняя четверть — снова видна половина лунного диска.");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 4.");
                break;
        }
    }
             // 195. Ввести символ разделителя пути в операционной системе (/ или \). Вывести, к какому семейству ОС относится разделитель (Unix/Linux или Windows).
             case 195:
              {
        Console.Write("Введите символ разделителя пути (/ или \\): ");
        char separator = Console.ReadLine()[0];

        switch (separator)
        {
            case '/':
                Console.WriteLine("Unix/Linux");
                break;

            case '\\':
                Console.WriteLine("Windows");
                break;

            default:
                Console.WriteLine("Ошибка: введите / или \\.");
                break;
        }
    }
             // 196. Ввести номер поколения мобильной связи (2, 3, 4, 5). Вывести название стандарта (GPRS/EDGE, UMTS/HSPA, LTE, NR) и типичную скорость.
             case 196:
             {
        Console.Write("Введите поколение мобильной связи (2, 3, 4, 5): ");
        int generation = int.Parse(Console.ReadLine());

        switch (generation)
        {
            case 2:
                Console.WriteLine("GPRS/EDGE — типичная скорость до 0,1–0,3 Мбит/с.");
                break;

            case 3:
                Console.WriteLine("UMTS/HSPA — типичная скорость до 1–10 Мбит/с.");
                break;

            case 4:
                Console.WriteLine("LTE — типичная скорость 10–100 Мбит/с.");
                break;

            case 5:
                Console.WriteLine("NR — типичная скорость 100 Мбит/с и выше.");
                break;

            default:
                Console.WriteLine("Ошибка: введите поколение 2, 3, 4 или 5.");
                break;
        }
    }
              // 197. Ввести номер порта протокола (21, 22, 25, 80, 443). Вывести название сетевого протокола (FTP, SSH, SMTP, HTTP, HTTPS).
              case 197:
              {
        Console.Write("Введите номер порта (21, 22, 25, 80, 443): ");
        int port = int.Parse(Console.ReadLine());

        switch (port)
        {
            case 21:
                Console.WriteLine("FTP");
                break;

            case 22:
                Console.WriteLine("SSH");
                break;

            case 25:
                Console.WriteLine("SMTP");
                break;

            case 80:
                Console.WriteLine("HTTP");
                break;

            case 443:
                Console.WriteLine("HTTPS");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестный порт.");
                break;
        }
    }
               // 198. Ввести код режима стиральной машины (1 — Хлопок, 2 — Синтетика, 3 — Шерсть, 4 — Быстрая 15 мин, 5 — Отжим). Вывести температуру стирки и скорость отжима.
               case 198: 
               {
        Console.Write("Введите номер порта (21, 22, 25, 80, 443): ");
        int port = int.Parse(Console.ReadLine());

        switch (port)
        {
            case 21:
                Console.WriteLine("FTP");
                break;

            case 22:
                Console.WriteLine("SSH");
                break;

            case 25:
                Console.WriteLine("SMTP");
                break;

            case 80:
                Console.WriteLine("HTTP");
                break;

            case 443:
                Console.WriteLine("HTTPS");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестный порт.");
                break;
        }
    }
               // 199. Ввести код тарифной зоны электроэнергии (1 — Пик, 2 — Полупик, 3 — Ночь). Вывести стоимость киловатт-часа.
               case 199: 
               {
        Console.Write("Введите код режима стирки (1-5): ");
        int mode = int.Parse(Console.ReadLine());

        switch (mode)
        {
            case 1:
                Console.WriteLine("Хлопок — температура 60°C, отжим 1000 об/мин.");
                break;

            case 2:
                Console.WriteLine("Синтетика — температура 40°C, отжим 800 об/мин.");
                break;

            case 3:
                Console.WriteLine("Шерсть — температура 30°C, отжим 400 об/мин.");
                break;

            case 4:
                Console.WriteLine("Быстрая 15 мин — температура 30°C, отжим 800 об/мин.");
                break;

            case 5:
                Console.WriteLine("Отжим — температура не используется, отжим 1200 об/мин.");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 5.");
                break;
        }
    }
                // 200. Ввести код состояния потока выполнения в C# (Running, Suspended, Stopped, Aborted). Вывести пояснение жизненного цикла потока.
                case 200:
                {
        Console.Write("Введите код тарифной зоны (1-3): ");
        int zone = int.Parse(Console.ReadLine());

        switch (zone)
        {
            case 1:
                Console.WriteLine("Пик — стоимость 1 кВт·ч: 7 рублей.");
                break;

            case 2:
                Console.WriteLine("Полупик — стоимость 1 кВт·ч: 5 рублей.");
                break;

            case 3:
                Console.WriteLine("Ночь — стоимость 1 кВт·ч: 3 рубля.");
                break;

            default:
                Console.WriteLine("Ошибка: введите число от 1 до 3.");
                break;
        }
    }
