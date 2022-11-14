using System;
using System.Collections.Generic;
using System.Text;

using TrabalhoFinalAeds.Entities.Enums;

namespace TrabalhoFinalAeds.Entities {
    public class Table {
        public int Number { get; private set; }
        public DateTime Data { get; private set; }
        public TableStatus Status { get; private set; }
        public List<Client> Clients { get; private set; }
        public FoodCommand Foods { get; private set; }
        public DrinkCommand Drinks { get; private set; }

        public Table() {
            Status = TableStatus.Free;
            Clients = new List<Client>();
            Foods = new FoodCommand();
            Drinks = new DrinkCommand();
        }
        public Table(int number, DateTime data, TableStatus status) : this(){
            Number = number;
            Data = data;
            Status = status;
        }

        public bool Reserve() {
            if (Status == TableStatus.Free) {
                Status = TableStatus.Reserved;
                return true;
            }
            return false;
        }
        public void CloseCommand() {
            Foods.CloseCommand();
            Drinks.CloseCommand();
        }
        public void OpenCommand() {
            Foods.OpenCommand();
            Drinks.OpenCommand();
        }
        public void AddClient(Client client) {
            Clients.Add(client);
        }
        public void AddConsumption(Item item) {
            if(item is FoodItem) {
                Foods.AddConsumption(item);
            }
            else if(item is DrinkItem) {
                Drinks.AddConsumption(item);
            }
        }
        public double TotalValue() {
            return (Foods.Value + Foods.CalculateTenPercent()) + (Drinks.Value + Drinks.CalculateTenPercent());
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table #{Number} ---- {Data.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Status: {Status}");
            sb.AppendLine($"Clients:");
            if (Clients.Count > 0) {
                foreach(Client c in Clients) {
                    sb.AppendLine($"{c}");
                }
            }
            else {
                sb.AppendLine("Nobody.");
            }
            sb.AppendLine($"Command:");
            sb.AppendLine($"Status: {Foods.Status}");
            sb.AppendLine($"Foods:");
            sb.AppendLine($"{Foods}");
            sb.AppendLine($"Drinks:");
            sb.AppendLine($"{Drinks}");
            sb.AppendLine($"Total command's value: R${TotalValue().ToString("F2")}");
            return sb.ToString();
        }

    }
}
