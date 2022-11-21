/* Trabalho Final de AEDs
 * 
 * Data: 13/11/2022
 * 
 * Integrantes do grupo: 
 * - Thales Davi de Souza
 * - Eduardo Santos Birchal
 * 
 */

namespace TrabalhoFinalAeds.Entities {
    public class TesteRestaurante {
        public static void Run() {
            Restaurant BuchinhoCheio = new Restaurant("Buchinho Cheio", "Barker Street 221B");
            Table? MesaClient = null;
            int Continue = 1;
            for (int i = 1; i <= 10; i++) {
                BuchinhoCheio.AddTable(new Table(i, DateTime.Now, Enums.TableStatus.Free));
            }
            do {
                Console.WriteLine($"Seja Bem-Vindo ao Restaurante: {BuchinhoCheio.Name}");
                if (MesaClient != null) {
                    Console.WriteLine("Sua mesa atual é a {0}", MesaClient.Number);
                }

                Console.WriteLine($"Como podemos te servir hoje?");
                Console.WriteLine("{ 1 } ~ Reservar/Trocar mesa");
                Console.WriteLine("{ 2 } ~ Adicionar pessoa");
                Console.WriteLine("{ 3 } ~ Listar pessoas");
                Console.WriteLine("{ 4 } ~ Fazer um pedido");
                Console.WriteLine("{ 5 } ~ Ver Total da Conta");
                Console.WriteLine("{ 0 } ~ Pagar a Conta (Fechar o programa)");
                int choose = int.Parse(Console.ReadLine());
                switch (choose) {
                    // Reservar/Trocar de mesa uma mesa
                    case 1:
                        List<Table> EmptyTables = BuchinhoCheio.Tables.FindAll(t => t.Status == Enums.TableStatus.Free);
                        if (EmptyTables.Count > 0) {
                            Console.WriteLine("As mesas que temos livres aqui:");
                            foreach (Table t in EmptyTables) {
                                Console.WriteLine($"~ Mesa #{t.Number}");
                            }

                            Console.WriteLine("Qual delas você deseja?");
                            int option = int.Parse(Console.ReadLine());
                            if(MesaClient != null) {
                                MesaClient.Reserve();
                                MesaClient.Clients.Clear();
                            }
                            if(EmptyTables.Find(t => t.Number == option) != null) {
                                MesaClient = EmptyTables.Find(t => t.Number == option);
                                MesaClient.Reserve();
                            }
                            else {
                                Console.WriteLine("Infelizmente essa mesa não é uma opção.");
                            }
                        }
                        else {
                            Console.WriteLine("Me desculpe mas infelizmente estamos sem mesas disponiveis.");
                            Continue = 5;
                        }
                        break;

                    case 2:
                        if(MesaClient == null) {
                            Console.WriteLine("Perdão Senhor(a)... Mas você precisa se sentar em uma mesa primeiro.");
                        }
                        else {
                            string novoCliente;
                            string email;

                            Console.WriteLine("Por favor insira os seguintes dados:");
                            Console.Write("Nome: ");
                            novoCliente = Console.ReadLine();
                            Console.Write("Email: ");
                            email = Console.ReadLine();

                            MesaClient.AddClient(new Client(novoCliente, email));
                        }
                        break;

                    case 3:
                        if (MesaClient == null) {
                            Console.WriteLine("Perdão Senhor(a)... Mas você precisa se sentar em uma mesa primeiro.");
                        }
                        else { 
                            Console.WriteLine("Pessoas na mesa até agora:");
                            foreach(Client c in MesaClient.Clients) {
                                Console.WriteLine(c);
                            }
                        }
                        break;

                    case 4:
                        if (MesaClient == null) {
                            Console.WriteLine("Perdão Senhor(a)... Mas você precisa se sentar em uma mesa primeiro.");
                        }
                        else {
                            int tipoPedido;
                            Console.WriteLine("Qual tipo de pedido você deseja fazer?");
                            Console.WriteLine("{ 1 } Comida");
                            Console.WriteLine("{ 2 } Bebida");
                            tipoPedido = int.Parse(Console.ReadLine());
                            Console.Write("Insira o nome: ");
                            string itemNome = Console.ReadLine();
                            Console.Write("Valor: ");
                            double itemPreco = double.Parse(Console.ReadLine());
                            Console.Write("Peso: ");
                            double itemPeso = double.Parse(Console.ReadLine());
                        
                            Item pedido = null;
                            switch(tipoPedido) {
                                case 1:
                                    pedido = new FoodItem(itemNome, itemPreco, itemPeso);
                                    break;
                                case 2:
                                    pedido = new DrinkItem(itemNome, itemPreco, itemPeso);
                                    break;
                            }
                        
                            MesaClient.AddConsumption(pedido);
                        }
                        break;

                    case 5:
                        if (MesaClient == null) {
                            Console.WriteLine("Perdão Senhor(a)... Mas você precisa se sentar em uma mesa primeiro.");
                        }
                        else {
                            Console.WriteLine(MesaClient);
                        }
                        break;

                    default:
                        Continue = 0;
                        break;
                }
            } while (Continue != 0);
        }
    }
}
