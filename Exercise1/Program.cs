using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");

            string[] userSplitText = SplitText(Console.ReadLine()); // Вызов метода разделения строк. В качестве передавамего параметра используется введенный пользователем текст

            ShowSplitText(userSplitText);

            Console.ReadKey();

        }

        /// <summary>
        /// Метод разделяет предложение на отдельные слова. В качестве разделителя используется смвол " ".
        /// Возвращается массив типа string в котором содержаться слова предложения.
        /// </summary>
        /// <param name="text"> Предложение, которое будет разделено на слова</param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            return text.Split(" ");
        }


        /// <summary>
        /// Метод выводит каждое значение передаваемого массива на отдельной строке
        /// </summary>
        /// <param name="text"></param>
        static void ShowSplitText(string[] text)
        {
            Console.WriteLine("Вывод каждого слова в отдельной строке:\n");
            foreach (string t in text)
            {
                Console.WriteLine(t);
            }
        }
    }
}
