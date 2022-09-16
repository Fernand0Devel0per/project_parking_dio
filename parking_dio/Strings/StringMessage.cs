using parking_dio.Auxiliaries.Enums;

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
        public static readonly string chooseOptionMessage = "Escolha a opção:";
        public static readonly string invalidOption = "**Erro** Opção invalida, verifique as opção e escolha uma opção valida.";
        public static readonly string whatIsThePlate = "Informe a placa do Veiculo:";
        public static readonly string plateIsNotValid = "Esta placa não é valida.";
        public static readonly string successRegisterVehicle = "O Veiculo foi cadastrado com sucesso.";
        public static readonly string parkingIsFull = "O Estacionamento esta cheio.";
        public static readonly string finishListVehicles = "Tecle qualquer tecla para volta ao menu.";
        public static readonly string notExistVehicles = "Não existem veiculos no estacionamento neste momento.";
        public static readonly string vehicleDoesNotExist = "Veiculo não foi encontrado no estacionamento.";
        public static readonly string totalToPay = "O valor total a se pagar é:";
        public static readonly string vehicleRemoved = "O veiculo foi removido obrigado.";
        public static readonly string exitProgram = "Encerrando o Programa.";
        public static readonly string vehicleExist = "Este veiculo já esta cadastrado.";
    }
}
