using parking_dio.Auxiliaries.Enums;
using parking_dio.Strings;

namespace parking_dio.Services
{
    public static class ServiceProgram
    {
        public static void MenuExecution()
        {
            int option = 0;
            do
            {
                ServiceMessages.MenuOptions();
                option = ServiceParseNumber.ReceiveInt(StringMessage.chooseOptionMessage);
                if (option < 1 || option > 4)
                {
                    ServiceMessages.InvalidOption();
                    continue;
                }
            } while (option != (int)MenuOptions.EndProgram);
            
        }

    }
}
