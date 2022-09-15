using parking_dio.Auxiliaries.Enums;
using parking_dio.Models;
using parking_dio.Strings;
using System.Text.RegularExpressions;

namespace parking_dio.Services
{
    public static class ServiceProgram
    {
        private static Parking _parking;
        public static void MenuExecution(Parking parking)
        {
            _parking = parking;

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

        private static void RegisterNewVehicle()
        {
            string licensePlate = string.Empty;
            Console.Clear();
            var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");

        }

    }
}
