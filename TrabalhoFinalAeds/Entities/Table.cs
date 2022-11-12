using System.Collections.Generic;
using System.Text;

using TrabalhoFinalAeds.Entities.Enums;

namespace TrabalhoFinalAeds.Entities {
    public class Table {
        public int Number { get; private set; }
        public DateTime Data { get; private set; }
        public TableStatus Status { get; private set; }
        public List<Client> Clients { get; private set; }
        public Command TableCommand { get; private set; }

        public Table() {
            Status = TableStatus.Free;
            Clients = new List<Client>();
            TableCommand = new Command();
        }

        public bool Reserve() {
            if (Status == TableStatus.Free) {
                Status = TableStatus.Reserved;
                return true;
            }
            return false;
        }
        public void AddClient(Client client) {
            Clients.Add(client);
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
            sb.Append($"{TableCommand}");

            return sb.ToString();
        }

    }
}
