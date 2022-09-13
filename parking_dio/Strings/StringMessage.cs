﻿using parking_dio.Auxiliaries.Enums;

namespace parking_dio.Strings
{
    public static class StringMessage
    {
        public static readonly string invalidInput = "Dados de entradas invalidos tente novamento";
        public static readonly string inputPriceStartMessage = "Por favor informe taxa fixa da utilizar o serviço:";
        public static readonly string inputpricePerHourMessage = "Por favor informe o valor a ser cobrado por hora:";
        public static readonly string inputnumberOfVacanciesMessage = "Por favor informe a capacidade maxima de veiculos:";
        public static readonly string startProgramMessage = "###Bem vindo ao sistma de estacionamento dio###";
        public static readonly string loading = "Carregando";
        public static readonly string startMenuMessageOption = "###Escolha por favor a opção desejada###";
        public static readonly string registerNewVehicleOption = $"({(int)MenuOptions.RegisterNewVehicle}) Receber veiculo no patio.";
        public static readonly string listAllVehiclesOption = $"({(int)MenuOptions.ListAllVehicles}) Listar veículos no patio.";
        public static readonly string unregisterNewVehicleOption = $"({(int)MenuOptions.RemoveAVehicle}) Retirar veículo do patio.";
        public static readonly string endProgramOption = $"({(int)MenuOptions.EndProgram}) Encerrar o programa.";

    }
}
