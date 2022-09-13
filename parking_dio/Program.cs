using parking_dio.Auxiliaries.Enums;
using parking_dio.Models;
using parking_dio.Services;
using parking_dio.Strings;

decimal priceStart = new decimal(0.00);
decimal pricePerHour = new decimal(0.00);
int numberOfVacancies = 0;

//Abertura do programa
ServiceMessages.StartProgram();

//Entrado do valor da taxa fixa do estacionamento
priceStart = ServiceParseNumber.ReceiveDecimal(StringMessage.inputPriceStartMessage);

//Entrada do valor a ser cobrado por hora
pricePerHour = ServiceParseNumber.ReceiveDecimal(StringMessage.inputpricePerHourMessage);

//Numero de vagas totais no estacionamento
numberOfVacancies = ServiceParseNumber.ReceiveInt(StringMessage.inputnumberOfVacanciesMessage);

//Criando estacionamento
Parking parking = new Parking(priceStart, pricePerHour, numberOfVacancies);

Console.WriteLine();

int option = 0;

ServiceMessages.MenuOptions();
//while (option == (int)MenuOptions.EndProgram)
//{

//}




