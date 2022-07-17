using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу:");
            string reverseUserText = ReverseWords(Console.ReadLine());
            Console.WriteLine($"Инвертированная фраза:\n{reverseUserText}");
        }


        /// <summary>
        /// Метод меняет местами слова во фразе, которая передается в метод.
        /// Внутри метода вызывается метод, котрый разделяет фразу на отдельные слова
        /// </summary>
        /// <param name="inputPrahse">Фраза, которая будет инвертирована</param>
        /// <returns></returns>
        static string ReverseWords(string inputPrahse)
        {
            string[] splitPrahse = SplitText(inputPrahse);
            string reversWords = "";
            for (int i = splitPrahse.Length-1; i >= 0; i--)
            {
                reversWords += splitPrahse[i] + " ";
            }
            return reversWords;
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
    }
}
