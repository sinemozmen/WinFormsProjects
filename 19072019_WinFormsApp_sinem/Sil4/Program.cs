using System;

namespace Sil4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 123.456F;
            Calculate(a);
            Console.ReadLine();
        }
        public static void Calculate(float amount)
        {
            object amountRef = amount;
            //int balance = (int)(float)amountRef;// 123 gösterecek.
            //int balance = (int)amountRef;//Exception verir.
            //int balance = Convert.ToInt32(amountRef);//implicitly convert ile obj olan bir değişkeni int'e çevirebiliriz.
          // int balance = amountRef;
          int balance = (int)(double)amountRef;
            Console.WriteLine(balance);
        }


    }
}
