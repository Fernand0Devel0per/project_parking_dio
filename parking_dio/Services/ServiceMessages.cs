using parking_dio.Strings;

namespace parking_dio.Services
{
    public static class ServiceMessages
    {

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
    }
}
