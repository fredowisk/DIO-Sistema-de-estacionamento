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
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            
            if (veiculos.Contains(placa.ToUpper()))
            {
                Console.WriteLine("\nEste veículo já está estacionado aqui.");
                return;
            }
            
            veiculos.Add(placa.ToUpper());
            Console.WriteLine($"\nVeículo com placa {placa} estacionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (!veiculos.Contains(placa.ToUpper())) 
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                return;
            }
            
            Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");
            if (int.TryParse(Console.ReadLine(), out int horas))
            {
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                return;
            }
            Console.WriteLine("\nEntrada inválida para a quantidade de horas.");
        }

        public void ListarVeiculos()
        {
            if (!veiculos.Any())
            {
                Console.WriteLine("\nNão há veículos estacionados.");
                return;
            }

            Console.WriteLine("\nOs veículos estacionados são:");
            foreach (var placa in veiculos)
            {
                Console.WriteLine(placa);
            }
        }
    }
}
