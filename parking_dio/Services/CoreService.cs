using parking_dio.Models;
using parking_dio.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking_dio.Services
{
    public static class CoreService
    {

        static decimal priceStart = new decimal(0.00);
        static decimal pricePerHour = new decimal(0.00);
        static int numberOfVacancies = 0;

        public static Parking CreateParking()
        {
            //Entrado do valor da taxa fixa do estacionamento
            priceStart = ServiceParseNumber.ReceiveDecimal(StringMessage.inputPriceStartMessage);

            //Entrada do valor a ser cobrado por hora
            pricePerHour = ServiceParseNumber.ReceiveDecimal(StringMessage.inputpricePerHourMessage);

            //Numero de vagas totais no estacionamento
            numberOfVacancies = ServiceParseNumber.ReceiveInt(StringMessage.inputnumberOfVacanciesMessage);
            return new Parking(priceStart, pricePerHour, numberOfVacancies);
        }
    }
}
