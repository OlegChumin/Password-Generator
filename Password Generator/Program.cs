using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину пароля: "); // Запрашиваем у пользователя длину пароля
        int passwordLength = int.Parse(Console.ReadLine()); // Считываем длину пароля, введенную пользователем, и преобразуем ее в целое число

        Console.Write("Введите допустимые символы: "); // Запрашиваем у пользователя допустимые символы для пароля
        string allowedCharacters = Console.ReadLine(); // Считываем допустимые символы для пароля, введенные пользователем, и сохраняем их в переменной allowedCharacters

        Random random = new Random(); // Создаем экземпляр класса Random для генерации случайных чисел
        List<char> passwordCharacters = new List<char>(); // Создаем список, который будет хранить символы, из которых будет состоять пароль

        for (int i = 0; i < passwordLength; i++) // Запускаем цикл, который будет генерировать символы пароля нужной длины
        {
            int randomIndex = random.Next(0, allowedCharacters.Length); // Генерируем случайный индекс в диапазоне от 0 до длины строки allowedCharacters
            char randomCharacter = allowedCharacters[randomIndex]; // Получаем случайный символ из строки allowedCharacters по сгенерированному индексу
            passwordCharacters.Add(randomCharacter); // Добавляем полученный символ в список символов пароля
        }

        string password = string.Join("", passwordCharacters); // Преобразуем список символов пароля в строку, объединив все символы в одну строку

        Console.WriteLine($"Сгенерированный пароль: {password}"); // Выводим на экран сгенерированный пароль

        Console.ReadLine(); // Ждем, пока пользователь нажмет клавишу Enter, чтобы окно консоли не закрылось сразу после вывода пароля
    }
}
