/// <summary>
/// Суть этого задания - собрать данные от пользователя и проверить их правильность.
/// Мы спрашиваем имя, возраст, рост и зарплату.
/// Для чисел используем TryParse - чтобы программа не ломалась, если ввод неправильный.
/// Добавляем проверки: возраст должен быть от 0 до 120, зарплата больше 0.
/// Если ввод некорректный - просим повторить.
/// В конце выводим таблицу с данными пользователя.
/// </summary>
class Program
{
    static void Main()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        int age;
        while (true)
        {
            Console.Write("Введите возраст (0-120): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out age) && age >= 0 && age <= 120)
                break;
            else
                Console.WriteLine("Ошибка! Введите корректный возраст.");
        }

        double height;
        while (true)
        {
            Console.Write("Введите рост (в метрах, например 1.75): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out height) && height > 0)
                break;
            else
                Console.WriteLine("Ошибка! Введите корректный рост.");
        }

        decimal salary;
        while (true)
        {
            Console.Write("Введите зарплату (>0): ");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out salary) && salary > 0)
                break;
            else
                Console.WriteLine("Ошибка! Введите корректную зарплату.");
        }

        Console.WriteLine("\nРезюме пользователя:");
        Console.WriteLine("{0,-10} {1,10}", "Поле", "Значение");
        Console.WriteLine("{0,-10} {1,10}", "Имя", name);
        Console.WriteLine("{0,-10} {1,10}", "Возраст", age);
        Console.WriteLine("{0,-10} {1,10}", "Рост", height);
        Console.WriteLine("{0,-10} {1,10:C}", "Зарплата", salary);
    }
}
