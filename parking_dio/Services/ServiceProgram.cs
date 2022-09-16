using parking_dio.Auxiliaries;
using parking_dio.Auxiliaries.Enums;
using parking_dio.Models;
using parking_dio.Strings;
using System.Collections.Generic;
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
                    RegisterNewVehicle();
                    break;
                case (int)MenuOptions.ListAllVehicles:
                    ListAllVehicles();
                    break;
                case (int)MenuOptions.RemoveAVehicle:
                    RemoveVehicle();
                    break;
                case (int)MenuOptions.EndProgram:
                    ServiceMessages.MessageAndClear(StringMessage.exitProgram);
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
            if (_parking.IsNotFull)
            {
                _parking.Vehicles.Add(licensePlate, new Vehicle(licensePlate));
                ServiceMessages.MessageAndClear(StringMessage.successRegisterVehicle);
            }
            else
            {
                ServiceMessages.MessageAndClear(StringMessage.parkingIsFull);
            }
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

        private static void ListAllVehicles()
        {
            if (_parking.Vehicles.Count > 0)
            {
                foreach (var item in _parking.Vehicles)
                {
                    Console.WriteLine(item.Value.ToString());
                }
            ServiceMessages.ExitListVehicles();
            }
            else
            {
                ServiceMessages.MessageAndClear(StringMessage.notExistVehicles);
            }
        }

        private static void RemoveVehicle()
        {
            string licensePlate = ValidadePlate();
            if (ValidateRemove(licensePlate))
            {
                Console.Write(StringMessage.totalToPay);
                Console.WriteLine($"R${_parking.TotalToPay(_parking.Vehicles[licensePlate]).ToString("N2")}");
                RemoveAndSave(_parking.Vehicles[licensePlate]);
                ServiceMessages.MessageAndClear(StringMessage.vehicleRemoved);
            }
            
        }

        private static bool ValidateRemove(string plate)
        {
            if(_parking.Vehicles.Count == 0)
            {
                ServiceMessages.MessageAndClear(StringMessage.notExistVehicles);
                return false;
            }
            if (!_parking.Vehicles.ContainsKey(plate))
            {
                ServiceMessages.MessageAndClear(StringMessage.vehicleDoesNotExist);
                return false;
            }
            return true;
        }

        private static void RemoveAndSave(Vehicle vehicle)
        {
            var newVehicle = new Vehicle(vehicle.LicensePlate);
            newVehicle.EntryTime = vehicle.EntryTime;
            newVehicle.DepartureTime = DateTime.Now;
            _parking.VehiclesRemoved.Add(newVehicle);
            _parking.Vehicles.Remove(vehicle.LicensePlate);
        }

    }
}
