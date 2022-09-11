using parking_dio.Models;
using parking_dio.Strings;
using parking_dio.Services;

decimal priceStart = new decimal(0.00);
decimal pricePerHour = new decimal(0.00);
int numberOfVacancies = 0;

//Entrado do valor da taxa fixa do estacionamento
priceStart = ServiceParseNumber.ReceiveDecimal(StringMessage._inputPriceStartMessage);

//Entrada do valor a ser cobrado por hora
pricePerHour = ServiceParseNumber.ReceiveDecimal(StringMessage._inputpricePerHourMessage);

//Numero de vagas totais no estacionamento
numberOfVacancies = ServiceParseNumber.ReceiveInt(StringMessage._inputnumberOfVacanciesMessage);

//Criando estacionamento
Parking parking = new Parking(priceStart, pricePerHour, numberOfVacancies);

Console.WriteLine();


