using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEven = IsEven();
            if (isEven)
            {
                Console.WriteLine("Twoja liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Twoja liczba nie jest parzysta.");
            }
        }

        public static int LoadingNumber() //wczytywanie danych od użytkownika
        {
            var userNumber = 0;
            try
            {
                Console.WriteLine("Podaj swoja liczbe.");
                userNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) //obsługiwanie błędów
            {
                Console.WriteLine("Nieprawidłowe dane");
                Console.ReadLine();
                Environment.Exit(1);
               
            }
            return userNumber;
        }

        public static bool IsEven() //czy parzysta
        {
            var userNumber = LoadingNumber();
            if (userNumber % 2 == 0) //jest parzysta
            {
                return true;
            }
            else //nie jest parzysta
            {
                return false;
            }
        }

    }
}
