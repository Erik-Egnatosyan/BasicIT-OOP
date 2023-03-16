using System.Diagnostics;

namespace PolindromRandomChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //avenacieeseesniaevac
            string str = "avenacieeseesniaevac"; // Определяем строку для проверки на палиндром
            // Удаляем пробелы из строки и приводим все символы к нижнему регистру
            str = str.Replace(" ", "");
            str = str.ToLower();
            // Создаем временную строку, счетчик для разделителей
            string tempstr = "";
            int breakCount = 0;
            // Проходим по всем символам в строке
            for (int i = 0; i < str.Length; i++)
            {
                bool check = tempstr.Contains(str[i]);// Проверяем, содержит ли временная строка текущий символ
                int letterCount = 0;// Сбрасываем счетчик букв до 0
                if (breakCount <= 1)  // Если разделителей не больше 1
                {
                    if (check != true) // Если текущий символ не содержится во временной строке
                    {
                        for (int j = i; j < str.Length; j++)// Проходим по всей строке, начиная с текущей позиции
                        {
                            if (str[i] == str[j]) // Если текущий символ равен текущему символу во внутреннем цикле
                            {
                                // Увеличиваем счетчик букв на 1 и добавляем текущий символ во временную строку
                                letterCount++;
                                tempstr += str[i];
                            }
                        }
                        // Если количество букв нечетное, увеличиваем счетчик разделителей на 1
                        if (letterCount % 2 == 1)
                            breakCount++;
                    }
                }
                else
                    // Если количество разделителей больше 1, выходим из цикла
                    break;
            }

            // Если количество разделителей не больше 1, выводим сообщение о том, что строка является палиндромом
            if (breakCount <= 1)
                Console.WriteLine("This text can be Polindrom!");
            else
                // Иначе выводим сообщение о том, что строка не является палиндромом
                Console.WriteLine("Ou...Sorry! Your text can't be Polindrom!");
            double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine("Время выполнения: {0:F5} секунд", elapsedSeconds);
        }
    }
}