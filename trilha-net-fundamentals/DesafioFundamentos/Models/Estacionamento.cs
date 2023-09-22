namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            try
            {
                this.veiculos.Add(Console.ReadLine());
                Console.WriteLine($"O veículo {this.veiculos.Last()} foi inserido com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel cadastrar o veiculo. Erro: " + ex.Message);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                int.TryParse(Console.ReadLine(), out horas);
                decimal valorTotal = this.precoInicial + (this.precoPorHora * horas); 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                try
                {
                    this.veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Não foi possivel finalizar o processo de saída. Erro: " + ex.Message);
                }

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine("N° - Placa do veículo");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                int contadorForeach = 1;
                foreach(string item in this.veiculos)
                {
                    Console.WriteLine($"{contadorForeach}  - {item}");
                    contadorForeach++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}