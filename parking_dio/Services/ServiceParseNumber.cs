using parking_dio.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking_dio.Services
{
    public static class ServiceParseNumber
    {
        static bool isSucess = false;
        static decimal valueDecimal = new decimal(0.00);
        static int valueInt = 0;

        public static decimal ReceiveDecimal(string message)
        {
            while (!isSucess)
            {
                Console.Write(message);
                isSucess = decimal.TryParse(Console.ReadLine(), out valueDecimal);
                if (!isSucess)
                {
                    Console.WriteLine(StringMessage._invalidInput);
                }

            }
            isSucess = false;
            return valueDecimal;
        }

        public static int ReceiveInt(string message)
        {
            while (!isSucess)
            {
                Console.Write(message);
                isSucess = int.TryParse(Console.ReadLine(), out valueInt);
                if (!isSucess)
                {
                    Console.WriteLine(StringMessage._invalidInput);
                }

            }
            isSucess = false;
            return valueInt;
        }
    }

   
}
