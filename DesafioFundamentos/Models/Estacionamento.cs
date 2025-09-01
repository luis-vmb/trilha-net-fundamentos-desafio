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
            // Implementada a função com validação de campo vazio.

            string placa = "";

            // Loop enquanto não cai nas condições de retorno ou break
            while (true)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar ou digite 'sair' para cancelar o cadastro");

                placa = Console.ReadLine();

                if (String.Equals(placa.ToUpper(), "sair"))
                {
                    Console.WriteLine("Voltando ao menu...");
                    break;
                }
                else if (String.IsNullOrWhiteSpace(placa))
                {
                    Console.Clear();
                    Console.WriteLine("Placa inválida, digite novamente");
                    continue;
                }

                veiculos.Add(placa.ToUpper());
                Console.WriteLine("Veículo adicionado!");
                break;
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Implementada a função de calcular o valorTotal do estacionamento.
                int horas = 0;
                decimal valorTotal = 0;

                // Convertendo o retorno de string para Int
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = this.precoInicial + (this.precoPorHora * horas);

                veiculos.Remove(placa.ToUpper());

                // Implementada a remoção do veículo da lista.
                Console.WriteLine($"O veículo de placa {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*

                foreach (string veiculo in veiculos)
                {
                    int posicao = veiculos.IndexOf(veiculo) + 1;

                    Console.WriteLine($"Veiculo de número {posicao}, placa: {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
