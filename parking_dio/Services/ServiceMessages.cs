using parking_dio.Strings;

namespace parking_dio.Services
{
    public static class ServiceMessages
    {
        private static Dictionary<int, string> _messageOptions;

        static ServiceMessages()
        {
            _messageOptions = new Dictionary<int, string> 
            {
                {0, StringMessage.startMenuMessageOption},
                {1, StringMessage.registerNewVehicleOption},
                {2, StringMessage.listAllVehiclesOption},
                {3, StringMessage.unregisterNewVehicleOption},
                {4, StringMessage.endProgramOption}
            };
        }

        public static void StartProgram()
        {
            Console.WriteLine(StringMessage.startProgramMessage);
            Console.Write(StringMessage.loading);
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500);
                Console.Write('.');
            }
            Console.WriteLine();
        }

        public static void MenuOptions()
        {
            for (int i = 0; i < _messageOptions.Count; i++)
            {
                Console.WriteLine(_messageOptions[i]);
                Thread.Sleep(500);
            }
        }

        public static void InvalidOption()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(StringMessage.invalidOption);
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void PlateIsNotValid()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(StringMessage.plateIsNotValid);
            Console.ResetColor();
            Thread.Sleep(2000);
        }

        public static void ExitListVehicles()
        {
            Console.WriteLine(StringMessage.finishListVehicles);
            Console.ReadKey();
            Console.Clear();
        }

        public static void MessageAndClear(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep(2000);
            Console.Clear();
        }


    }
}
