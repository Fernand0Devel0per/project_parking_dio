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
                MakeRequest(option);
            } while (option != (int)MenuOptions.EndProgram);
            
        }

        private static void MakeRequest(int option)
        {
            switch (option)
            {
                case (int)MenuOptions.RegisterNewVehicle:
                    //TODO Metodo que cadastra Veiculo
                    Console.WriteLine("Cadastrar Veiculo");
                    break;
                case (int)MenuOptions.ListAllVehicles:
                    //TODO Metodo que Lista Veiculos
                    Console.WriteLine("Listar Veiculo");
                    break;
                case (int)MenuOptions.RemoveAVehicle:
                    //TODO Metodo que Remove Veiculos;
                    Console.WriteLine("Remover Veiculo");
                    break;
                case (int)MenuOptions.EndProgram:
                    Console.WriteLine("Encerrando o Programa");
                    break;
                default:
                    ServiceMessages.InvalidOption();
                    break;
            }
        }

    }
}
