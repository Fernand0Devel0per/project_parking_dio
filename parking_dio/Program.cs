using parking_dio.Auxiliaries.Enums;
using parking_dio.Models;
using parking_dio.Services;
using parking_dio.Strings;



//Abertura do programa
ServiceMessages.StartProgram();



//Criando estacionamento
Parking parking = CoreService.CreateParking();

Console.Clear();

ServiceProgram.MenuExecution(parking);





