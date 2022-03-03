using System;

namespace valyuta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("XAIS EDIRIK VALYUTANIZI SECIN: EUR,USD,RUB");
                string money = Console.ReadLine();


                double aznRub = 0.020;
                double aznUsd = 1.7;
                double aznEvro = 1.92;
                double result;



                if (money == "EUR")
                {

                    try
                    {
                        Console.WriteLine("LUTFEN, MEBLEQİ DAXIL EDIN.");
                        double EUR = Convert.ToDouble(Console.ReadLine());
                        result = EUR * aznEvro;
                        Console.WriteLine(result + " AZN");

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ERROR");
                    }

                }
                else if (money == "USD")
                {
                    try
                    {
                        Console.WriteLine("LUTFEN, MEBLEQİ DAXIL EDIN.");
                        double USD = Convert.ToDouble(Console.ReadLine());
                        result = USD * aznUsd;
                        Console.WriteLine(result + " AZN");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ERROR");
                    }

                }
                else if (money == "RUB")
                {
                    try
                    {
                        Console.WriteLine("LUTFEN, MEBLEQİ DAXIL EDIN.");
                        double RUB = Convert.ToDouble(Console.ReadLine());
                        result = RUB * aznRub;
                        Console.WriteLine(result + " AZN");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ERROR");
                    }
                }
                else
                {

                    Console.WriteLine("BELE BIR VALYUTA SİSTEMDE YOXDUR");


                }
                Console.WriteLine("Yenide bawlmaq ucun < Enter > duymesini basin");
                Console.ReadLine();

            }
        }
    }
}
