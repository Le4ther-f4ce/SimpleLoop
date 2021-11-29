using System;

namespace SimpleLoop
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Введите фразу, которую необходимо повторить: ");
            string userText = Console.ReadLine();

            Console.WriteLine("Укажите количество повторений: ");
            int totalRepetitions = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < totalRepetitions; ++i)
            {
                Console.WriteLine(userText);
            }
        }
    }
}
