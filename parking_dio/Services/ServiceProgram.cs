using parking_dio.Auxiliaries;
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
                    RegisterNewVehicle();
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
            licensePlate = ValidadePlate();

        }

        private static string ValidadePlate()
        {
            string plate = string.Empty;
            bool isValid = true;
            do
            {
                Console.Clear();
                Console.Write(StringMessage.whatIsThePlate);
                plate = Console.ReadLine();
                isValid = LicensePlateValidator.ValidatorPlate(plate);
                if (!isValid) ServiceMessages.PlateIsNotValid();

            } while (!isValid);
            return plate;
           
        }

    }
}
