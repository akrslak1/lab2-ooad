using System;

namespace KonzolnaAplikacija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 6 brojeva razdvojenih zarezom: ");
            string input = Console.ReadLine();
            string[] singleNum = input.Split(",");
            int[] intNum = new int[singleNum.Length];

            for (int i = 0; i < intNum.Length; i++)
            {
                intNum[i] = Int32.Parse(singleNum[i]);
            }

            bool allPositiv = true;
            int[] oddNum = new int[intNum.Length];
            int oddCounter = 0;

            for (int i = 0; i < intNum.Length; i++)
            {
                if (intNum[i] < 0) allPositiv = false;

                if (intNum[i] % 2 != 0)
                {
                    oddNum[oddCounter] = intNum[i];
                    oddCounter++;
                }
            }

            string line = allPositiv ? "nema" : "ima";
            Console.WriteLine("U nizu " + line + " negativnih brojeva!");

            Console.Write("Neparni brojevi: ");
            for(int i = 0; i < oddCounter; i++)
            {
                Console.Write(oddNum[i] + " ");
            }
        }
    }
}
